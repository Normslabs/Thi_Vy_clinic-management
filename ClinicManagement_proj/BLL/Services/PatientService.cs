using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class PatientService
    {
        private ClinicDbContext clinicDb = new ClinicDbContext();

        public List<PatientDTO> GetAll()
        {
            // TODO: SUGGESTION
            // Added the eager-loading 'Include()' call for the patient's appointments
            return clinicDb.Patients
                .Include(pat => pat.Appointments)
                .ToList();
        }

        public PatientDTO GetPatientById(int id) 
        {
            // TODO: SUGGESTION
            // Added the eager-loading 'Include()' call for the patient's appointments
            return clinicDb.Patients
                .Include(pat => pat.Appointments)
                .FirstOrDefault(s => s.Id == id);
        }

        public PatientDTO AddPatient(PatientDTO dto)
        {
            // TODO: SUGGESTION
            // It can be a good idea to return the DTO after a DB action has been completed.
            // It allows to use the service method call directly as the parameter of some other function call.
            // I'll apply this in every class I review

            clinicDb.Patients.Add(dto);
            clinicDb.SaveChanges();
            return dto;
        }

        public PatientDTO UpdatePatient(PatientDTO patientDto)
        {
            // TODO: SUGGESTION
            // Technically, you shouldn't have to do this, in fact it might cause more problems in the long run.
            // If the PatientDTO instance received as argument was retrieved from the DB, then it is tracked by EF6
            // and you do not need to re-get it before saving the changes. Just calling SaveChanges() should be
            // sufficient.

            /*
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
            */

            // Update the last modified date
            patientDto.ModifiedAt = DateTime.Now;

            clinicDb.SaveChanges();
            return patientDto;
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

        // TODO: SUGGESTION
        // Added a 'delete-by-DTO' version of the delete (by id)
        public PatientDTO DeletePatient(PatientDTO patient) {
            clinicDb.Patients.Remove(patient);
            clinicDb.SaveChanges();
            return patient;
        }

        // TODO: SUGGESTION
        // Better 'search' function. Added a copy of the original search as GetPatientById(int id)
        public List<PatientDTO> Search(string criterion) {
            bool isIntCriterion = int.TryParse(criterion, out int intValue);
            return clinicDb.Patients.Where(
                    pat => string.Join(" ", pat.FirstName, pat.LastName).ToLower().StartsWith(criterion.ToLower())
                    || string.Join(", ", pat.LastName, pat.FirstName).ToLower().StartsWith(criterion.ToLower())
                    || pat.InsuranceNumber.ToLower().StartsWith(criterion.ToLower())
                    || (isIntCriterion && pat.Id == intValue)
                )
                .Include(pat => pat.Appointments)
                .ToList();

        }
        public PatientDTO Search(int id) {
            return clinicDb.Patients.FirstOrDefault(s => s.Id == id);

        }

        public bool Exists(int id)
        {
            return clinicDb.Patients.Any(s => s.Id == id);
        }

    }
}
