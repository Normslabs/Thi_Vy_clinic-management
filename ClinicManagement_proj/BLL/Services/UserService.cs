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

        // TODO: SUGGESTION
        // Added a constructor for the service that needs to receive a ClinicDbContext from somewhere
        // instead of creating a new context in here in order to make sure that the same context is
        // shared across the app.
        // Here the constructor also receives an instance of RoleService in order to access
        // permission validation methods.
        private ClinicDbContext clinicDb;
        private RoleService roleService;


        // TODO: SUGGESTION
        // Added a property to hold the currently logged in user.
        public UserDTO LoggedInUser { get; private set; }


        public UserService(ClinicDbContext context, RoleService roleService) { 
            this.clinicDb = context;
            this.roleService = roleService;
        }


        // TODO: SUGGESTION
        // Created public methods to Log a user in and out.
        // Copied the LoginService.Authenticate method here and made it private.
        // Having a LoginService that relied on the UserService and a UserService that
        // relied on the LoginService for the logged in user was problematic
        // (cross-requirements).
        // Created methods to explicitely require a logged in user having a specific role.
        public UserDTO LogUserIn(string username, string password) {
            this.LoggedInUser = this.Authenticate(username, password);
            return this.LoggedInUser;
        }
        public void LogUserOut() {
            this.LoggedInUser = null;
        } 
        private UserDTO Authenticate(string username, string password) {
            var user = this.GetUserByUsername(username)
                ?? throw new Exception($"The user [{username}] does not exist.");
            if (!UserService.ValidatePassword(password, user.PasswordHash)) {
                throw new Exception($"Invalid password.");
            }
            return user;
        }
        public void RequiredLoggedInAdmin() {
            if (this.LoggedInUser == null) {
                throw new UnauthorizedAccessException("You must be logged in to use this feature.");
            }
            if (!this.roleService.IsUserAdmin(this.LoggedInUser)) {
                throw new UnauthorizedAccessException("You must be an administrator to use this feature.");
            }
        }
        public void RequiredLoggedInDoctor() {
            if (this.LoggedInUser == null) {
                throw new UnauthorizedAccessException("You must be logged in to use this feature.");
            }
            if (!this.roleService.IsUserDoctor(this.LoggedInUser)) {
                throw new UnauthorizedAccessException("You must be a doctor to use this feature.");
            }
        }
        public void RequiredLoggedInReceptionist() {
            if (this.LoggedInUser == null) {
                throw new UnauthorizedAccessException("You must be logged in to use this feature.");
            }
            if (!this.roleService.IsUserReceptionist(this.LoggedInUser)) {
                throw new UnauthorizedAccessException("You must be a receptionist to use this feature.");
            }
        }



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


        // TODO: SUGGESTION
        // Simplified GetAllUsers method and made it use the RoleService methods instead of local ones
        public List<UserDTO> GetAllUsers() {
            this.RequiredLoggedInAdmin();

            return clinicDb.Users.Include(u => u.Roles).ToList();
        }
        //public List<UserDTO> GetAllUsers()
        //{
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can access the list of all users.");

        //    return clinicDb.Users
        //        .Include(u => u.Roles).ToList();
        //}




        // TODO: SUGGESTION
        // Simplified GetUserById method and made it use the RoleService methods instead of local ones
        public UserDTO GetUserById(int id)
        {
            this.RequiredLoggedInAdmin();

            return clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Id == id);
        }
        //public UserDTO GetUserById(int id) {
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can access user details.");

        //    var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == id);
        //    if (user == null)
        //        return null;

        //    return new UserDTO(user.Id, user.Username, user.PasswordHash, user.CreatedAt, user.ModifiedAt, user.Roles.ToList());
        //}



        // TODO: SUGGESTION
        // Simplified GetUserByUsername method
        public UserDTO GetUserByUsername(string username)
        {
            return clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Username == username);

        }
        //public UserDTO GetUserByUsername(string username) {
        //    var user = clinicDb.Users
        //        .Include(u => u.Roles)
        //        .FirstOrDefault(u => u.Username == username);

        //    if (user == null)
        //        return null;

        //    return new UserDTO(user.Id, user.Username, user.PasswordHash, user.CreatedAt, user.ModifiedAt, user.Roles.ToList());
        //}




        // TODO: SUGGESTION
        // Simplified CreateUser method and made it use the RoleService methods instead of local ones
        // Also created a variant that uses a received UserDTO instance
        public void CreateUser(string username, string password, List<RoleDTO> roles) {
            this.RequiredLoggedInAdmin();

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

            // yes, you can set the roles right away IF you use the same context instance across services;
            // in that case the roles that were selected somewhere were already loaded in the context.
            var user = new UserDTO(username, HashPassword(password), roles);

            clinicDb.Users.Add(user);
            clinicDb.SaveChanges();
        }
        public UserDTO CreateUser(UserDTO user) {
            this.RequiredLoggedInAdmin();

            clinicDb.Users.Add(user);
            clinicDb.SaveChanges();
            return user;
        }
        //public void CreateUser(string username, string password, List<RoleDTO> roles)
        //{
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can create new users.");

        //    if (string.IsNullOrWhiteSpace(username))
        //        throw new ArgumentException("Username is required");
        //    if (username.Length > UserDTO.USERNAME_MAX_LENGTH)
        //        throw new ArgumentException($"Username must be {UserDTO.USERNAME_MAX_LENGTH} characters or less");
        //    if (string.IsNullOrWhiteSpace(password))
        //        throw new ArgumentException("Password is required");
        //    if (password.Length > UserDTO.PASSWORD_MAX_LENGTH)
        //        throw new ArgumentException($"Password must be {UserDTO.PASSWORD_MAX_LENGTH} characters or less");
        //    if (clinicDb.Users.Any(u => u.Username == username))
        //        throw new ArgumentException("Username already exists");

        //    string hash = HashPassword(password);
        //    var user = new UserDTO(username, hash, DateTime.UtcNow, DateTime.UtcNow, null); // Don't set roles yet

        //    clinicDb.Users.Add(user);

        //    // Load and attach roles
        //    if (roles != null && roles.Any())
        //    {
        //        var attachedRoles = roles.Select(r => clinicDb.Roles.Find(r.Id)).ToList();
        //        user.Roles = attachedRoles;
        //    }

        //    clinicDb.SaveChanges();
        //}



        // TODO: SUGGESTION
        // Simplified UpdateUser method
        // Also created a variant that uses a received UserDTO instance. the non-DTO one is
        // overly complex IMHO
        public void UpdateUser(int id, string username, string password, List<RoleDTO> roles)
        {
            this.RequiredLoggedInAdmin();

            var user = clinicDb.Users.Include(u => u.Roles).Single(u => u.Id == id);

            // TODO: SUGGESTION
            // The best place to have low-level validation like this is actually in the
            // DTO's properties, having non-default properties with the validation in the setters.
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required");
            if (username.Length > UserDTO.USERNAME_MAX_LENGTH)
                throw new ArgumentException($"Username must be {UserDTO.USERNAME_MAX_LENGTH} characters or less");
            if (username != user.Username && clinicDb.Users.Any(u => u.Username == username))
                throw new ArgumentException("Username already exists");
            if (password != null && password.Length > UserDTO.PASSWORD_MAX_LENGTH)
                throw new ArgumentException($"Password must be {UserDTO.PASSWORD_MAX_LENGTH} characters or less");
            if (username != user.Username && clinicDb.Users.Any(u => u.Username == username)) {
                // different username, needs uniqueness check
                throw new Exception("This username is already used.");
            }

            user.Username = username;
            if (password != null)
            {
                user.PasswordHash = HashPassword(password);
            }
            user.ModifiedAt = DateTime.UtcNow;
            user.Roles = roles;

            _ = clinicDb.SaveChanges();
        }
        public UserDTO UpdateUser(UserDTO user) {
            this.RequiredLoggedInAdmin();

            user.ModifiedAt = DateTime.UtcNow;
            _ = clinicDb.SaveChanges();
            return user;
        }
        //public void UpdateUser(int id, string username, string password, List<RoleDTO> roles) {
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can update users.");

        //    var user = clinicDb.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == id);
        //    if (user == null)
        //        throw new ArgumentException("User not found");
        //    if (string.IsNullOrWhiteSpace(username))
        //        throw new ArgumentException("Username is required");
        //    if (username.Length > UserDTO.USERNAME_MAX_LENGTH)
        //        throw new ArgumentException($"Username must be {UserDTO.USERNAME_MAX_LENGTH} characters or less");
        //    if (username != user.Username && clinicDb.Users.Any(u => u.Username == username))
        //        throw new ArgumentException("Username already exists");
        //    if (password != null && password.Length > UserDTO.PASSWORD_MAX_LENGTH)
        //        throw new ArgumentException($"Password must be {UserDTO.PASSWORD_MAX_LENGTH} characters or less");

        //    user.Username = username;
        //    if (password != null) {
        //        user.PasswordHash = HashPassword(password);
        //    }

        //    user.Roles.Clear();
        //    if (roles != null && roles.Any()) {
        //        // Load and attach roles
        //        var attachedRoles = roles.Select(r => clinicDb.Roles.Find(r.Id)).ToList();
        //        user.Roles = attachedRoles;
        //    }

        //    user.ModifiedAt = DateTime.UtcNow;

        //    clinicDb.SaveChanges();
        //}



        // TODO: SUGGESTION
        // Simplified DeleteUser method and made it use the RoleService methods instead of local ones
        // Also added a variant that works using DTO instances
        public void DeleteUser(int id)
        {
            this.RequiredLoggedInAdmin();

            var user = clinicDb.Users.Find(id);
            if (user == null) return;

            _ = clinicDb.Users.Remove(user);
            _ = clinicDb.SaveChanges();
        }
        public UserDTO DeleteUser(UserDTO user) {
            this.RequiredLoggedInAdmin();

            _ = clinicDb.Users.Remove(user);
            _ = clinicDb.SaveChanges();
            return user;
        }
        //public void DeleteUser(int id) {
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can delete users.");

        //    var user = clinicDb.Users.Find(id);
        //    if (user == null)
        //        return;

        //    clinicDb.Users.Remove(user);
        //    clinicDb.SaveChanges();
        //}



        // TODO: SUGGESTION
        // Made Search use the RoleService methods instead of local ones However, it is
        // functionally equivalent to GetById().
        public UserDTO Search(int id)
        {
            this.RequiredLoggedInAdmin();

            return clinicDb.Users
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.Id == id);
        }
        //public UserDTO Search(int id) {
        //    if (!CurrentUserHasRole(UserRoles.Administrator))
        //        throw new UnauthorizedAccessException("Only Admin users can search users.");

        //    UserDTO userToSearch = new UserDTO();

        //    //Check if the contact id exist
        //    userToSearch = clinicDb.Users.FirstOrDefault(u => u.Id == id);

        //    // return true if exist otherwise return false
        //    return userToSearch;
        //}



        public static bool CurrentUserHasRole(UserRoles role)
        {
            if (CurrentUser.User == null) return false;
            return CurrentUser.User.Roles.Any(r => r.RoleName == role.ToString());
        }


        // TODO: SUGGESTION
        // Added a SearchUsers that works with a string that matches ids or usernames

        /// <summary>
        /// Searches users based on a specified criterion.
        /// </summary>
        /// <remarks>
        /// The search is base both on the user's username and on its ID number:
        /// Users with a username that begins with the passed criterion string will match and be returned.
        /// Also, if the passed criterion string represents a numerical integer, the user with the equivalent
        /// ID number will also be returned.
        /// </remarks>
        /// <param name="criterion">A string criterion for the search.</param>
        /// <returns>A <see cref="List{T}"/> of users whose ID matches the criterion or whose username begins with the criterion.</returns>
        public List<UserDTO> SearchUsers(string criterion) {
            bool criterionIsInt = int.TryParse(criterion, out int intValue);
            return this.clinicDb.Users
                .Where(user => user.Username.ToLower().StartsWith(criterion.ToLower())
                || (criterionIsInt && user.Id == intValue))
                .Include(user => user.Roles)
                .ToList();
        }
    }
}
