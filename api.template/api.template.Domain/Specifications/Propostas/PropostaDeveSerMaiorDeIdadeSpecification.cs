using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Entities;
using DomainValidation.Interfaces.Specification;

namespace api.template.Domain.Specifications.Propostas
{
    public class PropostaDeveSerMaiorDeIdadeSpecification : ISpecification<Proposta>
    {
        public bool IsSatisfiedBy(Proposta cliente)
        {
            return true;
            //DateTime.Now.Year - cliente.DtIniVigencia.Year >= 21;
        }
    }
}
