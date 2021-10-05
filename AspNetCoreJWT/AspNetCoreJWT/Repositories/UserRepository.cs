using System;
using AspNetCoreJWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, UserName = "batman", Password = "batman", Role = "manager" },
                new User { Id = 2, UserName = "robin", Password = "robin", Role = "employee" }
            };
            return users.FirstOrDefault(f => string.Equals(f.UserName, userName, StringComparison.CurrentCultureIgnoreCase) && f.Password == password);
        }
    }
}
