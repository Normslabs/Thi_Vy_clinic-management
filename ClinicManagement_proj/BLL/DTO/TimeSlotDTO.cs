using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class TimeSlotDTO
    {
        private int _hourOfDay;
        private int _minuteOfHour;

        public int Id { get; set; }
        public int HourOfDay
        {
            get { return _hourOfDay; }
            set { _hourOfDay = ValidateHourOfDay(value); }
        }
        public int MinuteOfHour
        {
            get { return _minuteOfHour; }
            set { _minuteOfHour = ValidateMinuteOfHour(value); }
        }
        public ICollection<AppointmentDTO> Appointments { get; set; }

        public TimeSlotDTO()
        {
            Appointments = new List<AppointmentDTO>();
        }

        public static int ValidateHourOfDay(int hourOfDay)
        {
            if (hourOfDay < 0 || hourOfDay > 23)
                throw new ArgumentException("HourOfDay must be between 0 and 23.");
            return hourOfDay;
        }

        public static int ValidateMinuteOfHour(int minuteOfHour)
        {
            if (minuteOfHour < 0 || minuteOfHour > 59)
                throw new ArgumentException("MinuteOfHour must be between 0 and 59.");
            return minuteOfHour;
        }

        public TimeSlotDTO(int hourOfDay, int minuteOfHour)
        {
            HourOfDay = hourOfDay;
            MinuteOfHour = minuteOfHour;
            Appointments = new List<AppointmentDTO>();
        }

        public override string ToString()
        {
            return $"{HourOfDay:D2}:{MinuteOfHour:D2}";
        }
    }
}
