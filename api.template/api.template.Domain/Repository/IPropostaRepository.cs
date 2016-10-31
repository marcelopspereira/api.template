using System.Collections.Generic;
using api.template.Domain.Entities;

namespace api.template.Domain.Repository
{
    public interface IPropostaRepository : IRepository<Proposta>
    {
        Proposta ObterPorPoProposta(string idProposta);
        Proposta ObterPorNome(string nome);
        Proposta ObterPorCpf(string cpf);
        Proposta ObterPorEmail(string email);
        IEnumerable<Proposta> ObterPorProposta(string idProposta);
    }
}
