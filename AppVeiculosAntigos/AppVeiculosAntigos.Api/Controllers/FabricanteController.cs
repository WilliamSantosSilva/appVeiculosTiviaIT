using AppVeiculosAntigos.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppVeiculosAntigos.Api.Controllers
{
    [RoutePrefix("api/fabricante")]
    public class FabricanteController : ApiController
    {
        [HttpGet]
        [Route("listall")]
        public HttpResponseMessage Get()
        {
            try
            {
                var result = Business.Fabricante.Instance().Get(null);
                return ResponsePersonalize.CreateReponseSuccess(this.Request, result);
            }
            catch (TryExceptionPersonalize ex)
            {
                return ex.TryExceptionHttp();
            }
        }

        [HttpGet]
        [Route("getbyid/{id}")]        
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