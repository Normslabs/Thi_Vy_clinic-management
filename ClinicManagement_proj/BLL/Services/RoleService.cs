using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class RoleService
    {
        private readonly ClinicDbContext clinicDb = new ClinicDbContext();


        public List<RoleDTO> GetAllRoles()
        {
            return clinicDb.Roles
                .Include(r => r.Users)
                .ToList();
        }


        public RoleDTO GetRoleById(int id)
        {
            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.Id == id);

            if (role == null) return null;

            return new RoleDTO(role.Id, role.RoleName, role.CreatedAt, role.ModifiedAt, role.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList());
        }


        public RoleDTO GetRoleByName(string roleName)
        {
            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.RoleName == roleName);

            if (role == null) return null;

            return new RoleDTO(role.Id, role.RoleName, role.CreatedAt, role.ModifiedAt, role.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList());
        }


        public int CreateRole(RoleDTO roleDto)
        {
            var role = new RoleDTO(roleDto.RoleName, DateTime.UtcNow, DateTime.UtcNow);

            clinicDb.Roles.Add(role);
            clinicDb.SaveChanges();

            return role.Id;
        }


        public bool UpdateRole(RoleDTO roleDto)
        {
            var role = clinicDb.Roles.FirstOrDefault(r => r.Id == roleDto.Id);
            if (role == null) return false;

            role.RoleName = roleDto.RoleName;
            role.ModifiedAt = DateTime.UtcNow;

            clinicDb.SaveChanges();
            return true;
        }

        public List<RoleDTO> SearchRoles(string keyword)
        {
            var roles = clinicDb.Roles
                .Include(r => r.Users)
                .Where(r => r.RoleName.Contains(keyword)) // filter by partial match
                .ToList();
            return roles.Select(r => new RoleDTO(r.Id, r.RoleName, r.CreatedAt, r.ModifiedAt, r.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList())).ToList();
        }


        public bool DeleteRole(int id)
        {
            var role = clinicDb.Roles.Find(id);
            if (role == null) return false;

            clinicDb.Roles.Remove(role);
            clinicDb.SaveChanges();
            return true;
        }
    }
}