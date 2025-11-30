using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClinicManagement_proj.BLL.DTO
{
    public class UserDTO
    {
        public static int USERNAME_MAX_LENGTH = 32;
        public static int PASSWORD_MAX_LENGTH = 32;
        public static int PASSWORDHASH_MAX_LENGTH = 256;

        private string _username;
        private string _passwordHash;

        public int Id { get; set; }
        public string Username
        {
            get { return _username; }
            set { _username = ValidateUsername(value); }
        }
        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = ValidatePasswordHash(value); }
        }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<RoleDTO> Roles { get; set; }

        public UserDTO()
        {
            Roles = new List<RoleDTO>();
        }

        public static string ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be empty.");
            
            if (username.Length > USERNAME_MAX_LENGTH || username.Length < 3)
                throw new ArgumentException($"Username must be between 3 and {USERNAME_MAX_LENGTH} characters.");

            if (username.Contains(" "))
                throw new ArgumentException("Username cannot contain spaces.");

            if (!Regex.IsMatch(username, "^[a-zA-Z0-9_]+$"))
                throw new ArgumentException("Username can only contain alphanumeric characters and underscores.");

            return username;
        }

        public static string ValidatePasswordHash(string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("PasswordHash cannot be null or empty.");
            if (passwordHash.Length > PASSWORDHASH_MAX_LENGTH)
                throw new ArgumentException($"PasswordHash must be at most {PASSWORDHASH_MAX_LENGTH} characters.");
            return passwordHash;
        }

        public static string ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be empty.");
            if (password.Length > PASSWORD_MAX_LENGTH || password.Length < 8)
                throw new ArgumentException($"Password must be between 8 and {PASSWORD_MAX_LENGTH} characters.");
            if (!Regex.IsMatch(password, @"[A-Z]"))
                throw new ArgumentException("Password must contain at least one uppercase letter.");
            if (!Regex.IsMatch(password, @"[a-z]"))
                throw new ArgumentException("Password must contain at least one lowercase letter.");
            if (!Regex.IsMatch(password, @"[0-9]"))
                throw new ArgumentException("Password must contain at least one digit.");
            if (!Regex.IsMatch(password, @"[\W_]"))
                throw new ArgumentException("Password must contain at least one special character.");
            return password;
        }

        public UserDTO(string username, string passwordHash, ICollection<RoleDTO> roles = null)
        {
            Username = username;
            PasswordHash = passwordHash;
            Roles = roles ?? new List<RoleDTO>();
        }

        public UserDTO(int id, string username, string passwordHash, ICollection<RoleDTO> roles = null)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
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
