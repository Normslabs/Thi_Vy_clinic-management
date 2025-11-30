using System;

namespace ClinicManagement_proj.BLL.DTO
{
    public class AppointmentDTO
    {
        public static int NOTES_MAX_LENGTH = 512;

        private string _notes;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Notes
        {
            get { return _notes; }
            set { _notes = ValidateNotes(value); }
        }

        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int TimeSlotId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public PatientDTO Patient { get; set; }
        public DoctorDTO Doctor { get; set; }
        public TimeSlotDTO TimeSlot { get; set; }

        public AppointmentDTO()
        {
        }

        public static string ValidateNotes(string notes)
        {
            if (notes != null && notes.Length > NOTES_MAX_LENGTH)
                throw new ArgumentException($"Notes must be at most {NOTES_MAX_LENGTH} characters.");
            return notes;
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
