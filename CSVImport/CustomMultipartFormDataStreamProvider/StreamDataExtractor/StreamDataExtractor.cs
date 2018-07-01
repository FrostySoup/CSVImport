using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMultipartFormDataStreamProvider.FileColumnsFormatter;
using Data;
using Repository.CompanyRepository;

namespace CustomMultipartFormDataStreamProvider.StreamDataExtractor
{
    public class StreamDataExtractor : IStreamDataExtractor
    {
        private readonly IFileColumnsFormatter _fileColumnsFormatter;
        private readonly ICompanyRepository _companyRepository;

        public StreamDataExtractor()
        {
            _fileColumnsFormatter = new FileColumnsFormatter.FileColumnsFormatter();
            _companyRepository = new CompanyRepository();
        }

        public List<Company> ExtractDataFromStream(Stream stream)
        {
            var columnsList = new List<int>();
            Dictionary<string, int> headers = null;

            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line?.Split(',');

                    if (values?.Length > 1)
                    {
                        headers = headers ?? _fileColumnsFormatter.ReadColumnIndexes(values, columnsList);

                        var company = _fileColumnsFormatter.FormCompany(values, columnsList);

                        _companyRepository.AddCompany(company);
                    }
                }
            }

            return _companyRepository.GetAllCompanies();
        }
    }
}
