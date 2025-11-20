USE MASTER;
GO

IF DB_ID('HealthCareClinicDB') IS NOT NULL
	DROP DATABASE HealthCareClinicDB;
GO

CREATE DATABASE HealthCareClinicDB;
GO

USE HealthCareClinicDB;
GO

IF OBJECT_ID('dbo.Appointment', 'U') IS NOT NULL DROP TABLE [dbo].[Appointment];

CREATE TABLE [dbo].[Appointment](
	[Id] [int] NOT NULL PRIMARY KEY,
	[PatientId] [int] NULL,
	[DoctorId] [int] NULL,
	[CreatedBy] [int] NULL,
	[Description] [varchar](500) NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Duration] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
)
GO

IF OBJECT_ID('dbo.Schedule', 'U') IS NOT NULL DROP TABLE [dbo].[Schedule];

CREATE TABLE [dbo].[Schedule](
	[Id] [int] NOT NULL PRIMARY KEY,
	[DoctorId] [int] NOT NULL,
	[Schedule] [varchar](500) NULL,
	[EffectiveDate] [datetime] NOT NULL
)
GO

IF OBJECT_ID('dbo.Doctor', 'U') IS NOT NULL DROP TABLE [dbo].[Doctor];

CREATE TABLE [dbo].[Doctor](
	[Id] [int] NOT NULL PRIMARY KEY,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Specialization] [varchar](100) NOT NULL,
	[Availability] [varchar](500) NOT NULL
)
GO

IF OBJECT_ID('dbo.Patient', 'U') IS NOT NULL DROP TABLE [dbo].[Patient];

CREATE TABLE [dbo].[Patient](
	[Id] [int] NOT NULL PRIMARY KEY,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[MedicalNumber] [varchar](20) NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Email] [varchar](100) NULL
)
GO

IF OBJECT_ID('dbo.User', 'U') IS NOT NULL DROP TABLE [dbo].[User];

CREATE TABLE [dbo].[User](
	[Id] [int] NOT NULL PRIMARY KEY,
	[Username] [varchar](50) NOT NULL,
	[PasswordHash] [varchar](255) NOT NULL,
	[Role] [varchar](20) NOT NULL
)
GO

