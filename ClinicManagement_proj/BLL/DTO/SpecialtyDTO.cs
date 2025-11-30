using System.Collections.Generic;
using System;

namespace ClinicManagement_proj.BLL.DTO
{
    public class SpecialtyDTO
    {
        public static int NAME_MAX_LENGTH = 64;

        private string _name;

        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = ValidateName(value); }
        }
        public ICollection<DoctorDTO> Doctors { get; set; }

        public SpecialtyDTO()
        {
            Doctors = new List<DoctorDTO>();
        }

        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            if (name.Length > NAME_MAX_LENGTH)
                throw new ArgumentException($"Name must be at most {NAME_MAX_LENGTH} characters.");
            return name;
        }

        public SpecialtyDTO(string name)
        {
            Name = name;
            Doctors = new List<DoctorDTO>();
        }
    }
}
