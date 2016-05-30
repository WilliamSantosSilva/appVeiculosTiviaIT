using AppVeiculosAntigos.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppVeiculosAntigos.Api.Controllers
{
    [RoutePrefix("api/tipoveiculo")]
    public class TipoVeiculoController : ApiController
    {
        [HttpGet]
        [Route("listall")]
        public HttpResponseMessage Get()
        {            
            try
            {
                var result = Business.TipoVeiculo.Instance().Get(null);
                return ResponsePersonalize.CreateReponseSuccess(this.Request, result);                
            }
            catch (TryExceptionPersonalize ex)
            {
                return ex.TryExceptionHttp();
            }
        }

        [HttpGet]
        [Route("getbyid")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var result = Business.TipoVeiculo.Instance().GetById(id);
                return ResponsePersonalize.CreateReponseSuccess(this.Request, result);
            }
            catch (TryExceptionPersonalize ex)
            {
                return ex.TryExceptionHttp();
            }
        }
    }
}