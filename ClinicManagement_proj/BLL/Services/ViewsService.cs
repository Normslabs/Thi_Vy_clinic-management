using System;
using System.Collections.Generic;
using System.Linq;
using ClinicManagement_proj.DAL;

namespace ClinicManagement_proj.BLL.Services
{
    public class ViewsService
    {
        private readonly ClinicDbContext _context;

        public ViewsService(ClinicDbContext context)
        {
            _context = context;
        }

        public List<vw_PatientRecordsSummary> GetPatientRecordsSummary(int? patientId = null)
        {
            var query = _context.vw_PatientRecordsSummary.AsQueryable();
            if (patientId.HasValue)
            {
                query = query.Where(v => v.PatientId == patientId.Value);
            }
            return query.ToList();
        }

        public List<vw_UpcomingAppointments> GetUpcomingAppointments(int? doctorId = null)
        {
            var query = _context.vw_UpcomingAppointments.AsQueryable();
            if (doctorId.HasValue)
            {
                query = query.Where(v => v.DoctorId == doctorId.Value);
            }
            return query.ToList();
        }
    }
}
