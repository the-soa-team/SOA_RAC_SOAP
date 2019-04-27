using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class UserRequest
    {
        public int CompanyId;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        [DataMember]
        public string PhoneNumberRole;
    }
}