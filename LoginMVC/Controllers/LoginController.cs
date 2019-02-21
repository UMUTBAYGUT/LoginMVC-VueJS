using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        public UserClass Index(string username, string password)
        {
            if (username == "umut")
            {
                if (password == "gulsum")
                {
                    var user2 = new UserClass()
                    {
                        IsLogin = true,
                        Name = "Umut",
                        Role = "admin"
                    };
                    return user2;
                }
            }

            var user = new UserClass()
            {
                IsLogin = false
            };
            return user;
        }

        [EnableCors]

        [HttpPost]
        public UserClass Login([FromBody]requestClass Arguments)
        {
            if (Arguments.username == "umut")
            {
                if (Arguments.password == "gulsum")
                {
                    var user2 = new UserClass()
                    {
                        IsLogin = true,
                        Name = "Umut",
                        Role = "admin"
                    };
                    return user2;
                }
            }

            var user = new UserClass()
            {
                IsLogin = false
            };
            return user;
        }
    }

    public class UserClass
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public bool IsLogin { get; set; }
    }

    public class requestClass
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}