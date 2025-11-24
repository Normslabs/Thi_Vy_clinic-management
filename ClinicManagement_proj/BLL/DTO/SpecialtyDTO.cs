using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
