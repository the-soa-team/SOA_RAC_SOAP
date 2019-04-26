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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Companies" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Companies.svc or Companies.svc.cs at the Solution Explorer and start debugging.
    public class Companies : ICompanies
    {
        public Company[] ListCompanies(CompanyRequest Request = null)
        {
            return CompanyMock.MultipleCompanies().ToArray();
        }

        public Company CreateCompany(Company Entity)
        {
            return Entity;
        }

        public Company DeleteCompany(int CompanydId)
        {
            return CompanyMock.SingleCompany();
        }

        public Company GetCompany(int CompanydId)
        {
            return CompanyMock.SingleCompany();
        }

        public Company UpdateCompany(Company Entity)
        {
            return Entity;
        }
    }
}
