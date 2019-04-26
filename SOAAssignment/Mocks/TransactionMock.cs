using SOAAssignment.Enums;
using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class TransactionMock
    {

        public static List<Transaction> MultipleTransactions()
        {

            List<Transaction> Transactions = new List<Transaction>();

            Transaction Transaction;

            Transaction = new Transaction
            {
                ID = 1,
                DateBegin = new DateTime(),
                NumDays = 3,
                CurrentKm = 26000,
                CustomerId = 1,
                CarId = 6,
                ReturnKm = 0,
                Returned = false
            };
            Transactions.Add(Transaction);

            Transaction = new Transaction
            {
                ID = 2,
                DateBegin = new DateTime(),
                NumDays = 5,
                CurrentKm = 34000,
                CustomerId = 2,
                CarId = 5,
                ReturnKm = 34600,
                Returned = true
            };
            Transactions.Add(Transaction);

            return Transactions;
        }

        public static Transaction SingleTransaction()
        {
            return new Transaction
            {
                ID = 1,
                DateBegin = new DateTime(),
                NumDays = 3,
                CurrentKm = 26000,
                CustomerId = 1,
                CarId = 6,
                ReturnKm = 0,
                Returned = false
            }; ;
        }

    }
}