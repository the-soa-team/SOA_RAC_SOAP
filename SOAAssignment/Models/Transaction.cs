using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Models
{
    public class Transaction
    {
        public int ID { get; set; } // TODO: remove setter for this model when mock is no needed any more :)
        public DateTime DateBegin { get; set; }
        public int NumDays { get; set; }
        public int CurrentKm { get; set; }
        public int ReturnKm { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public bool Returned { get; set; }
    }
}