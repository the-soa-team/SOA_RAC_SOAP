using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class CompanyRequest
    {
        public string Name = "";
        public string City = "";
        public string Address = "";
        public int NumCars = 0;
        public int Score = 0;
    }
}