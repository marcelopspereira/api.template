using System;

namespace api.template.Domain.Entities
{
    public class Boleto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public long CodigoBarra { get; set; }
        public int NossoNro { get; set; }
        public DateTime DtEmissao { get; set; }
        //INFO Boleto
        public int NroParcela { get; set; }
        public DateTime DtVecto { get; set; }

        public decimal Vlr { get; set; }
        public decimal VlrIof { get; set; }
        public DateTime? DtPagto { get; set; }
        public decimal? VlrPago { get; set; }
        public virtual Proposta Proposta { get; set; }
    }
}
