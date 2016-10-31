using System;
using System.Collections.Generic;
using api.template.Domain.Entities;

namespace api.template.Domain.Services
{
    public interface IPropostaService : IDisposable
    {
        Proposta Adicionar(Proposta proposta);
        Proposta ObterPorId(int id);
        IEnumerable<Proposta> ObterTodos();
        Proposta ObterPorCpf(string cpf);
        Proposta ObterPorEmail(string email);
        IEnumerable<Proposta> ObterAtivos();
        Proposta Atualizar(Proposta cliente);
        void Remover(int id);
    }
}
