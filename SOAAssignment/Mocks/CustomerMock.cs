using SOAAssignment.Enums;
using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class CustomerMock
    {

        public static List<Customer> MultipleCustomers()
        {

            List<Customer> Customers = new List<Customer>();

            Customer Customer;

            Customer = new Customer
            {
                ID = 1,
                FirstName = "Aydın",
                LastName = "Bulut",
                EmailAddress = "aydin.blt@gmail.com",
                PhoneNumber = "05443598457",
                LicenceAge = 6,
                DriverAge = 27
            };
            Customers.Add(Customer);

            Customer = new Customer
            {
                ID = 2,
                FirstName = "Hulusi",
                LastName = "Önel",
                EmailAddress = "hulusi@gmail.com",
                PhoneNumber = "05554443322",
                LicenceAge = 3,
                DriverAge = 23
            };
            Customers.Add(Customer);

            return Customers;
        }

        public static Customer SingleCustomer()
        {
            return new Customer
            {
                ID = 1,
                FirstName = "Aydın",
                LastName = "Bulut",
                EmailAddress = "aydin.blt@gmail.com",
                PhoneNumber = "05443598457",
                LicenceAge = 6,
                DriverAge = 27
            }; ;
        }

    }
}