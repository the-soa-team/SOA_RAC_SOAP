using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Models
{
    public class Company
    {
        public int ID { get; set; } // TODO: remove setter for this model when mock is no needed any more :)
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumCars { get; set; }
        public int Score { get; set; }
    }
}