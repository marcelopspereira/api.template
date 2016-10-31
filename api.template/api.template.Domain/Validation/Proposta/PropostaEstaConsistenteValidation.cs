using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Specifications.Propostas;
using DomainValidation.Validation;

namespace api.template.Domain.Validation.Proposta
{
    public class PropostaEstaConsistenteValidation : Validator<Entities.Proposta>
    {
        public PropostaEstaConsistenteValidation()
        {
            var CPFCliente = new PropostaDeveTerCpfValidoSpecification();
            var clienteEmail = new PropostaDeveTerEmailValidoSpecification();
            var clienteMaioridade = new PropostaDeveSerMaiorDeIdadeSpecification();

            base.Add("CPFCliente", new Rule<Entities.Proposta>(CPFCliente, "Cliente informou um CPF inválido."));
            base.Add("clienteEmail",
                new Rule<Entities.Proposta>(clienteEmail, "Cliente informou um e-mail inválido."));
            base.Add("clienteMaioridade",
                new Rule<Entities.Proposta>(clienteMaioridade, "Cliente não tem maioridade para cadastro."));
        }
    }
}

