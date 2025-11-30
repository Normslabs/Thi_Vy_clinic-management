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
            UserDTO.ValidatePassword(plainPassword);
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(plainPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool ComparePassword(string plainPassword, string storedHash)
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
                .Include(u => u.Roles)
                .ToList();
        }
        public UserDTO GetUserById(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can access user details.");

            var user = clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Id == id);

            return user;
        }

        public UserDTO GetUserByUsername(string username)
        {
            var user = clinicDb.Users
                .Where(u => u.Username == username)
                .Include(u => u.Roles)
                .SingleOrDefault() 
                ?? throw new ArgumentException("User not found");

            return user;
        }

        public void CreateUser(UserDTO user, string password)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can create new users.");

            if (clinicDb.Users.Any(u => u.Username == user.Username))
                throw new ArgumentException("Username already exists");

            user.PasswordHash = HashPassword(password);
            clinicDb.Users.Add(user);
            clinicDb.SaveChanges();
        }

        public UserDTO UpdateUser(UserDTO user, string password = null)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can update users.");

            if (!string.IsNullOrEmpty(password))
                user.PasswordHash = HashPassword(password);

            user.ModifiedAt = DateTime.Now;
            clinicDb.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can delete users.");

            var user = clinicDb.Users
                    .Where(u => u.Id == id)
                    .FirstOrDefault() 
                    ?? throw new ArgumentException("User not found");

            clinicDb.Users.Remove(user);
            clinicDb.SaveChanges();
        }

        public void DeleteUser(UserDTO user)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can delete users.");

            clinicDb.Users.Remove(user);
            clinicDb.SaveChanges();
        }


        public List<UserDTO> Search(int id)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can search users.");

            return clinicDb.Users
                .Where(u => u.Id.ToString().Contains(id.ToString()))
                .Include(u => u.Roles)
                .ToList();
        }

        public List<UserDTO> Search(string username)
        {
            if (!CurrentUserHasRole(UserRoles.Administrator))
                throw new UnauthorizedAccessException("Only Admin users can search users.");

            return clinicDb.Users
                .Where(u => u.Username.Contains(username))
                .Include(u => u.Roles)
                .ToList();
        }

        public static bool CurrentUserHasRole(UserRoles role)
        {
            if (CurrentUser.User == null) return false;
            return CurrentUser.User.Roles.Any(r => r.RoleName == role.ToString());
        }
    }
}
