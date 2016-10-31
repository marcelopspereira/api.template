using System;
using System.Collections.Generic;
using api.template.Domain.Entities;
using api.template.Domain.Repository;
using api.template.Domain.Services;
using api.template.Infra.UnitOfWork;

namespace api.template.ApplicationService.Services
{
    public class VeiculoApplicationService : ApplicationService, IVeiculoApplicationService
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoApplicationService(IVeiculoRepository repository, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _repository = repository;
        }

        public Veiculo Adicionar(Veiculo cliente)
        {
            throw new NotImplementedException();
        }

        public Veiculo ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Veiculo Atualizar(Veiculo cliente)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}