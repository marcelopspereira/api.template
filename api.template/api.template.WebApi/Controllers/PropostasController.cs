using System.Collections.Generic;
using System.Web.Http;
using api.template.ApplicationService.Services;
using api.template.ApplicationService.ViewModels;

namespace api.template.WebApi.Controllers
{
    //[Route("api/propostas/")]
    public class PropostasController : ApiController
    {
        private readonly IPropostaApplicationService _propostaApplicationService;


        public PropostasController(IPropostaApplicationService propostaApplicationService)
        
        {
            _propostaApplicationService = propostaApplicationService;
        }


        [HttpGet]
        [Route("api/propostas")]
        public IEnumerable<PropostaViewModel> ObterTodos()
        
        
        {
            var query = _propostaApplicationService.ObterTodos();
            return query;
        }

        [Route("api/propostas/{id:int}")]
        // GET: api/Clientes/5
        public PropostaViewModel Get(int id)
        {
            return _propostaApplicationService.ObterPorId(id);
        }

        // POST: api/Clientes
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}
