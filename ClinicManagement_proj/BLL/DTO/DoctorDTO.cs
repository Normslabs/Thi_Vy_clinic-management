using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class DoctorDTO
    {
        public static int FIRSTNAME_MAX_LENGTH = 64;
        public static int LASTNAME_MAX_LENGTH = 64;
        public static int LICENSE_MAX_LENGTH = 24;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<AppointmentDTO> Appointments { get; set; }
        public ICollection<DoctorScheduleDTO> DoctorSchedules { get; set; }
        public ICollection<SpecialtyDTO> Specialties { get; set; }

        public DoctorDTO()
        {
            Appointments = new List<AppointmentDTO>();
            DoctorSchedules = new List<DoctorScheduleDTO>();
            Specialties = new List<SpecialtyDTO>();
        }

        public DoctorDTO(string firstName, string lastName, string licenseNumber, DateTime createdAt, DateTime modifiedAt)
        {
            FirstName = firstName;
            LastName = lastName;
            LicenseNumber = licenseNumber;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Appointments = new List<AppointmentDTO>();
            DoctorSchedules = new List<DoctorScheduleDTO>();
            Specialties = new List<SpecialtyDTO>();
        }
    }
}
