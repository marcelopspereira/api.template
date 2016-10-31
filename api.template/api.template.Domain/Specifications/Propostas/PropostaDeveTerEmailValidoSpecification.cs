using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Entities;
using api.template.Domain.Validation.Documentos;
using DomainValidation.Interfaces.Specification;

namespace api.template.Domain.Specifications.Propostas
{
    public class PropostaDeveTerEmailValidoSpecification : ISpecification<Proposta>
    {
        public bool IsSatisfiedBy(Proposta proposta)
        {
            return EmailValidation.Validar(proposta.Email);
        }
    }
}
