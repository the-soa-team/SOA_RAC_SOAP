using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class CarRequest
    {
        public int LicenceAge = 0;
        public int DriverAge = 0;
        public int DailyMaxKm = 0;
        public int LagguageVolumeMin = 0;
        public AirgBagEnum HasAirBag = AirgBagEnum.NoMatter;
        public int RentPrice = 0;
        public int NumSeats = 0;
    }
}