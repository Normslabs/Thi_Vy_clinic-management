using System;
using System.Collections.Generic;

namespace ClinicManagement_proj.BLL.DTO
{
    public class UserDTO
    {
        public static int USERNAME_MAX_LENGTH = 32;
        public static int PASSWORD_MAX_LENGTH = 32;
        public static int PASSWORDHASH_MAX_LENGTH = 256;

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<RoleDTO> Roles { get; set; }

        public UserDTO()
        {
            Roles = new List<RoleDTO>();
        }

        public UserDTO(string username, string passwordHash, DateTime createdAt, DateTime modifiedAt, ICollection<RoleDTO> roles = null)
        {
            Username = username;
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Roles = roles ?? new List<RoleDTO>();
        }

        public UserDTO(int id, string username, string passwordHash, DateTime createdAt, DateTime modifiedAt, ICollection<RoleDTO> roles = null)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Roles = roles ?? new List<RoleDTO>();
        }

        public UserDTO(int id, string username, string passwordHash, DateTime createdAt)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            CreatedAt = createdAt;
            Roles = new List<RoleDTO>();
        }
    }
}
