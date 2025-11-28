using ClinicManagement_proj.BLL.DTO;
using System;

namespace ClinicManagement_proj.BLL.Services
{
    public class LoginService
    {
        private readonly UserService _userService;



        // TODO: SUGGESTION
        // Made the constructor actually receive the UserService instance instead of creating one on the spot.
        // With this system however, you get a cross-requirement between LoginService and UserService
        // So I copied/moved over the logic of LoginService into UserService
        // In the end this class should not be useful at all anymore.
        public LoginService(UserService userService)
        {
            this._userService = userService;
        }



        public UserDTO Authenticate(string username, string password)
        {

            // TODO: SUGGESTION
            // Added exception throws to specify bad username or bad password
            var user = _userService.GetUserByUsername(username) 
                ?? throw new Exception($"The user [{username}] does not exist.");
            if (!UserService.ValidatePassword(password, user.PasswordHash)) {
                throw new Exception($"Invalid password.");
            }
            return user;

            //var user = _userService.GetUserByUsername(username);
            //if (user != null && UserService.ValidatePassword(password, user.PasswordHash))
            //{
            //    return user;
            //}
            //return null;
        }
    }
}