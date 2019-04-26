using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Models
{
    public class User
    {
        public int ID { get; set; } // TODO: remove setter for this model when mock is no needed any more :)
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
    }
}