using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web;

namespace AppVeiculosAntigos.Api.Utils
{
    public class TryExceptionPersonalize : Exception
    {
        public TryExceptionPersonalize()
        {
        }
        public HttpResponseMessage TryExceptionHttp()
        {
            HttpResponseMessage request = new HttpResponseMessage();

            request.RequestMessage.CreateResponse(System.Net.HttpStatusCode.InternalServerError, new
            {
                result = "Houve um erro de execução"
            });

            return request;
        }
    }
}