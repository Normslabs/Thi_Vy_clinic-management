-- Close all connections and drop database if exists
USE master;
GO

IF DB_ID('HealthCareClinicDB') IS NOT NULL
    DROP DATABASE HealthCareClinicDB;
GO

CREATE DATABASE HealthCareClinicDB;
GO

USE HealthCareClinicDB;
GO

-- DROP STORED PROCEDURES
IF OBJECT_ID('dbo.sp_GetAvailableSlots', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetAvailableSlots;
GO

IF OBJECT_ID('dbo.sp_CancelAppointment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_CancelAppointment;
GO

IF OBJECT_ID('dbo.sp_BookAppointment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_BookAppointment;
GO

IF OBJECT_ID('dbo.sp_GetDoctorCurrentSchedule', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetDoctorCurrentSchedule;
GO

-- DROP VIEWS
IF OBJECT_ID('dbo.vw_DoctorWorkloadStats', 'V') IS NOT NULL
    DROP VIEW dbo.vw_DoctorWorkloadStats;
GO

IF OBJECT_ID('dbo.vw_PatientRecordsSummary', 'V') IS NOT NULL
    DROP VIEW dbo.vw_PatientRecordsSummary;
GO

IF OBJECT_ID('dbo.vw_UpcomingAppointments', 'V') IS NOT NULL
    DROP VIEW dbo.vw_UpcomingAppointments;
GO

IF OBJECT_ID('dbo.vw_DoctorCurrentSchedule', 'V') IS NOT NULL
    DROP VIEW dbo.vw_DoctorCurrentSchedule;
GO

-- DROP TABLES (correct FK order: children → parents)
IF OBJECT_ID('dbo.Appointment', 'U') IS NOT NULL
    DROP TABLE dbo.Appointment;
GO

IF OBJECT_ID('dbo.DoctorSchedule', 'U') IS NOT NULL
    DROP TABLE dbo.DoctorSchedule;
GO

IF OBJECT_ID('dbo.DoctorSpecialties', 'U') IS NOT NULL
    DROP TABLE dbo.DoctorSpecialties;
GO

IF OBJECT_ID('dbo.TimeSlots', 'U') IS NOT NULL
    DROP TABLE dbo.TimeSlots;
GO

IF OBJECT_ID('dbo.Patient', 'U') IS NOT NULL
    DROP TABLE dbo.Patient;
GO

IF OBJECT_ID('dbo.Doctor', 'U') IS NOT NULL
    DROP TABLE dbo.Doctor;
GO

IF OBJECT_ID('dbo.Specialties', 'U') IS NOT NULL
    DROP TABLE dbo.Specialties;
GO

IF OBJECT_ID('dbo.UserRoles', 'U') IS NOT NULL
    DROP TABLE dbo.UserRoles;
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

IF OBJECT_ID('dbo.Roles', 'U') IS NOT NULL
    DROP TABLE dbo.Roles;
GO


PRINT 'All views, tables, and stored procedures have been dropped successfully.';
GO

-- TABLE: Users
CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username VARCHAR(32) NOT NULL UNIQUE,
    PasswordHash VARCHAR(256) NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: Roles
CREATE TABLE dbo.Roles (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    RoleName VARCHAR(64) NOT NULL UNIQUE,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: UserRoles (junction table)
CREATE TABLE dbo.UserRoles (
    UserId INT NOT NULL,
    RoleId INT NOT NULL,
    CONSTRAINT PK_UserRoles PRIMARY KEY (UserId, RoleId),
    CONSTRAINT FK_UserRoles_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE CASCADE,
    CONSTRAINT FK_UserRoles_Roles FOREIGN KEY (RoleId) REFERENCES dbo.Roles(Id) ON DELETE CASCADE
);
GO

-- TABLE: Patient
CREATE TABLE dbo.Patient(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    InsuranceNumber VARCHAR(24) NOT NULL UNIQUE,
    DateOfBirth DATETIME2(7) NOT NULL,
    PhoneNumber VARCHAR(20) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT CK_Patient_InsuranceNumber CHECK (
        -- Quebec Health Card: 4 letters + 8 digits + 2 digits (AAAA12345678 with space before last 2 digits)
        (InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9] [0-9][0-9]'
        OR
        InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
        OR
        -- Canadian Health Card (generic): 10 digits
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        OR
        -- Ontario Health Card: 10 digits + 2 letters (1234567890-AB with optional hyphen)
        (InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[A-Z][A-Z]'
        OR
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z]')
    )
);
GO

-- TABLE: Specialties
CREATE TABLE dbo.Specialties (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name VARCHAR(64) NOT NULL UNIQUE
);
GO

-- TABLE: Doctor
CREATE TABLE dbo.Doctor(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    LicenseNumber VARCHAR(24) NOT NULL UNIQUE,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: DoctorSpecialties (junction table)
CREATE TABLE dbo.DoctorSpecialties (
    DoctorId INT NOT NULL,
    SpecialtyId INT NOT NULL,
    CONSTRAINT PK_DoctorSpecialties PRIMARY KEY (DoctorId, SpecialtyId),
    CONSTRAINT FK_DoctorSpecialties_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE,
    CONSTRAINT FK_DoctorSpecialties_Specialties FOREIGN KEY (SpecialtyId) REFERENCES dbo.Specialties(Id) ON DELETE CASCADE
);
GO

-- TABLE: DoctorSchedule
CREATE TABLE dbo.DoctorSchedule(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DoctorId INT NOT NULL,
    DayOfWeek VARCHAR(10) NOT NULL CHECK (DayOfWeek IN ('SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY')),
    WorkStartTime TIME NOT NULL,
    WorkEndTime TIME NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_DoctorSchedule_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE
);
GO

-- TABLE: TimeSlots
CREATE TABLE dbo.TimeSlots(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    HourOfDay INT NOT NULL,
    MinuteOfHour INT NOT NULL,
    CONSTRAINT UQ_TimeSlots_Time UNIQUE (HourOfDay, MinuteOfHour),
    CONSTRAINT CK_TimeSlots_Hour CHECK (HourOfDay >= 0 AND HourOfDay <= 23),
    CONSTRAINT CK_TimeSlots_Minute CHECK (MinuteOfHour >= 0 AND MinuteOfHour <= 59)
);
GO

-- TABLE: Appointment
CREATE TABLE dbo.Appointment(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Date DATE NOT NULL,
    Notes VARCHAR(512) NULL,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    TimeSlotId INT NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Appointment_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_Patient FOREIGN KEY (PatientId) REFERENCES dbo.Patient(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_TimeSlot FOREIGN KEY (TimeSlotId) REFERENCES dbo.TimeSlots(Id) ON DELETE NO ACTION,
    CONSTRAINT UQ_Appointment_DateTime UNIQUE (DoctorId, Date, TimeSlotId)
);
GO

-- INSERT SAMPLE DATA

DECLARE @RoleId1 INT, @RoleId2 INT, @RoleId3 INT;
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Administrator', GETDATE(), GETDATE());
SET @RoleId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Doctor', GETDATE(), GETDATE());
SET @RoleId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Receptionist', GETDATE(), GETDATE());
SET @RoleId3 = SCOPE_IDENTITY();

DECLARE @UserId1 INT, @UserId2 INT, @UserId3 INT, @UserId4 INT, @UserId5 INT, @UserId6 INT;
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('admin', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_who', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_smith', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId3 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_jones', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId4 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('receptionist1', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId5 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('receptionist2', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId6 = SCOPE_IDENTITY();

INSERT INTO dbo.UserRoles (UserId, RoleId) VALUES
(@UserId1, @RoleId1), -- admin -> Administrator
(@UserId2, @RoleId2), -- dr_who -> Doctor
(@UserId3, @RoleId2), -- dr_smith -> Doctor
(@UserId4, @RoleId2), -- dr_jones -> Doctor
(@UserId5, @RoleId3), -- receptionist1 -> Receptionist
(@UserId6, @RoleId3); -- receptionist2 -> Receptionist

DECLARE @SpecialtyId1 INT, @SpecialtyId2 INT, @SpecialtyId3 INT;
INSERT INTO dbo.Specialties (Name) VALUES ('General Practice');
SET @SpecialtyId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Specialties (Name) VALUES ('Cardiology');
SET @SpecialtyId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Specialties (Name) VALUES ('Pediatrics');
SET @SpecialtyId3 = SCOPE_IDENTITY();

DECLARE @DoctorId1 INT, @DoctorId2 INT, @DoctorId3 INT;
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('John', 'Who', 'LIC001234', GETDATE(), GETDATE());
SET @DoctorId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Sarah', 'Smith', 'LIC002345', GETDATE(), GETDATE());
SET @DoctorId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Michael', 'Jones', 'LIC003456', GETDATE(), GETDATE());
SET @DoctorId3 = SCOPE_IDENTITY();

INSERT INTO dbo.DoctorSpecialties (DoctorId, SpecialtyId) VALUES
(@DoctorId1, @SpecialtyId1), -- Dr. Who -> General Practice
(@DoctorId2, @SpecialtyId2), -- Dr. Smith -> Cardiology
(@DoctorId3, @SpecialtyId3); -- Dr. Jones -> Pediatrics

DECLARE @PatientId1 INT, @PatientId2 INT, @PatientId3 INT, @PatientId4 INT, @PatientId5 INT;
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Emma','Wilson','1985-03-15','WILE85031500 01','555-0101',GETDATE(),GETDATE());
SET @PatientId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('James','Brown','1990-07-22','BROJ90072200 02','555-0102',GETDATE(),GETDATE());
SET @PatientId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Olivia','Davis','1978-11-30','DAVO78113000 03','555-0103',GETDATE(),GETDATE());
SET @PatientId3 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('William','Miller','2015-05-10','MILW15051000 04','555-0104',GETDATE(),GETDATE());
SET @PatientId4 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Sophia','Garcia','1995-09-18','GARS95091800 05','555-0105',GETDATE(),GETDATE());
SET @PatientId5 = SCOPE_IDENTITY();

INSERT INTO dbo.DoctorSchedule (DoctorId, DayOfWeek, WorkStartTime, WorkEndTime, CreatedAt, ModifiedAt) VALUES
-- Dr. Who (Monday-Friday 9AM-5PM)
(@DoctorId1, 'MONDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'TUESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'WEDNESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'THURSDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'FRIDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
-- Dr. Smith (Monday-Thursday 8AM-4PM)
(@DoctorId2, 'MONDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'TUESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'WEDNESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'THURSDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
-- Dr. Jones (Tuesday-Saturday 10AM-6PM)
(@DoctorId3, 'TUESDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'WEDNESDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'THURSDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'FRIDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'SATURDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE());

DECLARE @hour INT = 8;
DECLARE @minute INT = 0;

WHILE @hour < 18
BEGIN
    INSERT INTO dbo.TimeSlots (HourOfDay, MinuteOfHour) VALUES (@hour, @minute);
    SET @minute = @minute + 30;
    IF @minute >= 60
    BEGIN
        SET @minute = 0;
        SET @hour = @hour + 1;
    END
END

INSERT INTO dbo.Appointment (PatientId, DoctorId, TimeSlotId, Date, Notes, CreatedAt, ModifiedAt) VALUES
(@PatientId1, @DoctorId1, 5, '2025-11-25', 'Annual checkup', GETDATE(), GETDATE()), -- 10:00 AM
(@PatientId2, @DoctorId2, 13, '2025-11-26', 'Heart consultation', GETDATE(), GETDATE()), -- 2:00 PM
(@PatientId3, @DoctorId1, 7, '2025-11-22', 'Follow-up visit', GETDATE(), GETDATE()), -- 11:00 AM
(@PatientId4, @DoctorId3, 15, '2025-11-27', 'Child vaccination', GETDATE(), GETDATE()), -- 3:00 PM
(@PatientId5, @DoctorId2, 3, '2025-11-23', 'Cardiac screening', GETDATE(), GETDATE()), -- 9:00 AM
(@PatientId1, @DoctorId2, 6, '2025-12-01', 'Blood pressure check', GETDATE(), GETDATE()); -- 10:30 AM

GO

-- VIEW 1: Doctor's Current Schedule
CREATE VIEW dbo.vw_DoctorCurrentSchedule
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    sc.DayOfWeek,
    CONVERT(VARCHAR(5), sc.WorkStartTime, 108) AS StartTime,
    CONVERT(VARCHAR(5), sc.WorkEndTime, 108) AS EndTime,
    d.LicenseNumber
FROM 
    dbo.Doctor d
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
    LEFT JOIN dbo.DoctorSchedule sc ON d.Id = sc.DoctorId;
GO

-- VIEW 2: Upcoming Appointments Summary
CREATE VIEW dbo.vw_UpcomingAppointments
AS
SELECT 
    a.Id AS AppointmentId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    a.Date AS AppointmentDate,
    ts.HourOfDay,
    ts.MinuteOfHour,
    a.Notes,
    a.PatientId,
    a.DoctorId
FROM 
    dbo.Appointment a
    INNER JOIN dbo.Patient p ON a.PatientId = p.Id
    INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
    INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
WHERE 
    a.Date >= CAST(GETDATE() AS DATE);
GO

-- VIEW 3: Patient Medical Records Summary
CREATE VIEW dbo.vw_PatientRecordsSummary
AS
SELECT 
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.InsuranceNumber,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) - 
        CASE 
            WHEN MONTH(p.DateOfBirth) > MONTH(GETDATE()) 
                OR (MONTH(p.DateOfBirth) = MONTH(GETDATE()) AND DAY(p.DateOfBirth) > DAY(GETDATE()))
            THEN 1 
            ELSE 0 
        END AS Age,
    p.PhoneNumber,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE PatientId = p.Id) AS TotalAppointments,
    (SELECT MAX(Date) FROM dbo.Appointment WHERE PatientId = p.Id) AS LastAppointmentDate
FROM 
    dbo.Patient p;
GO

-- VIEW 4: Doctor Workload Statistics
CREATE VIEW dbo.vw_DoctorWorkloadStats
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Date >= CAST(GETDATE() AS DATE)) AS UpcomingAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Date < CAST(GETDATE() AS DATE)) AS CompletedAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id) AS TotalAppointments
FROM 
    dbo.Doctor d
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id;
GO

-- PROCEDURE 1: Get Doctor's Current Schedule
CREATE PROCEDURE dbo.sp_GetDoctorCurrentSchedule
    @DoctorId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @DoctorId IS NULL
    BEGIN
        -- Return all doctors' schedules
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        ORDER BY DoctorName, DayOfWeek;
    END
    ELSE
    BEGIN
        -- Return specific doctor's schedule
        IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
        BEGIN
            RAISERROR('Doctor not found', 16, 1);
            RETURN;
        END
        
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        WHERE DoctorId = @DoctorId
        ORDER BY DayOfWeek;
    END
END
GO

-- PROCEDURE 2: Book New Appointment
CREATE PROCEDURE dbo.sp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @AppointmentDate DATE,
    @TimeSlotId INT,
    @Notes VARCHAR(512) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @NewId INT;
    
    -- Validate inputs
    IF NOT EXISTS (SELECT 1 FROM dbo.Patient WHERE Id = @PatientId)
    BEGIN
        RAISERROR('Patient not found', 16, 1);
        RETURN;
    END
    
    IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
    BEGIN
        RAISERROR('Doctor not found', 16, 1);
        RETURN;
    END
    
    IF NOT EXISTS (SELECT 1 FROM dbo.TimeSlots WHERE Id = @TimeSlotId)
    BEGIN
        RAISERROR('Time slot not found', 16, 1);
        RETURN;
    END
    
    IF @AppointmentDate < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Appointment date cannot be in the past', 16, 1);
        RETURN;
    END
    
    -- Check for existing appointment at this time
    IF EXISTS (
        SELECT 1 
        FROM dbo.Appointment 
        WHERE DoctorId = @DoctorId 
            AND Date = @AppointmentDate
            AND TimeSlotId = @TimeSlotId
    )
    BEGIN
        RAISERROR('This time slot is already booked', 16, 1);
        RETURN;
    END
    
    -- Insert new appointment
    INSERT INTO dbo.Appointment 
        (PatientId, DoctorId, Date, TimeSlotId, Notes, CreatedAt, ModifiedAt)
    VALUES 
        (@PatientId, @DoctorId, @AppointmentDate, @TimeSlotId, @Notes, GETDATE(), GETDATE());
    
    -- Get the new ID
    SET @NewId = SCOPE_IDENTITY();
    
    -- Return the new appointment details
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.Date AS AppointmentDate,
        ts.HourOfDay,
        ts.MinuteOfHour,
        a.Notes
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
        INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    WHERE 
        a.Id = @NewId;
END
GO

-- PROCEDURE 3: Cancel Appointment
CREATE PROCEDURE dbo.sp_CancelAppointment
    @AppointmentId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check if appointment exists
    IF NOT EXISTS (SELECT 1 FROM dbo.Appointment WHERE Id = @AppointmentId)
    BEGIN
        RAISERROR('Appointment not found', 16, 1);
        RETURN;
    END
    
    -- Return confirmation with appointment details before deleting
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.Date AS AppointmentDate,
        ts.HourOfDay,
        ts.MinuteOfHour,
        'Appointment cancelled successfully' AS Message
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
        INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    WHERE 
        a.Id = @AppointmentId;
    
    -- Delete the appointment
    DELETE FROM dbo.Appointment WHERE Id = @AppointmentId;
END
GO

-- PROCEDURE 4: Get Available Appointment Slots
CREATE PROCEDURE dbo.sp_GetAvailableSlots
    @DoctorId INT,
    @Date DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Validate doctor exists
    IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
    BEGIN
        RAISERROR('Doctor not found', 16, 1);
        RETURN;
    END
    
    DECLARE @DayName VARCHAR(10);
    SET @DayName = UPPER(DATENAME(WEEKDAY, @Date));
    
    -- Return available time slots based on doctor's schedule
    SELECT 
        d.Id AS DoctorId,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        s.Name AS Specialization,
        @Date AS RequestedDate,
        @DayName AS DayOfWeek,
        ts.Id AS TimeSlotId,
        ts.HourOfDay,
        ts.MinuteOfHour,
        CASE WHEN a.Id IS NOT NULL THEN 1 ELSE 0 END AS IsBooked
    FROM 
        dbo.Doctor d
        LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
        LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
        INNER JOIN dbo.DoctorSchedule sc ON d.Id = sc.DoctorId AND sc.DayOfWeek = @DayName
        CROSS JOIN dbo.TimeSlots ts
        LEFT JOIN dbo.Appointment a ON d.Id = a.DoctorId 
            AND a.Date = @Date
            AND a.TimeSlotId = ts.Id
    WHERE 
        d.Id = @DoctorId
        AND CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + CAST(ts.MinuteOfHour AS VARCHAR) AS TIME) >= CAST(sc.WorkStartTime AS TIME)
        AND CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + CAST(ts.MinuteOfHour AS VARCHAR) AS TIME) < CAST(sc.WorkEndTime AS TIME)
    ORDER BY 
        ts.HourOfDay, ts.MinuteOfHour;
END
GO