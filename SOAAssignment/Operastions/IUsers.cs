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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsers" in both code and config file together.
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        User[] ListUsers(UserRequest Request = null);

        [OperationContract]
        User CreateUser(User Entyity);

        [OperationContract]
        User GetUser(int UserdId);

        [OperationContract]
        User UpdateUser(User Entyity);

        [OperationContract]
        User DeleteUser(int UserdId);
    }
}
