using System.Collections.Generic;
using api.template.Domain.Entities;

namespace api.template.Domain.Repository
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        //Veiculo ObterPor(string idProposta);
        Veiculo ObterPorPlaca(string placa);
        IEnumerable<Veiculo> ObterPorProposta(string idProposta);
    }
}
