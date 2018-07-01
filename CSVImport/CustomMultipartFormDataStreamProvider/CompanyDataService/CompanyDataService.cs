using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMultipartFormDataStreamProvider.StreamDataExtractor;

namespace CustomMultipartFormDataStreamProvider.CompanyDataService
{
    public class CompanyDataService: ICompanyDataService
    {
        private readonly IStreamDataExtractor _streamDataExtractor;

        public CompanyDataService(IStreamDataExtractor streamDataExtractor)
        {
            _streamDataExtractor = streamDataExtractor;
        }

        public bool SaveCompanyData(Stream stream)
        {
            var test = _streamDataExtractor.ExtractDataFromStream(stream);

            return true;
        }
    }
}
