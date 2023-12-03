using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationAPI.Controllers
{
    public class UsersViews
    {
        public int CI { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}