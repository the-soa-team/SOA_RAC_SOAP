using SOAAssignment.Enums;
using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class CompanyMock
    {

        public static List<Company> MultipleCompanies()
        {

            List<Company> Companys = new List<Company>();

            Company Company;

            Company = new Company
            {
                ID = 1,
                Name = "ABC Rent A Car",
                City = "İzmir",
                Address = "Alsancak, Konak",
                NumCars = 23,
                Score = 4
            };
            Companys.Add(Company);

            Company = new Company
            {
                ID = 2,
                Name = "ABC Rent A Car",
                City = "İzmir",
                Address = "Alsancak, Konak",
                NumCars = 23,
                Score = 4
            };
            Companys.Add(Company);

            return Companys;
        }

        public static Company SingleCompany()
        {
            return new Company
            {
                ID = 2,
                Name = "ABC Rent A Car",
                City = "İzmir",
                Address = "Alsancak, Konak",
                NumCars = 23,
                Score = 4
            }; ;
        }

    }
}