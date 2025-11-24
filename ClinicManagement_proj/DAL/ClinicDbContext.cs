using System;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.DAL
{
    internal class ClinicDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSchedule> DoctorSchedules { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<User> Users { get; set; }

        public ClinicDbContext() : base("data source=.;initial catalog=HealthCareClinicDB;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework")
        {
            Database.SetInitializer(new ClinicDbContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>().HasKey(a => new { a.Id });
            modelBuilder.Entity<Doctor>().HasKey(d => new { d.Id });
            modelBuilder.Entity<DoctorSchedule>().HasKey(ds => new { ds.Id });
            modelBuilder.Entity<Patient>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Role>().HasKey(r => new { r.Id });
            modelBuilder.Entity<Specialty>().HasKey(s => new { s.Id });
            modelBuilder.Entity<TimeSlot>().HasKey(ts => new { ts.Id });
            modelBuilder.Entity<User>().HasKey(u => new { u.Id });

            // Many-to-many relationships
            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("UserId").MapRightKey("RoleId"));

            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Specialties)
                .WithMany(s => s.Doctors)
                .Map(m => m.ToTable("DoctorSpecialties").MapLeftKey("DoctorId").MapRightKey("SpecialtyId"));

            // Foreign key relationships
            modelBuilder.Entity<DoctorSchedule>()
                .HasRequired(ds => ds.Doctor)
                .WithMany(d => d.DoctorSchedules)
                .HasForeignKey(ds => ds.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasRequired(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasRequired(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Appointment>()
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
            context.Roles.Add(new Role { Id = 1, RoleName = "Administrator", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Roles.Add(new Role { Id = 2, RoleName = "Doctor", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Roles.Add(new Role { Id = 3, RoleName = "Receptionist", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // Users
            context.Users.Add(new User { Id = 1, Username = "admin", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Users.Add(new User { Id = 2, Username = "dr_who", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Users.Add(new User { Id = 3, Username = "dr_smith", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Users.Add(new User { Id = 4, Username = "dr_jones", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Users.Add(new User { Id = 5, Username = "receptionist1", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Users.Add(new User { Id = 6, Username = "receptionist2", PasswordHash = "dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // UserRoles
            // Since many-to-many, add via collections or save changes, but for simplicity, assume seeded after

            // Specialties
            context.Specialties.Add(new Specialty { Id = 1, Name = "General Practice" });
            context.Specialties.Add(new Specialty { Id = 2, Name = "Cardiology" });
            context.Specialties.Add(new Specialty { Id = 3, Name = "Pediatrics" });

            // Doctors
            context.Doctors.Add(new Doctor { Id = 1, FirstName = "John", LastName = "Who", LicenseNumber = "LIC001234", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Doctors.Add(new Doctor { Id = 2, FirstName = "Sarah", LastName = "Smith", LicenseNumber = "LIC002345", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Doctors.Add(new Doctor { Id = 3, FirstName = "Michael", LastName = "Jones", LicenseNumber = "LIC003456", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // DoctorSpecialties - handled by relationships

            // Patients
            context.Patients.Add(new Patient { Id = 1, FirstName = "Emma", LastName = "Wilson", DateOfBirth = new DateTime(1985, 3, 15), InsuranceNumber = "WILE85031500 01", PhoneNumber = "555-0101", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new Patient { Id = 2, FirstName = "James", LastName = "Brown", DateOfBirth = new DateTime(1990, 7, 22), InsuranceNumber = "BROJ90072200 02", PhoneNumber = "555-0102", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new Patient { Id = 3, FirstName = "Olivia", LastName = "Davis", DateOfBirth = new DateTime(1978, 11, 30), InsuranceNumber = "DAVO78113000 03", PhoneNumber = "555-0103", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new Patient { Id = 4, FirstName = "William", LastName = "Miller", DateOfBirth = new DateTime(2015, 5, 10), InsuranceNumber = "MILW15051000 04", PhoneNumber = "555-0104", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Patients.Add(new Patient { Id = 5, FirstName = "Sophia", LastName = "Garcia", DateOfBirth = new DateTime(1995, 9, 18), InsuranceNumber = "GARS95091800 05", PhoneNumber = "555-0105", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // DoctorSchedules
            // Dr. Who (Id=1, Monday-Friday 9AM-5PM)
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 1, DoctorId = 1, DayOfWeek = "MONDAY", WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 2, DoctorId = 1, DayOfWeek = "TUESDAY", WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 3, DoctorId = 1, DayOfWeek = "WEDNESDAY", WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 4, DoctorId = 1, DayOfWeek = "THURSDAY", WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 5, DoctorId = 1, DayOfWeek = "FRIDAY", WorkStartTime = new DateTime(2025, 1, 1, 9, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 17, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            // Dr. Smith (Id=2, Monday-Thursday 8AM-4PM)
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 6, DoctorId = 2, DayOfWeek = "MONDAY", WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 7, DoctorId = 2, DayOfWeek = "TUESDAY", WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 8, DoctorId = 2, DayOfWeek = "WEDNESDAY", WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 9, DoctorId = 2, DayOfWeek = "THURSDAY", WorkStartTime = new DateTime(2025, 1, 1, 8, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 16, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            // Dr. Jones (Id=3, Tuesday-Saturday 10AM-6PM)
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 10, DoctorId = 3, DayOfWeek = "TUESDAY", WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 11, DoctorId = 3, DayOfWeek = "WEDNESDAY", WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 12, DoctorId = 3, DayOfWeek = "THURSDAY", WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 13, DoctorId = 3, DayOfWeek = "FRIDAY", WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.DoctorSchedules.Add(new DoctorSchedule { Id = 14, DoctorId = 3, DayOfWeek = "SATURDAY", WorkStartTime = new DateTime(2025, 1, 1, 10, 0, 0), WorkEndTime = new DateTime(2025, 1, 1, 18, 0, 0), CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // TimeSlots (30-minute intervals from 8AM to 6PM)
            int slotId = 1;
            for (int hour = 8; hour < 18; hour++)
            {
                for (int minute = 0; minute < 60; minute += 30)
                {
                    context.TimeSlots.Add(new TimeSlot { Id = slotId++, HourOfDay = hour, MinuteOfHour = minute });
                }
            }

            // Appointments
            context.Appointments.Add(new Appointment { Id = 1, PatientId = 1, DoctorId = 1, Date = new DateTime(2025, 11, 25), TimeSlotId = 5, Notes = "Annual checkup", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new Appointment { Id = 2, PatientId = 2, DoctorId = 2, Date = new DateTime(2025, 11, 26), TimeSlotId = 13, Notes = "Heart consultation", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new Appointment { Id = 3, PatientId = 3, DoctorId = 1, Date = new DateTime(2025, 11, 22), TimeSlotId = 7, Notes = "Follow-up visit", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new Appointment { Id = 4, PatientId = 4, DoctorId = 3, Date = new DateTime(2025, 11, 27), TimeSlotId = 15, Notes = "Child vaccination", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new Appointment { Id = 5, PatientId = 5, DoctorId = 2, Date = new DateTime(2025, 11, 23), TimeSlotId = 3, Notes = "Cardiac screening", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });
            context.Appointments.Add(new Appointment { Id = 6, PatientId = 1, DoctorId = 2, Date = new DateTime(2025, 12, 1), TimeSlotId = 6, Notes = "Blood pressure check", CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now });

            // Set many-to-many relationships
            // UserRoles
            context.Users.Local.First(u => u.Id == 1).Roles.Add(context.Roles.Local.First(r => r.Id == 1)); // admin - Administrator
            context.Users.Local.First(u => u.Id == 2).Roles.Add(context.Roles.Local.First(r => r.Id == 2)); // dr_who - Doctor
            context.Users.Local.First(u => u.Id == 3).Roles.Add(context.Roles.Local.First(r => r.Id == 2)); // dr_smith - Doctor
            context.Users.Local.First(u => u.Id == 4).Roles.Add(context.Roles.Local.First(r => r.Id == 2)); // dr_jones - Doctor
            context.Users.Local.First(u => u.Id == 5).Roles.Add(context.Roles.Local.First(r => r.Id == 3)); // receptionist1 - Receptionist
            context.Users.Local.First(u => u.Id == 6).Roles.Add(context.Roles.Local.First(r => r.Id == 3)); // receptionist2 - Receptionist

            // DoctorSpecialties
            context.Doctors.Local.First(d => d.Id == 1).Specialties.Add(context.Specialties.Local.First(s => s.Id == 1)); // Dr. Who - General Practice
            context.Doctors.Local.First(d => d.Id == 2).Specialties.Add(context.Specialties.Local.First(s => s.Id == 2)); // Dr. Smith - Cardiology
            context.Doctors.Local.First(d => d.Id == 3).Specialties.Add(context.Specialties.Local.First(s => s.Id == 3)); // Dr. Jones - Pediatrics
        }
    }
}
