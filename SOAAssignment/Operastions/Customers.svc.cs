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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Customers" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Customers.svc or Customers.svc.cs at the Solution Explorer and start debugging.
    public class Customers : ICustomers
    {
        public Customer[] ListCustomers(CustomerRequest Request = null)
        {
            return CustomerMock.MultipleCustomers().ToArray();
        }

        public Customer CreateCustomer(Customer Entity)
        {
            return Entity;
        }

        public Customer DeleteCustomer(int CustomerdId)
        {
            return CustomerMock.SingleCustomer();
        }

        public Customer GetCustomer(int CustomerdId)
        {
            return CustomerMock.SingleCustomer();
        }

        public Customer UpdateCustomer(Customer Entity)
        {
            return Entity;
        }
    }
}
