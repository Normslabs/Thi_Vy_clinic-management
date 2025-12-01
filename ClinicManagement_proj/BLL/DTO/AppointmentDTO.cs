using System;

namespace ClinicManagement_proj.BLL.DTO
{ 
    // Use this as a base for the DTO
    //public partial class Appointment
    //{
        //public int Id { get; set; }
        //public System.DateTime Date { get; set; }
        //public string Notes { get; set; }
        //public int PatientId { get; set; }
        //public int DoctorId { get; set; }
        //public int TimeSlotId { get; set; }
        //public string Status { get; set; }
        //public System.DateTime CreatedAt { get; set; }
        //public System.DateTime ModifiedAt { get; set; }
    
        // public virtual Doctor Doctor { get; set; }
        //public virtual Patient Patient { get; set; }
        //public virtual TimeSlot TimeSlot { get; set; }
    // }

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

        public override string ToString()
        {
            return $"Appointment on {Date.ToShortDateString()} at {TimeSlot?.ToString() ?? "N/A"} with {Doctor?.ToString() ?? "Unknown Doctor"} for {Patient?.ToString() ?? "Unknown Patient"}";
        }
    }
}
