using SOAAssignment.Mocks;
using SOAAssignment.Models;
using SOAAssignment.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAAssignment.Operastions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Transactions" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Transactions.svc or Transactions.svc.cs at the Solution Explorer and start debugging.
    public class Transactions : ITransactions
    {
        public Transaction[] ListTransactions(TransactionRequest Request = null)
        {
            return TransactionMock.MultipleTransactions().ToArray();
        }

        public Transaction CreateTransaction(Transaction Entity)
        {
            return Entity;
        }

        public Transaction DeleteTransaction(int TransactiondId)
        {
            return TransactionMock.SingleTransaction();
        }

        public Transaction GetTransaction(int TransactiondId)
        {
            return TransactionMock.SingleTransaction();
        }

        public Transaction UpdateTransaction(Transaction Entity)
        {
            return Entity;
        }
    }
}
