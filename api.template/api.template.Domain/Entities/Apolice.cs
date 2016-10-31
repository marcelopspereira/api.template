namespace api.template.Domain.Entities
{
  public  class Apolice
    {
      public int Id { get; set; }
      public int PropostaId { get; set; }
      public virtual Proposta Proposta  { get; set; }
    }
}
