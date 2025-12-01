using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using static System.Data.Entity.DbFunctions;
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
            appointment.ModifiedAt = DateTime.Now;
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
                .Include("Doctor")
                .Include("Patient")
                .Include("TimeSlot")
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
                .Include("Doctor")
                .Include("Patient")
                .Include("TimeSlot")
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
                .Include("Doctor")
                .Include("Patient")
                .Include("TimeSlot")
                .Where(a => a.Date >= date.Date && a.Date < AddDays(date.Date, 1))
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
                .Include("Doctor")
                .Include("Patient")
                .Include("TimeSlot")
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
                .Include("Doctor")
                .Include("Patient")
                .Include("TimeSlot")
                .Where(a => a.PatientId == patient.Id)
                .ToList();
        }

        public List<TimeSlotDTO> GetAvailableTimeSlots(DateTime date)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                    (
                        UserService.UserRoles.Administrator,
                        UserService.UserRoles.Doctor,
                        UserService.UserRoles.Receptionist
                    )
               )
                throw new UnauthorizedAccessException("Only authorized users can create appointments.");
            var bookedSlotIds = clinicDb.Appointments
                                        .Where(a => a.Date >= date.Date && a.Date < AddDays(date.Date, 1))
                                        .Select(a => a.TimeSlotId)
                                        .ToList();
            var availableSlots = clinicDb.TimeSlots
                                        .Where(ts => !bookedSlotIds.Contains(ts.Id))
                                        .ToList();
            return availableSlots;
        }
    }
}
