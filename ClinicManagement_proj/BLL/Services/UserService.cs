using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    internal class UserService
    {
        private ClinicDbContext clinicDb = new ClinicDbContext();

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = clinicDb.Users.Include(u => u.Roles).Select(u => new UserDTO
            {
                Id = u.Id,
                Username = u.Username,
                Role = u.Roles.FirstOrDefault().RoleName
            }).ToList();
            return users;
        }
    }
}
