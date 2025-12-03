using ClinicManagement_proj.BLL.DTO;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ClinicManagement_proj.DAL
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<AppointmentDTO> Appointments { get; set; }
        public DbSet<DoctorDTO> Doctors { get; set; }
        public DbSet<DoctorScheduleDTO> DoctorSchedules { get; set; }
        public DbSet<PatientDTO> Patients { get; set; }
        public DbSet<RoleDTO> Roles { get; set; }
        public DbSet<SpecialtyDTO> Specialties { get; set; }
        public DbSet<TimeSlotDTO> TimeSlots { get; set; }
        public DbSet<UserDTO> Users { get; set; }
        public virtual DbSet<vw_PatientRecordsSummary> vw_PatientRecordsSummary { get; set; }
        public virtual DbSet<vw_UpcomingAppointments> vw_UpcomingAppointments { get; set; }
        public ClinicDbContext() : base("data source=.\\SQLEXPRESS;initial catalog=HealthCareClinicDB_T2;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework")
        { }

        public override int SaveChanges()
        {
            foreach (DbEntityEntry<PatientDTO> entry in ChangeTracker.Entries<PatientDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            foreach (DbEntityEntry<AppointmentDTO> entry in ChangeTracker.Entries<AppointmentDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            foreach (DbEntityEntry<DoctorDTO> entry in ChangeTracker.Entries<DoctorDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            foreach (DbEntityEntry<DoctorScheduleDTO> entry in ChangeTracker.Entries<DoctorScheduleDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            foreach (DbEntityEntry<RoleDTO> entry in ChangeTracker.Entries<RoleDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            foreach (DbEntityEntry<UserDTO> entry in ChangeTracker.Entries<UserDTO>())
            {
                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // AppointmentDTO
            modelBuilder.Entity<AppointmentDTO>()
                .ToTable("Appointment")
                .HasKey(a => a.Id);
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.Id).HasColumnName("Id");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.Date).HasColumnName("Date").HasColumnType("date");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.Notes)
                .HasColumnType("varchar")
                .HasMaxLength(AppointmentDTO.NOTES_MAX_LENGTH)
                .HasColumnName("Notes");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.DoctorId).HasColumnName("DoctorId");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.PatientId).HasColumnName("PatientId");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.TimeSlotId).HasColumnName("TimeSlotId");
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<AppointmentDTO>()
                .Property(a => a.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

            // DoctorDTO
            modelBuilder.Entity<DoctorDTO>()
                .ToTable("Doctor")
                .HasKey(d => d.Id);
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.Id).HasColumnName("Id");
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(DoctorDTO.FIRSTNAME_MAX_LENGTH)
                .HasColumnName("FirstName");
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(DoctorDTO.LASTNAME_MAX_LENGTH)
                .HasColumnName("LastName");
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.LicenseNumber)
                .HasColumnType("varchar")
                .HasMaxLength(DoctorDTO.LICENSE_MAX_LENGTH)
                .HasColumnName("LicenseNumber");
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<DoctorDTO>()
                .Property(d => d.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

            // DoctorScheduleDTO
            modelBuilder.Entity<DoctorScheduleDTO>()
                .ToTable("DoctorSchedule")
                .HasKey(ds => ds.Id);
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.Id).HasColumnName("Id");
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.DoctorId).HasColumnName("DoctorId");
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.DayOfWeek)
                .HasColumnType("varchar")
                .HasMaxLength(DoctorScheduleDTO.DAYOFWEEK_MAX_LENGTH)
                .HasColumnName("DayOfWeek");
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.WorkStartTime).HasColumnName("WorkStartTime").HasColumnType("time");
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.WorkEndTime).HasColumnName("WorkEndTime").HasColumnType("time");
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<DoctorScheduleDTO>()
                .Property(ds => ds.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

            // PatientDTO
            modelBuilder.Entity<PatientDTO>()
                .ToTable("Patient")
                .HasKey(p => p.Id);
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(PatientDTO.FIRSTNAME_MAX_LENGTH)
                .HasColumnName("FirstName");
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(PatientDTO.LASTNAME_MAX_LENGTH)
                .HasColumnName("LastName");
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.InsuranceNumber)
                .HasColumnType("varchar")
                .HasMaxLength(PatientDTO.INSURANCE_MAX_LENGTH)
                .HasColumnName("InsuranceNumber");
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("datetime2").HasPrecision(7);
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(PatientDTO.PHONE_MAX_LENGTH)
                .HasColumnName("PhoneNumber");
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<PatientDTO>()
                .Property(p => p.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

            // RoleDTO
            modelBuilder.Entity<RoleDTO>()
                .ToTable("Roles")
                .HasKey(r => r.Id);
            modelBuilder.Entity<RoleDTO>()
                .Property(r => r.Id).HasColumnName("Id");
            modelBuilder.Entity<RoleDTO>()
                .Property(r => r.RoleName)
                .HasColumnType("varchar")
                .HasMaxLength(RoleDTO.ROLENAME_MAXLENGTH)
                .HasColumnName("RoleName");
            modelBuilder.Entity<RoleDTO>()
                .Property(r => r.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<RoleDTO>()
                .Property(r => r.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

            // SpecialtyDTO
            modelBuilder.Entity<SpecialtyDTO>()
                .ToTable("Specialties")
                .HasKey(s => s.Id);
            modelBuilder.Entity<SpecialtyDTO>()
                .Property(s => s.Id).HasColumnName("Id");
            modelBuilder.Entity<SpecialtyDTO>()
                .Property(s => s.Name)
                .HasColumnType("varchar")
                .HasMaxLength(SpecialtyDTO.NAME_MAX_LENGTH)
                .HasColumnName("Name");

            // TimeSlotDTO
            modelBuilder.Entity<TimeSlotDTO>()
                .ToTable("TimeSlots")
                .HasKey(ts => ts.Id);
            modelBuilder.Entity<TimeSlotDTO>()
                .Property(ts => ts.Id).HasColumnName("Id");
            modelBuilder.Entity<TimeSlotDTO>()
                .Property(ts => ts.HourOfDay).HasColumnName("HourOfDay");
            modelBuilder.Entity<TimeSlotDTO>()
                .Property(ts => ts.MinuteOfHour).HasColumnName("MinuteOfHour");

            // UserDTO
            modelBuilder.Entity<UserDTO>()
                .ToTable("Users")
                .HasKey(u => u.Id);
            modelBuilder.Entity<UserDTO>()
                .Property(u => u.Id).HasColumnName("Id");
            modelBuilder.Entity<UserDTO>()
                .Property(u => u.Username)
                .HasMaxLength(UserDTO.USERNAME_MAX_LENGTH)
                .HasColumnType("varchar")
                .HasColumnName("Username");
            modelBuilder.Entity<UserDTO>()
                .Property(u => u.PasswordHash)
                .HasMaxLength(UserDTO.PASSWORDHASH_MAX_LENGTH)
                .HasColumnType("varchar")
                .HasColumnName("PasswordHash");
            modelBuilder.Entity<UserDTO>()
                .Property(u => u.CreatedAt).HasColumnName("CreatedAt").HasColumnType("datetime2").HasPrecision(7).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            modelBuilder.Entity<UserDTO>()
                .Property(u => u.ModifiedAt).HasColumnName("ModifiedAt").HasColumnType("datetime2").HasPrecision(7);

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

            // View entities primary keys
            modelBuilder.Entity<vw_PatientRecordsSummary>()
                .ToTable("vw_PatientRecordsSummary")
                .HasKey(v => v.PatientId);

            modelBuilder.Entity<vw_UpcomingAppointments>()
                .ToTable("vw_UpcomingAppointments")
                .HasKey(v => v.AppointmentId);
        }
    }
}