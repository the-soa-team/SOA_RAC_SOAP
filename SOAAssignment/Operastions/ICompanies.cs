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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICompanies" in both code and config file together.
    [ServiceContract]
    public interface ICompanies
    {
        [OperationContract]
        Company[] ListCompanies(CompanyRequest Request = null);

        [OperationContract]
        Company CreateCompany(Company Entyity);

        [OperationContract]
        Company GetCompany(int CompanydId);

        [OperationContract]
        Company UpdateCompany(Company Entyity);

        [OperationContract]
        Company DeleteCompany(int CompanydId);
    }
}
