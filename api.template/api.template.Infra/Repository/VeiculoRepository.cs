using System;
using System.Collections.Generic;
using api.template.Domain.Entities;
using api.template.Domain.Repository;

namespace api.template.Infra.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {

        Veiculo IVeiculoRepository.ObterPorPlaca(string placa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> ObterPorProposta(string idProposta)
        {
            throw new NotImplementedException();
        }

        public Veiculo Adicionar(Veiculo obj)
        {
            throw new NotImplementedException();
        }

        public Veiculo ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Veiculo Atualizar(Veiculo obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> Buscar(System.Linq.Expressions.Expression<Func<Veiculo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
