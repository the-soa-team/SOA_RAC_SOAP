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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomers" in both code and config file together.
    [ServiceContract]
    public interface ICustomers
    {
        [OperationContract]
        Customer[] ListCustomers(CustomerRequest Request = null);

        [OperationContract]
        Customer CreateCustomer(Customer Entyity);

        [OperationContract]
        Customer GetCustomer(int CustomerdId);

        [OperationContract]
        Customer UpdateCustomer(Customer Entyity);

        [OperationContract]
        Customer DeleteCustomer(int CustomerId);
    }
}
