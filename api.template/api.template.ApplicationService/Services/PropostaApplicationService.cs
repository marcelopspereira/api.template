using System;
using System.Collections.Generic;
using api.template.ApplicationService.ViewModels;
using api.template.Domain.Entities;
using api.template.Domain.Services;
using api.template.Infra.UnitOfWork;
using AutoMapper;

namespace api.template.ApplicationService.Services
{
    public class PropsotaApplicationService : ApplicationService, IPropostaApplicationService
    {
        private readonly IPropostaService _propostaService;


        public PropsotaApplicationService(IPropostaService propostaService, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _propostaService = propostaService;
        }

        public PropostaVeiculoViewModel Adicionar(PropostaVeiculoViewModel propostaVeiculoViewModel)
        {
            var proposta = Mapper.Map<Proposta>(propostaVeiculoViewModel);
            var veiculo = Mapper.Map<Veiculo>(propostaVeiculoViewModel);

            proposta.Veiculos.Add(veiculo);
            // Unit Of Work

            var propostaReturn = _propostaService.Adicionar(proposta);

            // Verificar se o dominio não criticou nada!
            if (propostaReturn.ValidationResult.IsValid)
                Commit();

            return Mapper.Map<PropostaVeiculoViewModel>(propostaReturn);
        }

        public PropostaViewModel ObterPorId(int id)
        {
            return Mapper.Map<PropostaViewModel>(_propostaService.ObterPorId(id));
        }

        public IEnumerable<PropostaViewModel> ObterTodos()
        {
            var result = Mapper.Map<IEnumerable<PropostaViewModel>>(_propostaService.ObterAtivos());
            return result;
        }

        public PropostaViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<PropostaViewModel>(_propostaService.ObterPorCpf(cpf));
        }

        public PropostaViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<PropostaViewModel>(_propostaService.ObterPorEmail(email));
        }

        public PropostaViewModel Atualizar(PropostaViewModel propostaViewModel)
        {
            var cliente = Mapper.Map<Proposta>(propostaViewModel);
            _propostaService.Atualizar(cliente);

            return propostaViewModel;
        }

        public void Remover(int id)
        {
            _propostaService.Remover(id);
        }

        public void Dispose()
        {
            _propostaService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}