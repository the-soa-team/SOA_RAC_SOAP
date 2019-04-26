using SOAAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAAssignment.RequestObjects
{
    public class TransactionRequest
    {
        public DateTime DateBegin;
        public int NumDays;
        public int CurrentKm;
        public int ReturnKm;
        public int CustomerId;
        public int CarId;
        public bool Returned;
    }
}