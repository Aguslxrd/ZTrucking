using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalControllers
{
    public class LoginHandlerController
    {
        public static Dictionary<string, string> Login(string username, string password)
        {
            LoginRequestModel user = new LoginRequestModel();
            user.UserName = username;
            user.Password = password;
            return user.LoginRequest();
        }
    }
}
