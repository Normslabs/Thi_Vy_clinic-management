using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class SpecialtyDTO
    {
        public static int NAME_MAX_LENGTH = 64;
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DoctorDTO> Doctors { get; set; }

        public SpecialtyDTO()
        {
            Doctors = new List<DoctorDTO>();
        }

        public SpecialtyDTO(string name)
        {
            Name = name;
            Doctors = new List<DoctorDTO>();
        }
    }
}
