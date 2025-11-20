using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicManagement_proj.DAL
{
    internal class ClinicDbContext : DbContext
    {

        public ClinicDbContext() : base("name=HealthCareClinicDBEntities")
        {
        }
    }
}
