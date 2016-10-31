using System;
using System.Collections.Generic;
using api.template.Domain.Entities;
using api.template.Domain.Repository;

namespace api.template.Domain.Services
{
    public class PropostaService : IPropostaService
    {
        private readonly IPropostaRepository _propostaRepository;

        public PropostaService(IPropostaRepository propostaRepository)
        {
            _propostaRepository = propostaRepository;
        }

        
        public Proposta Adicionar(Proposta proposta)
        {
            //if (!proposta.IsValid())
                //return proposta;

            //proposta.ValidationResult = new ClienteAptoParaCadastroValidation(_propostaRepository).Validate(proposta);
            //if (!proposta.ValidationResult.IsValid)
            //return proposta;

            return _propostaRepository.Adicionar(proposta);
        }

        public Proposta ObterPorId(int id)
        {
            return _propostaRepository.ObterPorId(id);
        }

        public IEnumerable<Proposta> ObterTodos()
        {
            return _propostaRepository.ObterTodos();
        }

        public Proposta ObterPorCpf(string cpf)
        {
            return _propostaRepository.ObterPorCpf(cpf);
        }

        public Proposta ObterPorEmail(string email)
        {
            return _propostaRepository.ObterPorEmail(email);
        }

        public IEnumerable<Proposta> ObterAtivos()
        {
            //throw new NotImplementedException();
            return _propostaRepository.ObterTodos();
        }

        public IEnumerable<Proposta> ObterPorProposta(string idProposta)
        {
            return _propostaRepository.ObterPorProposta(idProposta);
        }

        public Proposta Atualizar(Proposta cliente)
        {
            return _propostaRepository.Atualizar(cliente);
        }

        public void Remover(int id)
        {
            _propostaRepository.Remover(id);
        }

        public void Dispose()
        {
            _propostaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
