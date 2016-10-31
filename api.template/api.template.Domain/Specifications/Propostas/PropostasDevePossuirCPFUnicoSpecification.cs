using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Entities;
using api.template.Domain.Repository;
using DomainValidation.Interfaces.Specification;

namespace api.template.Domain.Specifications.Propostas
{
    public class PropostasDevePossuirCPFUnicoSpecification : ISpecification<Proposta>
    {
        private readonly IPropostaRepository _propostaRepository;

        public PropostasDevePossuirCPFUnicoSpecification(IPropostaRepository propostaRepository)
        {
            _propostaRepository = propostaRepository;
        }

        public bool IsSatisfiedBy(Proposta entity)
        {
            return _propostaRepository.ObterPorCpf(entity.CPF_CNPJ) == null;
        }
    }
}
