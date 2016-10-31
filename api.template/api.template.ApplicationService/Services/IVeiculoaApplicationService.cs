using System;
using System.Collections.Generic;
using api.template.ApplicationService.ViewModels;

namespace api.template.ApplicationService.Services
{
    public interface IVeiculoaApplicationService : IDisposable
    {

        //PropostaVeiculoViewModel Adicionar(PropostaVeiculoViewModel propostaVeiculoViewModel);
        VeiculoViewModel ObterPorPlaca(int id);
        IEnumerable<VeiculoViewModel> ObterTodos();
        VeiculoViewModel ObterPorCpfCondutor(string cpf);
        VeiculoViewModel ObterPorNomeCondutor(string nome);
        VeiculoViewModel Atualizar(VeiculoViewModel veiculoViewModel);
        void Remover(int id);        
    }
}