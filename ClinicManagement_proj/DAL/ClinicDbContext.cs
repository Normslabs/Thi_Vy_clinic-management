using System;
using System.Data.Entity;
using System.Linq;
using ClinicManagement_proj.BLL.DTO;

namespace ClinicManagement_proj.DAL
{
    internal class ClinicDbContext : DbContext
    {
        public DbSet<AppointmentDTO> Appointments { get; set; }
        public DbSet<DoctorDTO> Doctors { get; set; }
        public DbSet<DoctorScheduleDTO> DoctorSchedules { get; set; }
        public DbSet<PatientDTO> Patients { get; set; }
        public DbSet<RoleDTO> Roles { get; set; }
        public DbSet<SpecialtyDTO> Specialties { get; set; }
        public DbSet<TimeSlotDTO> TimeSlots { get; set; }
        public DbSet<UserDTO> Users { get; set; }

        public ClinicDbContext() : base("data source=.\\SQLEXPRESS;initial catalog=HealthCareClinicDB;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework")
        {
            Database.SetInitializer(new ClinicDbContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppointmentDTO>().HasKey(a => new { a.Id });
            modelBuilder.Entity<DoctorDTO>().HasKey(d => new { d.Id });
            modelBuilder.Entity<DoctorScheduleDTO>().HasKey(ds => new { ds.Id });
            modelBuilder.Entity<PatientDTO>().HasKey(p => new { p.Id });
            modelBuilder.Entity<RoleDTO>().HasKey(r => new { r.Id });
            modelBuilder.Entity<SpecialtyDTO>().HasKey(s => new { s.Id });
            modelBuilder.Entity<TimeSlotDTO>().HasKey(ts => new { ts.Id });
            modelBuilder.Entity<UserDTO>().HasKey(u => new { u.Id });

            // Many-to-many relationships
            modelBuilder.Entity<UserDTO>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("UserId").MapRightKey("RoleId"));

            modelBuilder.Entity<DoctorDTO>()
                .HasMany(d => d.Specialties)
                .WithMany(s => s.Doctors)
                .Map(m => m.ToTable("DoctorSpecialties").MapLeftKey("DoctorId").MapRightKey("SpecialtyId"));

            // Foreign key relationships
            modelBuilder.Entity<DoctorScheduleDTO>()
                .HasRequired(ds => ds.Doctor)
                .WithMany(d => d.DoctorSchedules)
                .HasForeignKey(ds => ds.DoctorId);

            modelBuilder.Entity<AppointmentDTO>()
                .HasRequired(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<AppointmentDTO>()
                .HasRequired(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<AppointmentDTO>()
                .HasRequired(a => a.TimeSlot)
                .WithMany(ts => ts.Appointments)
                .HasForeignKey(a => a.TimeSlotId);
        }
    }


    internal class ClinicDbContextInitializer : DropCreateDatabaseIfModelChanges<ClinicDbContext>
    {
        protected override void Seed(ClinicDbContext context)
        {
            // This is sample data for testing purposes. In production, data will come from real users.

            // Roles
            RoleDTO adminRole = context.Roles.Add(new RoleDTO { Id = 1, RoleName = "Administrator", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            RoleDTO doctorRole = context.Roles.Add(new RoleDTO { Id = 2, RoleName = "Doctor", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            RoleDTO receptionistRole = context.Roles.Add(new RoleDTO { Id = 3, RoleName = "Receptionist", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // Users
            UserDTO adm_1 = context.Users.Add(new UserDTO { Id = 1, Username = "admin", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            adm_1.Roles.Add(adminRole);
            UserDTO dr_1 = context.Users.Add(new UserDTO { Id = 2, Username = "dr_who", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            dr_1.Roles.Add(doctorRole);
            UserDTO dr_2 = context.Users.Add(new UserDTO { Id = 3, Username = "dr_smith", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            dr_2.Roles.Add(doctorRole);
            UserDTO dr_3 = context.Users.Add(new UserDTO { Id = 4, Username = "dr_jones", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            dr_3.Roles.Add(doctorRole);
            UserDTO rec_1 = context.Users.Add(new UserDTO { Id = 5, Username = "receptionist1", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            rec_1.Roles.Add(receptionistRole);
            UserDTO rec_2 = context.Users.Add(new UserDTO { Id = 6, Username = "receptionist2", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            rec_2.Roles.Add(receptionistRole);

            // UserRoles
            // Since many-to-many, add via collections or save changes, but for simplicity, assume seeded after

            // Specialties
            SpecialtyDTO specGeneral = context.Specialties.Add(new SpecialtyDTO { Id = 1, Name = "General Practice" });
            SpecialtyDTO specCardiology = context.Specialties.Add(new SpecialtyDTO { Id = 2, Name = "Cardiology" });
            SpecialtyDTO specPediatrics = context.Specialties.Add(new SpecialtyDTO { Id = 3, Name = "Pediatrics" });

            // Doctors
            DoctorDTO doc_1 = context.Doctors.Add(new DoctorDTO { Id = 1, FirstName = "John", LastName = "Who", LicenseNumber = "LIC001234", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            doc_1.Specialties.Add(specGeneral);
            DoctorDTO doc_2 = context.Doctors.Add(new DoctorDTO { Id = 2, FirstName = "Sarah", LastName = "Smith", LicenseNumber = "LIC002345", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            doc_2.Specialties.Add(specCardiology);
            DoctorDTO doc_3 = context.Doctors.Add(new DoctorDTO { Id = 3, FirstName = "Michael", LastName = "Jones", LicenseNumber = "LIC003456", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            doc_3.Specialties.Add(specPediatrics);

            // DoctorSpecialties - handled by relationships

            // Patients
            context.Patients.Add(new PatientDTO { Id = 1, FirstName = "Emma", LastName = "Wilson", DateOfBirth = new DateTime(1985, 3, 15), InsuranceNumber = "WILE85031500 01", PhoneNumber = "555-0101", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new PatientDTO { Id = 2, FirstName = "James", LastName = "Brown", DateOfBirth = new DateTime(1990, 7, 22), InsuranceNumber = "BROJ90072200 02", PhoneNumber = "555-0102", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new PatientDTO { Id = 3, FirstName = "Olivia", LastName = "Davis", DateOfBirth = new DateTime(1978, 11, 30), InsuranceNumber = "DAVO78113000 03", PhoneNumber = "555-0103", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new PatientDTO { Id = 4, FirstName = "William", LastName = "Miller", DateOfBirth = new DateTime(2015, 5, 10), InsuranceNumber = "MILW15051000 04", PhoneNumber = "555-0104", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new PatientDTO { Id = 5, FirstName = "Sophia", LastName = "Garcia", DateOfBirth = new DateTime(1995, 9, 18), InsuranceNumber = "GARS95091800 05", PhoneNumber = "555-0105", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // DoctorSchedules
            // Dr. Who (Id=1, Monday-Friday 9AM-5PM)
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 1, DoctorId = 1, DayOfWeek = DaysOfWeekEnum.Monday, WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 2, DoctorId = 1, DayOfWeek = DaysOfWeekEnum.Tuesday, WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 3, DoctorId = 1, DayOfWeek = DaysOfWeekEnum.Wednesday, WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 4, DoctorId = 1, DayOfWeek = DaysOfWeekEnum.Thursday, WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 5, DoctorId = 1, DayOfWeek = DaysOfWeekEnum.Friday, WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            // Dr. Smith (Id=2, Monday-Thursday 8AM-4PM)
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 6, DoctorId = 2, DayOfWeek = DaysOfWeekEnum.Monday, WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 7, DoctorId = 2, DayOfWeek = DaysOfWeekEnum.Tuesday, WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 8, DoctorId = 2, DayOfWeek = DaysOfWeekEnum.Wednesday, WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 9, DoctorId = 2, DayOfWeek = DaysOfWeekEnum.Thursday, WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            // Dr. Jones (Id=3, Tuesday-Saturday 10AM-6PM)
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 10, DoctorId = 3, DayOfWeek = DaysOfWeekEnum.Tuesday, WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 11, DoctorId = 3, DayOfWeek = DaysOfWeekEnum.Wednesday, WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 12, DoctorId = 3, DayOfWeek = DaysOfWeekEnum.Thursday, WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 13, DoctorId = 3, DayOfWeek = DaysOfWeekEnum.Friday, WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorScheduleDTO { Id = 14, DoctorId = 3, DayOfWeek = DaysOfWeekEnum.Saturday, WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // TimeSlots (30-minute intervals from 8AM to 6PM)
            int slotId = 1;
            for (int hour = 8; hour < 18; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30)
                {
                    context.TimeSlots.Add(new TimeSlotDTO { Id = slotId++, HourOfDay = hour, MinuteOfHour = minute });
                }
            }

            // Appointments
            context.Appointments.Add(new AppointmentDTO { Id = 1, PatientId = 1, DoctorId = 1, Date = new DateTime(2025, 11, 25), TimeSlotId = 5, Notes = "Annual checkup", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new AppointmentDTO { Id = 2, PatientId = 2, DoctorId = 2, Date = new DateTime(2025, 11, 26), TimeSlotId = 13, Notes = "Heart consultation", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new AppointmentDTO { Id = 3, PatientId = 3, DoctorId = 1, Date = new DateTime(2025, 11, 22), TimeSlotId = 7, Notes = "Follow-up visit", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new AppointmentDTO { Id = 4, PatientId = 4, DoctorId = 3, Date = new DateTime(2025, 11, 27), TimeSlotId = 15, Notes = "Child vaccination", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new AppointmentDTO { Id = 5, PatientId = 5, DoctorId = 2, Date = new DateTime(2025, 11, 23), TimeSlotId = 3, Notes = "Cardiac screening", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new AppointmentDTO { Id = 6, PatientId = 1, DoctorId = 2, Date = new DateTime(2025, 12, 1), TimeSlotId = 6, Notes = "Blood pressure check", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
        }
    }
}
