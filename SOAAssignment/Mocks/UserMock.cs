using SOAAssignment.Enums;
using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class UserMock
    {

        public static List<User> MultipleUsers()
        {

            List<User> Users = new List<User>();

            User User;

            User = new User
            {
                ID = 1,
                FirstName = "Aydın",
                LastName = "Bulut",
                EmailAddress = "aydin.blt@gmail.com",
                Password = null,
                Role = RoleEnum.Employee,
                CompanyId = 1
            };
            Users.Add(User);

            User = new User
            {
                ID = 2,
                FirstName = "Aydın",
                LastName = "Bulut",
                EmailAddress = "aydin.blt@gmail.com",
                Password = null,
                Role = RoleEnum.Admin,
                CompanyId = 0
            };
            Users.Add(User);

            return Users;
        }

        public static User SingleUser()
        {
            return new User
            {
                ID = 1,
                FirstName = "Aydın",
                LastName = "Bulut",
                EmailAddress = "aydin.blt@gmail.com",
                Password = null,
                Role = RoleEnum.Employee,
                CompanyId = 1
            }; ;
        }

    }
}