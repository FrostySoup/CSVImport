using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Repository.CompanyRepository
{
    public interface ICompanyRepository
    {
        Company AddCompany(Company company);
        List<Company> GetAllCompanies();
    }
}
