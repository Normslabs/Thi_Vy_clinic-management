using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;

namespace ClinicManagement_proj.BLL.Services
{
    public class UserService
    {
        private ClinicDbContext clinicDb = new ClinicDbContext();

        public enum UserRoles
        {
            Administrator,
            Doctor,
            Receptionist
        }

        private static string HashPassword(string plainPassword)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(plainPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool ValidatePassword(string plainPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(plainPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        public List<UserDTO> GetAllUsers()
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access the list of all users.");

            return clinicDb.Users
                .Include(u => u.Roles).ToList();
        }
        public UserDTO GetUserById(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access user details.");

            var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == id);
            if (user == null) return null;

            return new UserDTO(user.Id, user.Username, user.PasswordHash, user.CreatedAt, user.ModifiedAt, user.Roles.ToList());
        }

        public UserDTO GetUserByUsername(string username)
        {
            var user = clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Username == username);

            if (user == null) return null;

            return new UserDTO(user.Id, user.Username, user.PasswordHash, user.CreatedAt, user.ModifiedAt, user.Roles.ToList());
        }


        public void CreateUser(string username, string password, List<RoleDTO> roles)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can create new users.");

            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required");
            if (username.Length > UserDTO.USERNAME_MAX_LENGTH)
                throw new ArgumentException($"Username must be {UserDTO.USERNAME_MAX_LENGTH} characters or less");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password is required");
            if (password.Length > UserDTO.PASSWORD_MAX_LENGTH)
                throw new ArgumentException($"Password must be {UserDTO.PASSWORD_MAX_LENGTH} characters or less");
            if (clinicDb.Users.Any(u => u.Username == username))
                throw new ArgumentException("Username already exists");

            string hash = HashPassword(password);
            var user = new UserDTO(username, hash, DateTime.UtcNow, DateTime.UtcNow, null); // Don't set roles yet

            clinicDb.Users.Add(user);

            // Load and attach roles
            if (roles != null && roles.Any())
            {
                var attachedRoles = roles.Select(r => clinicDb.Roles.Find(r.Id)).ToList();
                user.Roles = attachedRoles;
            }

            clinicDb.SaveChanges();
        }

        public void UpdateUser(int id, string username, string password, List<RoleDTO> roles)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can update users.");

            var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new ArgumentException("User not found");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required");
            if (username.Length > UserDTO.USERNAME_MAX_LENGTH)
                throw new ArgumentException($"Username must be {UserDTO.USERNAME_MAX_LENGTH} characters or less");
            if (username != user.Username && clinicDb.Users.Any(u => u.Username == username))
                throw new ArgumentException("Username already exists");
            if (password != null && password.Length > UserDTO.PASSWORD_MAX_LENGTH)
                throw new ArgumentException($"Password must be {UserDTO.PASSWORD_MAX_LENGTH} characters or less");

            user.Username = username;
            if (password != null)
            {
                user.PasswordHash = HashPassword(password);
            }

            user.Roles.Clear();
            if (roles != null && roles.Any())
            {
                // Load and attach roles
                var attachedRoles = roles.Select(r => clinicDb.Roles.Find(r.Id)).ToList();
                user.Roles = attachedRoles;
            }

            user.ModifiedAt = DateTime.UtcNow;

            clinicDb.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can delete users.");

            var user = clinicDb.Users.Find(id);
            if (user == null) return;

            clinicDb.Users.Remove(user);
            clinicDb.SaveChanges();
        }


        public UserDTO Search(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can search users.");

            UserDTO userToSearch = new UserDTO();

            //Check if the contact id exist
            userToSearch = clinicDb.Users.FirstOrDefault(u => u.Id == id);

            // return true if exist otherwise return false
            return userToSearch;
        }

        public static bool CurrentUserHasRole(UserRoles role)
        {
            if (CurrentUser.User == null) return false;
            return CurrentUser.User.Roles.Any(r => r.RoleName == role.ToString());
        }
    }
}
