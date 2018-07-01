using System.IO;

namespace CustomMultipartFormDataStreamProvider.CompanyDataService
{
    public interface ICompanyDataService
    {
        bool SaveCompanyData(Stream stream);
    }
}