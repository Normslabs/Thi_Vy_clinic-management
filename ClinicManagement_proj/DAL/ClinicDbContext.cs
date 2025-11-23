using System.Data.Entity;

namespace ClinicManagement_proj.DAL
{
    internal class ClinicDbContext : DbContext
    {

        public ClinicDbContext() : base("name=HealthCareClinicDBEntities")
        {
        }
    }
}
