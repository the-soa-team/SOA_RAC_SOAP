using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Models
{
    public class Customer
    {
        public int ID { get; set; } // TODO: remove setter for this model when mock is no needed any more :)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int LicenceAge { get; set; }
        public int DriverAge { get; set; }
    }
}