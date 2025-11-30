using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement_proj.BLL.DTO
{
    public class DoctorScheduleDTO
    {
        public static int DAYOFWEEK_MAX_LENGTH = 10;

        private string _dayOfWeek;

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string DayOfWeek
        {
            get { return _dayOfWeek; }
            set { _dayOfWeek = ValidateDayOfWeek(value); }
        }
        [NotMapped]
        public DaysOfWeekEnum DayOfWeekEnum
        {
            get { return (DaysOfWeekEnum)Enum.Parse(typeof(DaysOfWeekEnum), DayOfWeek); }
            set { DayOfWeek = value.ToString(); }
        }
        public TimeSpan WorkStartTime { get; set; }
        public TimeSpan WorkEndTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DoctorDTO Doctor { get; set; }

        public DoctorScheduleDTO()
        {
        }

        public static string ValidateDayOfWeek(string dayOfWeek)
        {
            if (string.IsNullOrWhiteSpace(dayOfWeek))
                throw new ArgumentException("DayOfWeek cannot be null or empty.");
            if (dayOfWeek.Length > DAYOFWEEK_MAX_LENGTH)
                throw new ArgumentException($"DayOfWeek must be at most {DAYOFWEEK_MAX_LENGTH} characters.");
            return dayOfWeek;
        }

        public DoctorScheduleDTO(int doctorId, DaysOfWeekEnum dayOfWeek, TimeSpan workStartTime, TimeSpan workEndTime, DateTime createdAt, DateTime modifiedAt)
        {
            DoctorId = doctorId;
            DayOfWeekEnum = dayOfWeek;
            WorkStartTime = workStartTime;
            WorkEndTime = workEndTime;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}
