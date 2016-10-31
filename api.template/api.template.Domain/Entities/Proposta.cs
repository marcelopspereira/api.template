using System;
using System.Collections.Generic;
using api.template.Domain.Validation.Proposta;
using DomainValidation.Validation;

namespace api.template.Domain.Entities
{
    public class Proposta
    {
        public Proposta()
        {
            Veiculos = new List<Veiculo>();
            Boletos = new List<Boleto>();
            DtEnvio = new DateTime();
        }
        public int Id { get; set; }
        public string CodPN { get; set; }
        public string IdPropostaExt { get; set; }

            // nro. CPF ou CNPJ do proponente
        public string CPF_CNPJ { get; set; }

        public string Tipo { get; set; }// AN - Apolice Nova
        public int Sucursal { get; set; }

        public string TipoPessoa { get; set; } // (F)isica ou (J)uridica
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string DDD { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public string CodCorretor { get; set; }
        public decimal INDI_Corretor { get; set; } // 998877 { 99% -> corretagem  88% -> Plataforma 77% ->Agravo }

        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFinVigencia { get; set; }

        public int NroParcelas { get; set; }
        public DateTime Dt1Parcela { get; set; }

        public decimal VL_CS_MA { get; set; }
        public decimal VL_CS_IPA { get; set; }
        public decimal VL_CS_DMH { get; set; }

        public int NroPredio { get; set; }
        public decimal Perc_IOF { get; set; }
        public decimal Perc_ProLabore { get; set; }
        public decimal Perc_Agravo { get; set; }

        public decimal VL_PR_LIQ_INF { get; set; }
        public decimal VL_IOF_INF { get; set; }
        public decimal VL_PR_TOT_INF { get; set; }
        public string Faturamento { get; set; } // (A)nual

        public int QtdVeiculo { get; set; }

        public DateTime DtEnvio { get; set; }
        public DateTime DtIntegracao { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Boleto> Boletos { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new PropostaEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
