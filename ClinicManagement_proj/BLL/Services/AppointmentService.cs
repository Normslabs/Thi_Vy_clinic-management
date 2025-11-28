using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class AppointmentService
    {

        // TODO: SUGGESTION
        // Added a constructor for the service that needs to receive a ClinicDbContext from somewhere
        // instead of creating a new context in here in order to make sure that the same context is
        // shared across the app.
        private readonly ClinicDbContext clinicDb;
        public AppointmentService(ClinicDbContext context) {
            this.clinicDb = context;
        }



        public int CreateAppointment(AppointmentDTO appointmentDTO)
        {
            var appointment = new AppointmentDTO
            {
                Date = appointmentDTO.Date,
                Notes = appointmentDTO.Notes,
                DoctorId = appointmentDTO.DoctorId,
                PatientId = appointmentDTO.PatientId,
                TimeSlotId = appointmentDTO.TimeSlotId,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };
            clinicDb.Appointments.Add(appointment);
            clinicDb.SaveChanges();
            return appointment.Id;
        }

        public bool UpdateAppointment(AppointmentDTO appointmentDTO)
        {
            var appointment = clinicDb.Appointments.FirstOrDefault(a => a.Id == appointmentDTO.Id);
            if (appointment == null) return false;

            appointment.Date = appointmentDTO.Date;
            appointment.Notes = appointmentDTO.Notes;
            appointment.DoctorId = appointmentDTO.DoctorId;
            appointment.PatientId = appointmentDTO.PatientId;
            appointment.TimeSlotId = appointmentDTO.TimeSlotId;
            appointment.ModifiedAt = DateTime.Now;
            clinicDb.SaveChanges();
            return true;
        }

        public bool DeleteAppointment(int id)
        {
            var appointment = clinicDb.Appointments.Find(id);
            if (appointment == null) return false;

            clinicDb.Appointments.Remove(appointment);
            clinicDb.SaveChanges();
            return true;
        }

        public AppointmentDTO GetAppointmentById(int id)
        {
            return clinicDb.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public List<AppointmentDTO> GetAllAppointments()
        {
            return clinicDb.Appointments.ToList();
        }
    }
}
