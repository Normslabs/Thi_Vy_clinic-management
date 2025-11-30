using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class RoleDTO
    {
        public static int ROLENAME_MAXLENGTH = 64;

        private string _roleName;

        public int Id { get; set; }
        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = ValidateRoleName(value); }
        }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<UserDTO> Users { get; set; }

        public RoleDTO()
        {
            Users = new List<UserDTO>();
        }

        public static string ValidateRoleName(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new ArgumentException("RoleName cannot be null or empty.");
            if (roleName.Length > ROLENAME_MAXLENGTH)
                throw new ArgumentException($"RoleName must be at most {ROLENAME_MAXLENGTH} characters.");
            return roleName;
        }

        public RoleDTO(string roleName, DateTime createdAt, DateTime modifiedAt)
        {
            RoleName = roleName;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Users = new List<UserDTO>();
        }

        public RoleDTO(int id, string roleName, DateTime createdAt, DateTime modifiedAt, ICollection<UserDTO> users = null)
        {
            Id = id;
            RoleName = roleName;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Users = users ?? new List<UserDTO>();
        }
    }
}
