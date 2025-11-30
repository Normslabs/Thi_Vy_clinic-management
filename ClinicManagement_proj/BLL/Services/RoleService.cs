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
        private readonly ClinicDbContext clinicDb;


        public RoleService(ClinicDbContext dbContext)
        {
            clinicDb = dbContext;
        }

        private bool CurrentUserHasRole(UserService.UserRoles role)
        {
            if (ClinicManagementApp.CurrentUser == null) return false;
            return ClinicManagementApp.CurrentUser.Roles.Any(r => r.RoleName == role.ToString());
        }

        public List<RoleDTO> GetAllRoles()
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access roles.");

            return clinicDb.Roles
                .Include(r => r.Users)
                .ToList();
        }


        public RoleDTO GetRoleById(int id)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access role details.");

            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.Id == id);

            return role;
        }


        public RoleDTO GetRoleByName(string roleName)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access role details.");

            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.RoleName == roleName);

            return role;
        }


        public int CreateRole(RoleDTO roleDto)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can create roles.");

            var role = new RoleDTO(roleDto.RoleName, DateTime.Now, DateTime.Now);

            clinicDb.Roles.Add(role);
            clinicDb.SaveChanges();

            return role.Id;
        }


        public bool UpdateRole(RoleDTO roleDto)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can update roles.");

            var role = clinicDb.Roles.FirstOrDefault(r => r.Id == roleDto.Id);
            if (role == null) return false;

            role.RoleName = roleDto.RoleName;
            role.ModifiedAt = DateTime.Now;

            clinicDb.SaveChanges();
            return true;
        }

        public List<RoleDTO> SearchRoles(string keyword)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can search roles.");

            var roles = clinicDb.Roles
                .Include(r => r.Users)
                .Where(r => r.RoleName.Contains(keyword)) // filter by partial match
                .ToList();
            return roles.Select(r => new RoleDTO(r.Id, r.RoleName, r.CreatedAt, r.ModifiedAt, r.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList())).ToList();
        }


        public bool DeleteRole(int id)
        {
            if (!CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can delete roles.");

            var role = clinicDb.Roles.Find(id);
            if (role == null) return false;

            clinicDb.Roles.Remove(role);
            clinicDb.SaveChanges();
            return true;
        }
    }
}