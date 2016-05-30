using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AppVeiculosAntigos.Api.Utils
{
    public class ResponsePersonalize
    {
        public ResponsePersonalize()
        {
        }
        public static HttpResponseMessage CreateReponseSuccess(HttpRequestMessage _request,object model, object messages = null)
        {
            try
            {
                if (messages == null)
                {
                    messages = new object();
                }
                HttpResponseMessage request = _request.CreateResponse(System.Net.HttpStatusCode.OK, new { result = model, message = messages });

                return request;
            }
            catch(TryExceptionPersonalize ex)
            {
                return ex.TryExceptionHttp();
            }
        }
    }
}