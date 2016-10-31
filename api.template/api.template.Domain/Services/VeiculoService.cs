using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Entities;
using api.template.Domain.Repository;

namespace api.template.Domain.Services
{


    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public Veiculo Adicionar(Veiculo veiculo)
        {
            //if (!Veiculo.IsValid())
            //    return Veiculo;

            //Veiculo.ValidationResult = new VeiculoAptoParaCadastroValidation(_veiculoRepository).Validate(Veiculo);
            //if (!Veiculo.ValidationResult.IsValid)
            //    return Veiculo;

            return _veiculoRepository.Adicionar(veiculo);
        }

        public Veiculo ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Veiculo ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> ObterTodos()
        {
            return _veiculoRepository.ObterTodos();
        }

        public Veiculo ObterPorPlaca(string placa)
        {
            throw new NotImplementedException();
        }

        public Veiculo Atualizar(Veiculo veiculo)
        {
            return _veiculoRepository.Atualizar(veiculo);
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _veiculoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
