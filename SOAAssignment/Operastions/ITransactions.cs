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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITransactions" in both code and config file together.
    [ServiceContract]
    public interface ITransactions
    {
        [OperationContract]
        Transaction[] ListTransactions(TransactionRequest Request = null);

        [OperationContract]
        Transaction CreateTransaction(Customer Customer, Car Car, DateTime DateBegin, int NumDays);

        [OperationContract]
        Transaction GetTransaction(int TransactiondId);

        [OperationContract]
        Transaction UpdateTransaction(Transaction Entyity);

        [OperationContract]
        Transaction DeleteTransaction(int TransactionId);
    }
}
