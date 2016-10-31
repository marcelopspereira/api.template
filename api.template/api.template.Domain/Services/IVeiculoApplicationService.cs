using System;
using System.Collections.Generic;
using api.template.Domain.Entities;

namespace api.template.Domain.Services
{
    public interface IVeiculoApplicationService : IDisposable
    {
        Veiculo Adicionar(Veiculo cliente);
        Veiculo ObterPorId(Guid id);
        IEnumerable<Veiculo> ObterTodos();
        //Veiculo ObterPorCpf(string cpf);
        //Veiculo ObterPorEmail(string email);
        //IEnumerable<Veiculo> ObterAtivos();
        Veiculo Atualizar(Veiculo cliente);
        void Remover(int id);
    }
}
