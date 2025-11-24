using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement_proj.BLL.DTO
{
    public class TimeSlotDTO
    {
        public int Id { get; set; }
        public int HourOfDay { get; set; }
        public int MinuteOfHour { get; set; }
        public ICollection<AppointmentDTO> Appointments { get; set; }

        public TimeSlotDTO()
        {
            Appointments = new List<AppointmentDTO>();
        }
    }
}
