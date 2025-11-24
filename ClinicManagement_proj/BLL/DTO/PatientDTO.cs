using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement_proj.BLL.DTO
{
    public class PatientDTO
    {
        public static int FIRSTNAME_MAX_LENGTH = 64;
        public static int LASTNAME_MAX_LENGTH = 64;
        public static int INSURANCE_MAX_LENGTH = 24;
        public static int PHONE_MAX_LENGTH = 20;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<AppointmentDTO> Appointments { get; set; }

        public PatientDTO()
        {
            Appointments = new List<AppointmentDTO>();
        }
    }
}
