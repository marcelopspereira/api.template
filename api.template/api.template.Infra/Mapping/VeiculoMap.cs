using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using api.template.Domain.Entities;

namespace api.template.Infra.Mapping
{
    public class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            ToTable("Veiculo");
            HasKey(x => x.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Placa)
                .IsRequired()
                .HasMaxLength(8);

            Property(x => x.Fabricante)
                .IsRequired()
                .HasMaxLength(20);

            Property(x => x.Marca)
            .IsRequired()
            .HasMaxLength(15);

            Property(x => x.Modelo)
            .IsRequired()
            .HasMaxLength(15);

            Property(x => x.Modalidade)
            .IsRequired()
            .HasMaxLength(1);
            //.HasColumnType("char")


            Property(x => x.AnoFab)
            .IsRequired()
            .HasMaxLength(4);

            Property(x => x.Chassi)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Renavan)
                .IsRequired()
                .HasMaxLength(20);

            Property(x => x.Lotacao)
                .IsRequired(); // 3

            Property(x => x.Regiao)
            .IsRequired()
            .HasMaxLength(2);

            Property(x => x.Uso)
            .IsRequired()
            .HasMaxLength(22);


            Property(x => x.PremioLiquido)
                .HasColumnType("money")
                .IsRequired();

            Property(x => x.PremioLiquidoCalculado)
                .HasColumnType("money")
                .IsRequired();


            //Property(x => x.CodSaf)
            //    .IsRequired()
            //    .HasMaxLength(1);

            //Property(x => x.VlSaf)
            //    .IsRequired();


            Property(x => x.CPFCondutor)
                .IsRequired()
                .HasMaxLength(11);
            Property(x => x.NomeCondutor)
                .IsRequired()
                .HasMaxLength(35);

            /*Na entidade Veiculo, a propriedade do tipo Proposta é obrigatória*/
            //1:N - 1 veiculo DEVE ter 1 proposta e 1 proposta pode ter muitos veiculos
            HasRequired(x => x.Proposta)
                .WithMany(x => x.Veiculos); //Proposta pode ter muitos Veiculos
            // .Map(m => m.MapKey("PropostaId"));//a chave estrangeira em Veiculo é PropostaId


            //HasOptional(a => a.City)
            //    .WithMany()
            //    .HasForeignKey(a => a.CityId)
            //    .WillCascadeOnDelete(false);


            //HasMany(x => x.ProfessorLista)
            //             .WithMany(x => x.CursoLista)
            //             .Map(m =>
            //             {
            //                 m.MapLeftKey("CursoId");
            //                 m.MapRightKey("ProfessorId");
            //                 m.ToTable("CursoProfessor");
            //             });
            //Property(x => x.Title)
            //    .HasMaxLength(60)
            //    .IsRequired();
            //sHasMany(x=>x.Proposta).WithMany(x=>x)
            //HasMany(x => x.Proposta).WithMany(x => x.).Map(x => x.ToTable("PropostaVeiculo"));
        }

    }
}
