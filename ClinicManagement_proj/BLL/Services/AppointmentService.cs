using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class AppointmentService
    {
        private readonly ClinicDbContext clinicDb;

        public AppointmentService(ClinicDbContext dbContext)
        {
            clinicDb = dbContext;
        }

        public AppointmentDTO CreateAppointment(AppointmentDTO appointment)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");

            clinicDb.Appointments.Add(appointment);
            clinicDb.SaveChanges();
            return appointment;
        }

        public AppointmentDTO UpdateAppointment(AppointmentDTO appointment)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            clinicDb.SaveChanges();
            return appointment;
        }

        public void DeleteAppointment(AppointmentDTO appointment)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            clinicDb.Appointments.Remove(appointment);
            clinicDb.SaveChanges();
        }

        public List<AppointmentDTO> GetAllAppointments()
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            return clinicDb.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .ToList();
        }

        public List<AppointmentDTO> Search(int id)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            return clinicDb.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .Where(a => a.Id.ToString().Contains(id.ToString()))
                .ToList();
        }

        public List<AppointmentDTO> Search(DateTime date)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            return clinicDb.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .Where(a => DateTime.Compare(a.Date, date.Date) == 0)
                .ToList();
        }

        public List<AppointmentDTO> Search(DoctorDTO doctor)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");

            return clinicDb.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .Where(a => a.DoctorId == doctor.Id)
                .ToList();
        }

        public List<AppointmentDTO> Search(PatientDTO patient)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            return clinicDb.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.TimeSlot)
                .Where(a => a.PatientId == patient.Id)
                .ToList();
        }

        public TimeSlotDTO GetTimeSlotById(int id)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               ) 
                throw new UnauthorizedAccessException("Only authorized users can access timeslot details.");
            return clinicDb.TimeSlots.Find(id);
        }

        public List<TimeSlotDTO> GetAvailableTimeSlots(int doctorId, DateTime date)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            var results = clinicDb.Database.SqlQuery<sp_GetAvailableSlots_Result>("EXEC sp_GetAvailableSlots @p0, @p1", doctorId, date).ToList();
            return results.Select(r => GetTimeSlotById(r.TimeSlotId)).ToList();
        }
    }
}
