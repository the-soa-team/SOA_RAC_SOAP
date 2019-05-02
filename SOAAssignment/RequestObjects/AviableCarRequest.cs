using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class AviableCarRequest
    {
        public int CompanyId;
        public int LicenceAge;
        public int DriverAge;
        public DateTime DateBegin;
        public int NumDays;
    }
}