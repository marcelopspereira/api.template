namespace api.template.Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        // "O" "C" "A"
        public string Modalidade { get; set; }
        public string AnoFab { get; set; }
        public string Chassi { get; set; }
        public string Renavan { get; set; }
        public int Lotacao { get; set; }
        //"SU" "SE" "CO" "NE" "NO" "BR"
        public string Regiao { get; set; }
        public string Uso { get; set; }
        //Prêmio veículo digitado
        public decimal PremioLiquido { get; set; }
        //Prêmio veículo calculado
        public decimal PremioLiquidoCalculado { get; set; }

        public string CodSaf { get; set; }
        public decimal VlSaf { get; set; }

        public string CPFCondutor { get; set; }
        public string NomeCondutor { get; set; }

        public int PropostaId { get; set; }
        public virtual Proposta Proposta { get; set; }
    }
}
