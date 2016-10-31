using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace api.template.WebApi.Controllers
{
    [Route("api/propostas/")]
    public class PropostaController : ApiController
    {

        //[HttpGet]
        //[Authorize]
        //[AuthorizationHeaderHandler]
        //  [System.Web.Http.Route("api/propostas/{dtTransmissao:DateTime?}")]
        //[Route("api/propostas/date/{dtTransmissao:datetime:regex(\\d{4}-\\d{2}-\\d{2})}")]
        //[ResponseType(typeof(ResultStatus))]
        //public List<ResultStatus> Get(DateTime dtTransmissao)
        //public List<HttpRequestMessage> Get(DateTime dtTransmissao)
        //{}


        //[HttpGet]
        //[Route("api/propostas/{protocolo:long}")]
        //public async Task<IHttpActionResult> Get(long protocolo)
        //{
        //    using (var propDao = new PropostasDao())
        //    {
        //        var proposta = propDao.ConcultarProtocolo(protocolo);
        //        if (proposta == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(proposta);
        //    }
        //}


    }
}
