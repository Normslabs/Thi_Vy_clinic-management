using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class UserService
    {
        private ClinicDbContext clinicDb = new ClinicDbContext();

        public List<UserDTO> GetAllUsers()
        {
            return clinicDb.Users
                .Include(u => u.Roles).ToList();
        }
        public UserDTO GetUserById(int id)
        {
            var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == id);
            if (user == null) return null;

            return new UserDTO
            {
                Id = user.Id,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                CreatedAt = user.CreatedAt,
                Roles = user.Roles.ToList()
            };
        }

        public UserDTO GetUserByUsername(string username)
        {
            var user = clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Username == username);

            if (user == null) return null;

            return new UserDTO
            {
                Id = user.Id,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                CreatedAt = user.CreatedAt,
                Roles = user.Roles.ToList()
            };
        }


        public void CreateUser(UserDTO userDto)
        {
            var user = new UserDTO
            {
                Username = userDto.Username,
                PasswordHash = userDto.PasswordHash,
                CreatedAt = userDto.CreatedAt
            };

            // Map roles if provided
            if (userDto.Roles != null)
            {
                user.Roles = userDto.Roles.ToList();
            }

            clinicDb.Users.Add(user);
            clinicDb.SaveChanges();
        }

        public void UpdateUser(UserDTO userDto)
        {
            var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == userDto.Id);
            if (user == null) return;

            user.Username = userDto.Username;
            user.PasswordHash = userDto.PasswordHash;
            user.CreatedAt = userDto.CreatedAt;

            // Update roles
            user.Roles.Clear();
            if (userDto.Roles != null)
            {
                user.Roles = userDto.Roles.ToList();
            }

            clinicDb.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = clinicDb.Users.Find(id);
            if (user == null) return;

            clinicDb.Users.Remove(user);
            clinicDb.SaveChanges();
        }


    }
}
