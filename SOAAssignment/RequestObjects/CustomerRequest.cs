using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class CustomerRequest
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public string PhoneNumber;
        public int LicenceAge;
        public int DriverAge;
    }
}