ALTER TABLE [dbo].[Appointment] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ('Receptionist') FOR [Role]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([DoctorId])
REFERENCES [dbo].[Doctor] ([Id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patient] ([Id])
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[User] ([Id])
GO

INSERT INTO [dbo].[User] ([Id], [Username], [PasswordHash], [Role]) VALUES (1, N'admin', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Administrator')
INSERT INTO [dbo].[User] ([Id], [Username], [PasswordHash], [Role]) VALUES (2, N'dr_who', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Doctor')

-- Insert Users
INSERT INTO [dbo].[User] ([Id], [Username], [PasswordHash], [Role]) VALUES 
(3, N'dr_smith', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Doctor'),
(4, N'dr_jones', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Doctor'),
(5, N'receptionist1', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Receptionist'),
(6, N'receptionist2', N'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', N'Receptionist');
GO

-- Insert Doctors
INSERT INTO [dbo].[Doctor] ([Id], [FirstName], [LastName], [Specialization], [Availability]) VALUES 
(2, N'John', N'Who', N'General Practice', N'Monday-Friday 9AM-5PM'),
(3, N'Sarah', N'Smith', N'Cardiology', N'Monday-Thursday 8AM-4PM'),
(4, N'Michael', N'Jones', N'Pediatrics', N'Tuesday-Saturday 10AM-6PM');
GO

-- Insert Patients
INSERT INTO [dbo].[Patient] ([Id], [FirstName], [LastName], [DateOfBirth], [MedicalNumber], [PhoneNumber], [Email]) VALUES 
(1, N'Emma', N'Wilson', '1985-03-15', N'MED001', N'555-0101', N'emma.wilson@email.com'),
(2, N'James', N'Brown', '1990-07-22', N'MED002', N'555-0102', N'james.brown@email.com'),
(3, N'Olivia', N'Davis', '1978-11-30', N'MED003', N'555-0103', N'olivia.davis@email.com'),
(4, N'William', N'Miller', '2015-05-10', N'MED004', N'555-0104', N'parent.miller@email.com'),
(5, N'Sophia', N'Garcia', '1995-09-18', N'MED005', N'555-0105', N'sophia.garcia@email.com');
GO

-- Insert Schedules
INSERT INTO [dbo].[Schedule] ([Id], [DoctorId], [Schedule], [EffectiveDate]) VALUES 
(1, 2, N'Mon: 9AM-5PM, Tue: 9AM-5PM, Wed: 9AM-5PM, Thu: 9AM-5PM, Fri: 9AM-5PM', '2025-01-01'),
(2, 3, N'Mon: 8AM-4PM, Tue: 8AM-4PM, Wed: 8AM-4PM, Thu: 8AM-4PM', '2025-01-01'),
(3, 4, N'Tue: 10AM-6PM, Wed: 10AM-6PM, Thu: 10AM-6PM, Fri: 10AM-6PM, Sat: 10AM-6PM', '2025-01-01');
GO

-- Insert Appointments
INSERT INTO [dbo].[Appointment] ([Id], [PatientId], [DoctorId], [CreatedBy], [Description], [AppointmentDate], [Status], [Duration], [ModifiedDate]) VALUES 
(1, 1, 2, 5, N'Annual checkup', '2025-11-25 10:00:00', N'Scheduled', 30, GETDATE()),
(2, 2, 3, 5, N'Heart consultation', '2025-11-26 14:00:00', N'Scheduled', 45, GETDATE()),
(3, 3, 2, 6, N'Follow-up visit', '2025-11-22 11:00:00', N'Completed', 20, GETDATE()),
(4, 4, 4, 5, N'Child vaccination', '2025-11-27 15:00:00', N'Scheduled', 30, GETDATE()),
(5, 5, 3, 6, N'Cardiac screening', '2025-11-23 09:00:00', N'Cancelled', 60, GETDATE()),
(6, 1, 3, 5, N'Blood pressure check', '2025-12-01 10:30:00', N'Scheduled', 30, GETDATE());
GO

-- =============================================
-- VIEW 1: Doctor's Current Schedule
-- =============================================
IF OBJECT_ID('dbo.vw_DoctorCurrentSchedule', 'V') IS NOT NULL 
    DROP VIEW dbo.vw_DoctorCurrentSchedule;
GO

CREATE VIEW dbo.vw_DoctorCurrentSchedule
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    s.Schedule AS CurrentSchedule,
    s.EffectiveDate,
    d.Availability
FROM 
    [dbo].[Doctor] d
    INNER JOIN [dbo].[Schedule] s ON d.Id = s.DoctorId
WHERE 
    s.EffectiveDate = (
        SELECT MAX(EffectiveDate) 
        FROM [dbo].[Schedule] 
        WHERE DoctorId = d.Id
    );
GO

-- =============================================
-- VIEW 2: Upcoming Appointments Summary
-- =============================================
IF OBJECT_ID('dbo.vw_UpcomingAppointments', 'V') IS NOT NULL 
    DROP VIEW dbo.vw_UpcomingAppointments;
GO

CREATE VIEW dbo.vw_UpcomingAppointments
AS
SELECT 
    a.Id AS AppointmentId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    a.AppointmentDate,
    a.Duration,
    a.Description,
    a.Status
FROM 
    [dbo].[Appointment] a
    INNER JOIN [dbo].[Patient] p ON a.PatientId = p.Id
    INNER JOIN [dbo].[Doctor] d ON a.DoctorId = d.Id
WHERE 
    a.AppointmentDate >= CAST(GETDATE() AS DATE)
    AND a.Status = 'Scheduled';
GO

-- =============================================
-- VIEW 3: Patient Medical Records Summary
-- =============================================
IF OBJECT_ID('dbo.vw_PatientRecordsSummary', 'V') IS NOT NULL 
    DROP VIEW dbo.vw_PatientRecordsSummary;
GO

CREATE VIEW dbo.vw_PatientRecordsSummary
AS
SELECT 
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.MedicalNumber,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) AS Age,
    p.PhoneNumber,
    p.Email,
    COUNT(a.Id) AS TotalAppointments,
    MAX(a.AppointmentDate) AS LastAppointmentDate
FROM 
    [dbo].[Patient] p
    LEFT JOIN [dbo].[Appointment] a ON p.Id = a.PatientId
GROUP BY 
    p.Id, p.FirstName, p.LastName, p.MedicalNumber, 
    p.DateOfBirth, p.PhoneNumber, p.Email;
GO

-- =============================================
-- VIEW 4: Doctor Workload Statistics
-- =============================================
IF OBJECT_ID('dbo.vw_DoctorWorkloadStats', 'V') IS NOT NULL 
    DROP VIEW dbo.vw_DoctorWorkloadStats;
GO

CREATE VIEW dbo.vw_DoctorWorkloadStats
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    COUNT(CASE WHEN a.Status = 'Scheduled' THEN 1 END) AS ScheduledAppointments,
    COUNT(CASE WHEN a.Status = 'Completed' THEN 1 END) AS CompletedAppointments,
    COUNT(CASE WHEN a.Status = 'Cancelled' THEN 1 END) AS CancelledAppointments,
    SUM(CASE WHEN a.Status = 'Scheduled' THEN a.Duration ELSE 0 END) AS TotalScheduledMinutes
FROM 
    [dbo].[Doctor] d
    LEFT JOIN [dbo].[Appointment] a ON d.Id = a.DoctorId
GROUP BY 
    d.Id, d.FirstName, d.LastName, d.Specialization;
GO

-- =============================================
-- PROCEDURE 1: Get Doctor's Current Schedule
-- =============================================
IF OBJECT_ID('dbo.sp_GetDoctorCurrentSchedule', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.sp_GetDoctorCurrentSchedule;
GO

CREATE PROCEDURE dbo.sp_GetDoctorCurrentSchedule
    @DoctorId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @DoctorId IS NULL
    BEGIN
        -- Return all doctors' schedules
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        ORDER BY DoctorName;
    END
    ELSE
    BEGIN
        -- Return specific doctor's schedule
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        WHERE DoctorId = @DoctorId;
    END
END
GO

-- =============================================
-- PROCEDURE 2: Book New Appointment
-- =============================================
IF OBJECT_ID('dbo.sp_BookAppointment', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.sp_BookAppointment;
GO

CREATE PROCEDURE dbo.sp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @CreatedBy INT,
    @Description VARCHAR(500),
    @AppointmentDate DATETIME,
    @Duration INT = 30
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @NewId INT;
    DECLARE @Status VARCHAR(50) = 'Scheduled';
    
    -- Get next available ID
    SELECT @NewId = ISNULL(MAX(Id), 0) + 1 FROM [dbo].[Appointment];
    
    -- Insert new appointment
    INSERT INTO [dbo].[Appointment] 
        ([Id], [PatientId], [DoctorId], [CreatedBy], [Description], 
         [AppointmentDate], [Status], [Duration], [ModifiedDate])
    VALUES 
        (@NewId, @PatientId, @DoctorId, @CreatedBy, @Description, 
         @AppointmentDate, @Status, @Duration, GETDATE());
    
    -- Return the new appointment details
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.AppointmentDate,
        a.Duration,
        a.Status
    FROM 
        [dbo].[Appointment] a
        INNER JOIN [dbo].[Patient] p ON a.PatientId = p.Id
        INNER JOIN [dbo].[Doctor] d ON a.DoctorId = d.Id
    WHERE 
        a.Id = @NewId;
END
GO

-- =============================================
-- PROCEDURE 3: Cancel Appointment
-- =============================================
IF OBJECT_ID('dbo.sp_CancelAppointment', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.sp_CancelAppointment;
GO

CREATE PROCEDURE dbo.sp_CancelAppointment
    @AppointmentId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check if appointment exists and is scheduled
    IF EXISTS (SELECT 1 FROM [dbo].[Appointment] 
               WHERE Id = @AppointmentId AND Status = 'Scheduled')
    BEGIN
        -- Update status to Cancelled
        UPDATE [dbo].[Appointment]
        SET Status = 'Cancelled',
            ModifiedDate = GETDATE()
        WHERE Id = @AppointmentId;
        
        SELECT 'Appointment cancelled successfully' AS Message;
    END
    ELSE
    BEGIN
        SELECT 'Appointment not found or cannot be cancelled' AS Message;
    END
END
GO

-- =============================================
-- PROCEDURE 4: Get Available Appointment Slots
-- =============================================
IF OBJECT_ID('dbo.sp_GetAvailableSlots', 'P') IS NOT NULL 
    DROP PROCEDURE dbo.sp_GetAvailableSlots;
GO

CREATE PROCEDURE dbo.sp_GetAvailableSlots
    @DoctorId INT,
    @Date DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Return doctor info and booked appointments for the day
    SELECT 
        d.FirstName + ' ' + d.LastName AS DoctorName,
        d.Specialization,
        s.Schedule AS DoctorSchedule,
        @Date AS RequestedDate,
        a.AppointmentDate AS BookedSlots,
        a.Duration AS SlotDuration
    FROM 
        [dbo].[Doctor] d
        LEFT JOIN [dbo].[Schedule] s ON d.Id = s.DoctorId
        LEFT JOIN [dbo].[Appointment] a ON d.Id = a.DoctorId 
            AND CAST(a.AppointmentDate AS DATE) = @Date
            AND a.Status = 'Scheduled'
    WHERE 
        d.Id = @DoctorId
        AND (s.EffectiveDate = (SELECT MAX(EffectiveDate) 
                                FROM [dbo].[Schedule] 
                                WHERE DoctorId = d.Id)
             OR s.EffectiveDate IS NULL)
    ORDER BY 
        a.AppointmentDate;
END
GO