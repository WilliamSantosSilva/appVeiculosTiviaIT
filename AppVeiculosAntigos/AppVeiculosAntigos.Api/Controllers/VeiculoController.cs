using AppVeiculosAntigos.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppVeiculosAntigos.Api.Controllers
{
    [RoutePrefix("api/veiculo")]
    public class VeiculoController : ApiController
    {
        [HttpGet]
        [Route("listall")]
        public HttpResponseMessage Get()
        {
            try
            {
                var result = Business.Veiculo.Instance().Get(null);
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
                var result = Business.Veiculo.Instance().GetById(id);
                return ResponsePersonalize.CreateReponseSuccess(this.Request, result);
            }
            catch (TryExceptionPersonalize ex)
            {
                return ex.TryExceptionHttp();
            }
        }

        [HttpPost]
        public void Post(DTO.Veiculo dto)
        {
            try
            {
                Business.Veiculo.Instance().Insert(dto);
            }
            catch (TryExceptionPersonalize ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public void Put(DTO.Veiculo dto)
        {
            try
            {
                Business.Veiculo.Instance().Update(dto);
            }
            catch (TryExceptionPersonalize ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public void Delete(DTO.Veiculo dto)
        {
            try
            {
                Business.Veiculo.Instance().Delete(dto);
            }
            catch (TryExceptionPersonalize ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
