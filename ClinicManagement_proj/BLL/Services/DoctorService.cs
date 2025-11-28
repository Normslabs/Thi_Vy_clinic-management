using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    internal class DoctorService
    {
        private readonly ClinicDbContext clinicDb = new ClinicDbContext();

        public int CreateDoctor(DoctorDTO doctorDto)
        {
            var doctor = new DoctorDTO
            {
                FirstName = doctorDto.FirstName,
                LastName = doctorDto.LastName,
                LicenseNumber = doctorDto.LicenseNumber,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow
            };
            clinicDb.Doctors.Add(doctor);
            clinicDb.SaveChanges();
            return doctor.Id;
        }

        public bool UpdateDoctor(DoctorDTO doctorDto)
        {
            var doctor = clinicDb.Doctors.FirstOrDefault(d => d.Id == doctorDto.Id);
            if (doctor == null) return false;

            doctor.FirstName = doctorDto.FirstName;
            doctor.LastName = doctorDto.LastName;
            doctor.LicenseNumber = doctorDto.LicenseNumber;
            doctor.ModifiedAt = DateTime.UtcNow;
            clinicDb.SaveChanges();
            return true;
        }

        public bool DeleteDoctor(int id)
        {
            var doctor = clinicDb.Doctors.Find(id);
            if (doctor == null) return false;

            clinicDb.Doctors.Remove(doctor);
            clinicDb.SaveChanges();
            return true;
        }

        public DoctorDTO GetDoctorById(int id)
        {
            return clinicDb.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public List<DoctorDTO> GetAllDoctors()
        {
            return clinicDb.Doctors.ToList();
        }
    }
}
