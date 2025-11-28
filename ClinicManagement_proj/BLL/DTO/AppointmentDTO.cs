using System;

namespace ClinicManagement_proj.BLL.DTO
{
    public class AppointmentDTO
    {
        public static int NOTES_MAX_LENGTH = 512;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int TimeSlotId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public PatientDTO Patient { get; set; }
        public DoctorDTO Doctor { get; set; }
        public TimeSlotDTO TimeSlot { get; set; }

        public AppointmentDTO()
        {
        }

        public AppointmentDTO(DateTime date, string notes, int doctorId, int patientId, int timeSlotId, DateTime createdAt, DateTime modifiedAt)
        {
            Date = date;
            Notes = notes;
            DoctorId = doctorId;
            PatientId = patientId;
            TimeSlotId = timeSlotId;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}
