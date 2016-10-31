using System;
using System.ComponentModel.DataAnnotations;

namespace api.template.ApplicationService.ViewModels
{
    public class PropostaVeiculoViewModel
    {

        public PropostaVeiculoViewModel()
        {
            DtEnvio = DateTime.Now;
            Tipo = "AN";
        }

        public int PropostaId { get; set; }


        //[Required(ErrorMessage = "Preencha o campo Placa")]
        //[RegularExpressionAttribute(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "Placa no formato inválido")]

        [Required(ErrorMessage = "Preencha o campo CodPN")]
        //[MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string CodPN { get; set; }

        [Required(ErrorMessage = "Preencha o campo CodPropostaExt")]
        //[MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string CodPropostaExt { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF_CNPJ")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string CPF_CNPJ { get; set; }// nro. CPF ou CNPJ do proponente


        [Required(ErrorMessage = "Preencha o campo Tipo do Documento")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        public string Tipo { get; set; }// AN - Apolice Nova


        [Required(ErrorMessage = "Preencha o campo Sucursal")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public int Sucursal { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo Pessoa")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        public string TipoPessoa { get; set; } // (F)isica ou (J)uridica

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(35, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereco")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo NroPredio")]
        [MaxLength(5, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int NroPredio { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Complemento")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade ")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha o campo UF")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Preencha o campo DDD")]
        [MaxLength(3, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fone")]
        [MaxLength(9, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Fone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Celular")]
        [MaxLength(12, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        //[MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CodCorretor")]
        [MaxLength(6, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(6, ErrorMessage = "Mínimo {0} caracteres")]
        public string CodCorretor { get; set; }

        [Required(ErrorMessage = "Preencha o campo INDI_Corretor")]
        [MaxLength(6, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(6, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal INDI_Corretor { get; set; } // 998877 { 99% -> corretagem  88% -> Plataforma 77% ->Agravo }

        [Required(ErrorMessage = "Preencha o campo DtIniVigencia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DtIniVigencia { get; set; }

        [Required(ErrorMessage = "Preencha o campo DtFinVigencia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DtFinVigencia { get; set; }

        [Required(ErrorMessage = "Preencha o campo NroParcelas")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public int NroParcelas { get; set; }

        [Required(ErrorMessage = "Preencha o campo Dt1Parcela")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Dt1Parcela { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_CS_MA")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_CS_MA { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_CS_IPA")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_CS_IPA { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_CS_DMH")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_CS_DMH { get; set; }

        [Required(ErrorMessage = "Preencha o campo Perc_IOF")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal Perc_IOF { get; set; }

        [Required(ErrorMessage = "Preencha o campo Perc_ProLabore")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal Perc_ProLabore { get; set; }

        [Required(ErrorMessage = "Preencha o campo Perc_Agravo")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal Perc_Agravo { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_PR_LIQ_INF")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_PR_LIQ_INF { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_IOF_INF")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_IOF_INF { get; set; }

        [Required(ErrorMessage = "Preencha o campo VL_PR_TOT_INF")]
        //[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal VL_PR_TOT_INF { get; set; }

        [Required(ErrorMessage = "Preencha o campo Faturamento")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Faturamento { get; set; } // (A)nual

        [Required(ErrorMessage = "Preencha o campo QtdVeiculo")]
        [MaxLength(6, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public int QtdVeiculo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DtEnvio { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DtIntegracao { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }

        /****** Veiculos *********/


        [Required(ErrorMessage = "Preencha o campo Placa")]
        [RegularExpressionAttribute(@"^[a-zA-Z]{3}\-\d{4}$", ErrorMessage = "Placa no formato inválido")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fabricante")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "Preencha o campo Marca")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Preencha o campo Modelo")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Modalidade  'O' -> Onibus 'C' -> Caminhão   'A' -> Automóvel ")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        public string Modalidade { get; set; }// "O" "C" "A"

        [Required(ErrorMessage = "Preencha o campo Ano Fabricação")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo {0} caracteres")]
        public string AnoFab { get; set; }

        [Required(ErrorMessage = "Preencha o campo Chassi")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(30, ErrorMessage = "Mínimo {0} caracteres")]
        public string Chassi { get; set; }

        [Required(ErrorMessage = "Preencha o campo Renavan")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Renavan { get; set; }

        [Required(ErrorMessage = "Preencha o campo Lotacao")]
        [MaxLength(3, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public int Lotacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Lotacao")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Regiao { get; set; }//"SU" "SE" "CO" "NE" "NO" "BR"

        [Required(ErrorMessage = "Preencha o campo Uso")]
        [MaxLength(22, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Uso { get; set; }

        [Required(ErrorMessage = "Preencha o campo Prêmio Líquido")]
        //[MaxLength(22, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal PremioLiquido { get; set; }//Prêmio veículo digitado


        public decimal PremioLiquidoCalculado { get; set; }//Prêmio veículo calculado

        //[Required(ErrorMessage = "Preencha o campo Uso")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        public string CodSaf { get; set; }
        public decimal VlSaf { get; set; }


        [Required(ErrorMessage = "Preencha o campo CPFCondutor")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string CPFCondutor { get; set; }

        [Required(ErrorMessage = "Preencha o campo NomeCondutor")]
        [MaxLength(35, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeCondutor { get; set; }

        ////////////////
        // {
        //  "PropostaId": 0,
        //  "CodPN": null,
        //  "CodPropostaExt": null,
        //  "CPF_CNPJ": null,
        //  "Tipo": "AN",
        //  "Sucursal": 0,
        //  "TipoPessoa": null,
        //  "Nome": null,
        //  "Endereco": null,
        //  "NroPredio": 0,
        //  "Complemento": null,
        //  "Cidade": null,
        //  "Bairro": null,
        //  "CEP": null,
        //  "UF": null,
        //  "DDD": null,
        //  "Fone": null,
        //  "Celular": null,
        //  "Email": null,
        //  "CodCorretor": null,
        //  "INDI_Corretor": 0.0,
        //  "DtIniVigencia": "0001-01-01T00:00:00",
        //  "DtFinVigencia": "0001-01-01T00:00:00",
        //  "NroParcelas": 0,
        //  "Dt1Parcela": "0001-01-01T00:00:00",
        //  "VL_CS_MA": 0.0,
        //  "VL_CS_IPA": 0.0,
        //  "VL_CS_DMH": 0.0,
        //  "Perc_IOF": 0.0,
        //  "Perc_ProLabore": 0.0,
        //  "Perc_Agravo": 0.0,
        //  "VL_PR_LIQ_INF": 0.0,
        //  "VL_IOF_INF": 0.0,
        //  "VL_PR_TOT_INF": 0.0,
        //  "Faturamento": null,
        //  "QtdVeiculo": 0,
        //  "Placa": null,
        //  "Fabricante": null,
        //  "Marca": null,
        //  "Modelo": null,
        //  "Modalidade": null,
        //  "AnoFab": null,
        //  "Chassi": null,
        //  "Renavan": null,
        //  "Lotacao": 0,
        //  "Regiao": null,
        //  "Uso": null,
        //  "PremioLiquido": 0.0,
        //  "PremioLiquidoCalculado": 0.0,
        //  "CodSaf": null,
        //  "VlSaf": 0.0,
        //  "CPFCondutor": null,
        //  "NomeCondutor": null
        // }


    }
}
