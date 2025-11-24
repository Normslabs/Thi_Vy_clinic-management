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
                .Select(r => new RoleDTO
                {
                    Id = r.Id,
                    RoleName = r.RoleName,
                    CreatedAt = r.CreatedAt,
                    ModifiedAt = r.ModifiedAt,
                    Users = r.Users.Select(u => new UserDTO
                    {
                        Id = u.Id,
                        Username = u.Username,
                        PasswordHash = u.PasswordHash,
                        CreatedAt = u.CreatedAt
                    }).ToList()
                }).ToList();
        }

        
        public RoleDTO GetRoleById(int id)
        {
            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.Id == id);

            if (role == null) return null;

            return new RoleDTO
            {
                Id = role.Id,
                RoleName = role.RoleName,
                CreatedAt = role.CreatedAt,
                ModifiedAt = role.ModifiedAt,
                Users = role.Users.Select(u => new UserDTO
                {
                    Id = u.Id,
                    Username = u.Username,
                    PasswordHash = u.PasswordHash,
                    CreatedAt = u.CreatedAt
                }).ToList()
            };
        }

        
        public RoleDTO GetRoleByName(string roleName)
        {
            var role = clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.RoleName == roleName);

            if (role == null) return null;

            return new RoleDTO
            {
                Id = role.Id,
                RoleName = role.RoleName,
                CreatedAt = role.CreatedAt,
                ModifiedAt = role.ModifiedAt,
                Users = role.Users.Select(u => new UserDTO
                {
                    Id = u.Id,
                    Username = u.Username,
                    PasswordHash = u.PasswordHash,
                    CreatedAt = u.CreatedAt
                }).ToList()
            };
        }

        
        public int CreateRole(RoleDTO roleDto)
        {
            var role = new Role
            {
                RoleName = roleDto.RoleName,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow
            };

            clinicDb.Roles.Add(roleDto);
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
            return clinicDb.Roles
                .Include(r => r.Users)
                .Where(r => r.RoleName.Contains(keyword)) // filter by partial match
                .Select(r => new RoleDTO
                {
                    Id = r.Id,
                    RoleName = r.RoleName,
                    CreatedAt = r.CreatedAt,
                    ModifiedAt = r.ModifiedAt,
                    Users = r.Users.Select(u => new UserDTO
                    {
                        Id = u.Id,
                        Username = u.Username,
                        PasswordHash = u.PasswordHash,
                        CreatedAt = u.CreatedAt
                    }).ToList()
                })
                .ToList();
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