using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class PatientDTO
    {
        public static int FIRSTNAME_MAX_LENGTH = 64;
        public static int LASTNAME_MAX_LENGTH = 64;
        public static int INSURANCE_MAX_LENGTH = 24;
        public static int PHONE_MAX_LENGTH = 20;

        private string _firstName;
        private string _lastName;
        private string _insuranceNumber;
        private string _phoneNumber;

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
        public string InsuranceNumber
        {
            get { return _insuranceNumber; }
            set { _insuranceNumber = ValidateInsuranceNumber(value); }
        }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = ValidatePhoneNumber(value); }
        }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<AppointmentDTO> Appointments { get; set; }

        public PatientDTO()
        {
            Appointments = new List<AppointmentDTO>();
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

        public static string ValidateInsuranceNumber(string insuranceNumber)
        {
            if (string.IsNullOrWhiteSpace(insuranceNumber))
                throw new ArgumentException("InsuranceNumber cannot be null or empty.");
            if (insuranceNumber.Length > INSURANCE_MAX_LENGTH)
                throw new ArgumentException($"InsuranceNumber must be at most {INSURANCE_MAX_LENGTH} characters.");
            return insuranceNumber;
        }

        public static string ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("PhoneNumber cannot be null or empty.");
            if (phoneNumber.Length > PHONE_MAX_LENGTH)
                throw new ArgumentException($"PhoneNumber must be at most {PHONE_MAX_LENGTH} characters.");
            return phoneNumber;
        }

        public PatientDTO(string firstName, string lastName, string insuranceNumber, DateTime dateOfBirth, string phoneNumber, DateTime createdAt, DateTime modifiedAt)
        {
            FirstName = firstName;
            LastName = lastName;
            InsuranceNumber = insuranceNumber;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Appointments = new List<AppointmentDTO>();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (Phone: {PhoneNumber})";
        }
    }
}
