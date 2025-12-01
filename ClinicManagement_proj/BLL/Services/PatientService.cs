using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

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
        public PatientDTO AddPatient(PatientDTO dto)
        {           
            clinicDb.Patients.Add(dto);
            clinicDb.SaveChanges();
            return dto;
        }

        public PatientDTO UpdatePatient(PatientDTO patientDto)
        {           
            patientDto.ModifiedAt = DateTime.Now;

            clinicDb.SaveChanges();
            return patientDto;
        }

        //public void DeletePatient(int id)
        //{
        //    var patient = clinicDb.Patients.Find(id);
        //    if (patient != null)
        //    {
        //        clinicDb.Patients.Remove(patient);
        //        clinicDb.SaveChanges();

        //    }
        //}



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
