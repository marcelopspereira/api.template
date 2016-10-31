using System;
using System.Collections.Generic;
using api.template.ApplicationService.ViewModels;

namespace api.template.ApplicationService.Services
{
    public interface IPropostaApplicationService : IDisposable
    {

        PropostaVeiculoViewModel Adicionar(PropostaVeiculoViewModel propostaVeiculoViewModel);
        PropostaViewModel ObterPorId(int id);
        IEnumerable<PropostaViewModel> ObterTodos();
        PropostaViewModel ObterPorCpf(string cpf);
        PropostaViewModel ObterPorEmail(string email);
        PropostaViewModel Atualizar(PropostaViewModel propostaViewModel);
        void Remover(int id);
        
    }
}