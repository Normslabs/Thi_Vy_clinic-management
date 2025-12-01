using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class PatientService
    {
        private ClinicDbContext clinicDb;

        public PatientService(ClinicDbContext dbContext)
        {
            clinicDb = dbContext;
        }

        public List<PatientDTO> GetAll()
        {
            return clinicDb.Patients
                .Include(pat => pat.Appointments)
                .ToList();
        }

        public PatientDTO GetPatientById(int id)
        {
            return clinicDb.Patients
                .Include(pat => pat.Appointments)
                .FirstOrDefault(s => s.Id == id);
        }
        public void AddPatient(PatientDTO dto)
        {
            //var patient = new Patient
            //{
            //    Id = dto.Id,
            //    FirstName = dto.FirstName,
            //    LastName = dto.LastName,
            //    InsuranceNumber = dto.InsuranceNumber,
            //    DateOfBirth = dto.DateOfBirth,
            //    PhoneNumber = dto.PhoneNumber
            //};
            clinicDb.Patients.Add(dto);
            clinicDb.SaveChanges();
        }

        public void UpdatePatient(PatientDTO patientDto)
        {
            var patient = clinicDb.Patients.FirstOrDefault(p => p.Id == patientDto.Id);
            if (patient != null)
            {
                patient.FirstName = patientDto.FirstName;
                patient.LastName = patientDto.LastName;
                patient.InsuranceNumber = patientDto.InsuranceNumber;
                patient.DateOfBirth = patientDto.DateOfBirth;
                patient.PhoneNumber = patientDto.PhoneNumber;
                patient.ModifiedAt = DateTime.UtcNow;

                clinicDb.SaveChanges();
            }
        }

        public void DeletePatient(int id)
        {
            var patient = clinicDb.Patients.Find(id);
            if (patient != null)
            {
                clinicDb.Patients.Remove(patient);
                clinicDb.SaveChanges();

            }
        }

        public PatientDTO Search(int id)
        {
            return clinicDb.Patients.FirstOrDefault(s => s.Id == id);

        }

        public bool Exists(int id)
        {
            return clinicDb.Patients.Any(s => s.Id == id);
        }

    }
}
