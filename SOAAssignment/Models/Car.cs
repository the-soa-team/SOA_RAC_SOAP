using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.Models
{
    public class Car
    {
        public int ID { get; set; } // TODO: remove setter for this model when mock is no needed any more :)
        public int CompanyId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int LicenceAge { get; set; }
        public int DriverAge { get; set; }
        public double DailyMaxKm { get; set; }
        public double CurrentKm { get; set; }
        public AirgBagEnum HasAirBag { get; set; }
        public int LuggageVolume { get; set; } // litre
        public int NumSeats { get; set; }
        public decimal RentPrice { get; set; } // ₺
    }
}