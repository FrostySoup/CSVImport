using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace CSVImport.Controllers.API
{
    [RoutePrefix("api")]
    public class UploadController : ApiController
    {
        [Route("fileupload")]
        [HttpPost]
        [ResponseType(typeof(string))]
        public async Task<HttpResponseMessage> Post()
        {
            if (Request.Content.IsMimeMultipartContent())
            {
                var PATH = HttpContext.Current.Server.MapPath("~/content/csvfiles");

                var streamProvider = new CustomMultipartFormDataStreamProvider.CustomMultipartFormDataStreamProvider(PATH);
                var result = await Request.Content.ReadAsMultipartAsync(streamProvider);

                return Request.CreateResponse(HttpStatusCode.OK, "");
            }
            else
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotAcceptable, "This request is not properly formatted"));
            }
        }
    }
}