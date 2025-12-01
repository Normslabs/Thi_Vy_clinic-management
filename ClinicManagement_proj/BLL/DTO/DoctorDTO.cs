using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class DoctorDTO
    {
        public static int FIRSTNAME_MAX_LENGTH = 64;
        public static int LASTNAME_MAX_LENGTH = 64;
        public static int LICENSE_MAX_LENGTH = 24;

        private string _firstName;
        private string _lastName;
        private string _licenseNumber;

        public int Id { get; set; }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = ValidateFirstName(value); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = ValidateLastName(value); }
        }
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set { _licenseNumber = ValidateLicenseNumber(value); }
        }
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

        public static string ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("FirstName cannot be null or empty.");
            if (firstName.Length > FIRSTNAME_MAX_LENGTH)
                throw new ArgumentException($"FirstName must be at most {FIRSTNAME_MAX_LENGTH} characters.");
            return firstName;
        }

        public static string ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("LastName cannot be null or empty.");
            if (lastName.Length > LASTNAME_MAX_LENGTH)
                throw new ArgumentException($"LastName must be at most {LASTNAME_MAX_LENGTH} characters.");
            return lastName;
        }

        public static string ValidateLicenseNumber(string licenseNumber)
        {
            if (string.IsNullOrWhiteSpace(licenseNumber))
                throw new ArgumentException("LicenseNumber cannot be null or empty.");
            if (licenseNumber.Length > LICENSE_MAX_LENGTH)
                throw new ArgumentException($"LicenseNumber must be at most {LICENSE_MAX_LENGTH} characters.");
            return licenseNumber;
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

        public override string ToString()
        {
            return $"{FirstName} {LastName} (License: {LicenseNumber})";
        }
    }
}
