using System;
using System.Collections.Generic;
using api.template.Domain.Entities;

namespace api.template.Domain.Services
{
    public interface IVeiculoService : IDisposable
    {
        Veiculo Adicionar(Veiculo cliente);
        Veiculo ObterPorId(int id);
        IEnumerable<Veiculo> ObterTodos();
        Veiculo ObterPorPlaca(string placa);
        //Veiculo ObterPorEmail(string email);
        //IEnumerable<Veiculo> ObterAtivos();
        Veiculo Atualizar(Veiculo cliente);
        void Remover(int id);
    }
}
