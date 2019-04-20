using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class CarRequest
    {
        public int LicenceAge;
        public int DriverAge;
        public int DailyMaxKm;
        public int LagguageVolumeMin;
        public AirgBagEnum HasAirBag;
        public int RentPrice;
        public int NumSeats;
    }
}