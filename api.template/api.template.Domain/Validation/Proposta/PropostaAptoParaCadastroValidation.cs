using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Repository;
using api.template.Domain.Specifications.Propostas;
using DomainValidation.Validation;

namespace api.template.Domain.Validation.Proposta
{
    public class PropostaAptoParaCadastroValidation : Validator<Entities.Proposta>
    {
        public PropostaAptoParaCadastroValidation(IPropostaRepository propostaRepository)
        {
            var cpfDuplicado = new PropostasDevePossuirCPFUnicoSpecification(propostaRepository);
            //var emailDuplicado = new PropostaDevePossuirEmailUnicoSpecification(propostaRepository);

            base.Add("cpfDuplicado", new Rule<Entities.Proposta>(cpfDuplicado, "CPF já cadastrado! Esqueceu sua senha?"));
            //base.Add("emailDuplicado", new Rule<Entities.Proposta>(emailDuplicado, "E-mail já cadastrado! Esqueceu sua senha?"));
        }
    }
}
