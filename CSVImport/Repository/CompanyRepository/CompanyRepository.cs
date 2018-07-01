using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Repository.CompanyRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        private static List<Company> companies = new List<Company>();
        public Company AddCompany(Company company)
        {
            companies.Add(company);

            return company;
        }

        public List<Company> GetAllCompanies()
        {
            return companies;
        }
    }
}
