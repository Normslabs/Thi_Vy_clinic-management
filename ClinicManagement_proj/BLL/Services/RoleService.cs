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
        
        // TODO: SUGGESTION
        // Added RoleName constants to deal with getting the correct specific roles when
        // doing if a logged in used has a specific role. Necessary since Ids are DB-generated.
        private const string ADMIN_ROLE_NAME = "Administrator";
        private const string DOCTOR_ROLE_NAME = "Doctor";
        private const string RECEPTIONNIST_ROLE_NAME = "Receptionist";




        // TODO: SUGGESTION
        // Added a constructor for the service that needs to receive a ClinicDbContext from somewhere
        // instead of creating a new context in here in order to make sure that the same context is
        // shared across the app.
        private readonly ClinicDbContext clinicDb;

        public RoleService(ClinicDbContext context) {
            this.clinicDb = context;
        }



        // TODO: SUGGESTION
        // Simplified GetAllRoles method
        public List<RoleDTO> GetAllRoles() {
            return clinicDb.Roles.Include(r => r.Users).ToList();
        }
        //public List<RoleDTO> GetAllRoles()
        //{
        //    var roles = clinicDb.Roles.Include(r => r.Users).ToList();
        //    return roles.Select(r => new RoleDTO(r.Id, r.RoleName, r.CreatedAt, r.ModifiedAt, r.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList())).ToList();
        //}




        // TODO: SUGGESTION
        // Simplified GetRoleById method
        public RoleDTO GetRoleById(int id)
        {
            return clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.Id == id);

        }
        //public RoleDTO GetRoleById(int id) {
        //    var role = clinicDb.Roles
        //        .Include(r => r.Users)
        //        .FirstOrDefault(r => r.Id == id);

        //    if (role == null)
        //        return null;

        //    return new RoleDTO(role.Id, role.RoleName, role.CreatedAt, role.ModifiedAt, role.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList());
        //}



        // TODO: SUGGESTION
        // Simplified GetRoleByName method
        public RoleDTO GetRoleByName(string roleName)
        {
            return clinicDb.Roles
                .Include(r => r.Users)
                .FirstOrDefault(r => r.RoleName == roleName);

        }
        //public RoleDTO GetRoleByName(string roleName) {
        //    var role = clinicDb.Roles
        //        .Include(r => r.Users)
        //        .FirstOrDefault(r => r.RoleName == roleName);

        //    if (role == null)
        //        return null;

        //    return new RoleDTO(role.Id, role.RoleName, role.CreatedAt, role.ModifiedAt, role.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList());
        //}



        // TODO: SUGGESTION
        // Added methods to get specific roles based on their unique role names
        // And methods to check if a certain User has these roles assigned
        private RoleDTO GetAdminRole() {
            return clinicDb.Roles.Single(role => role.RoleName == ADMIN_ROLE_NAME);
        }
        private RoleDTO GetDoctorRole() {
            return clinicDb.Roles.Single(role => role.RoleName == DOCTOR_ROLE_NAME);
        }
        private RoleDTO GetReceptionistRole() {
            return clinicDb.Roles.Single(role => role.RoleName == RECEPTIONNIST_ROLE_NAME);
        }
        public bool IsUserAdmin(UserDTO user) {
            return user.Roles.Contains(this.GetAdminRole());
        }
        public bool IsUserDoctor(UserDTO user) {
            return user.Roles.Contains(this.GetDoctorRole());
        }
        public bool IsUserReceptionist(UserDTO user) {
            return user.Roles.Contains(this.GetReceptionistRole());
        }




        // TODO: SUGGESTION
        // Changed CreateRole method to not needlessly create a DTO copy and return
        // a DTO object instead of an Id
        public RoleDTO CreateRole(RoleDTO roleDto)
        {
            _ = clinicDb.Roles.Add(roleDto);
            _ = clinicDb.SaveChanges();
            return roleDto;
        }
        //public int CreateRole(RoleDTO roleDto) {
        //    var role = new RoleDTO(roleDto.RoleName, DateTime.UtcNow, DateTime.UtcNow);

        //    clinicDb.Roles.Add(role);
        //    clinicDb.SaveChanges();

        //    return role.Id;
        //}



        // TODO: SUGGESTION
        // Changed UpdateRole method to not needlessly create a DTO copy and return
        // a DTO object instead of an Id
        public RoleDTO UpdateRole(RoleDTO roleDto)
        {
            roleDto.ModifiedAt = DateTime.UtcNow;
            _ = clinicDb.SaveChanges();
            return roleDto;
        }
        //public bool UpdateRole(RoleDTO roleDto) {
        //    var role = clinicDb.Roles.FirstOrDefault(r => r.Id == roleDto.Id);
        //    if (role == null)
        //        return false;

        //    role.RoleName = roleDto.RoleName;
        //    role.ModifiedAt = DateTime.UtcNow;

        //    clinicDb.SaveChanges();
        //    return true;
        //}



        // TODO: SUGGESTION
        // Changed SearchRoles method to have better matching with StartsWith() instead of Contains()
        // and case-insensitiveness
        public List<RoleDTO> SearchRoles(string criterion)
        {
            return clinicDb.Roles
                .Include(r => r.Users)
                .Where(r => r.RoleName.ToLower().StartsWith(criterion.ToLower()))
                .ToList();
        }
        //public List<RoleDTO> SearchRoles(string criterion) {
        //    var roles = clinicDb.Roles
        //        .Include(r => r.Users)
        //        .Where(r => r.RoleName.Contains(criterion)) // filter by partial match
        //        .ToList();
        //    return roles.Select(r => new RoleDTO(r.Id, r.RoleName, r.CreatedAt, r.ModifiedAt, r.Users.Select(u => new UserDTO(u.Id, u.Username, u.PasswordHash, u.CreatedAt)).ToList())).ToList();
        //}



        // TODO: SUGGESTION
        // Simplified DeleteRole method AND Added a DTO-receiving overload.
        public RoleDTO DeleteRole(RoleDTO role)
        {
            _ = clinicDb.Roles.Remove(role);
            _ = clinicDb.SaveChanges();
            return role;
        }

        public bool DeleteRole(int id) {
            var role = clinicDb.Roles.Find(id);
            if (role == null)
                return false;

            clinicDb.Roles.Remove(role);
            clinicDb.SaveChanges();
            return true;
        }

    }
}