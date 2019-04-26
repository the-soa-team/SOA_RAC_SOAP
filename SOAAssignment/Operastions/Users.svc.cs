using SOAAssignment.Mocks;
using SOAAssignment.Models;
using SOAAssignment.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAAssignment.Operastions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Users" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Users.svc or Users.svc.cs at the Solution Explorer and start debugging.
    public class Users : IUsers
    {
        public User[] ListUsers(UserRequest Request = null)
        {
            return UserMock.MultipleUsers().ToArray();
        }

        public User CreateUser(User Entity)
        {
            return Entity;
        }

        public User DeleteUser(int UserdId)
        {
            return UserMock.SingleUser();
        }

        public User GetUser(int UserdId)
        {
            return UserMock.SingleUser();
        }

        public User UpdateUser(User Entity)
        {
            return Entity;
        }
    }
}
