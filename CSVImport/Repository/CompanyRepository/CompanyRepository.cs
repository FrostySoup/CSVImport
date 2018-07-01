using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Repository.CompanyRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        private static List<Company> companies = new List<Company>();
        public Company AddCompany(Company company)
        {
            companies.Add(company);

            using (var db = new ImportContext())
            {
                db.Companies.Add(company);
                db.SaveChanges();
            }

            return company;
        }

        public List<Company> GetAllCompanies()
        {
            using (var db = new ImportContext())
            {
                return db.Companies.Where(x => x != null).ToList();
            }
        }
    }
}
