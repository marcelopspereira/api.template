using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using api.template.Domain.Entities;

namespace api.template.Infra.Mapping
{
    public class PropostaMap : EntityTypeConfiguration<Proposta>
    {
        public PropostaMap()
        {
            ToTable("Proposta");
            HasKey(x => x.Id);
            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.CodPN);
            Property(a => a.IdPropostaExt);

            Property(x => x.CPF_CNPJ).IsRequired().HasMaxLength(14);
            Property(x => x.Sucursal).IsRequired();

            Property(x => x.TipoPessoa).IsRequired().HasMaxLength(1);
            Property(x => x.Nome).IsRequired().HasMaxLength(35);

            Property(x => x.Endereco).IsRequired().HasMaxLength(30);
            Property(x => x.Complemento).IsRequired().HasMaxLength(30);
            Property(x => x.Cidade).IsRequired().HasMaxLength(20);
            Property(x => x.Bairro).IsRequired().HasMaxLength(20);
            Property(x => x.CEP).IsRequired().HasMaxLength(8);
            Property(x => x.UF).IsRequired().HasMaxLength(2);
            Property(x => x.DDD).IsRequired().HasMaxLength(3);
            Property(x => x.Fone).IsRequired().HasMaxLength(8);
            Property(x => x.Celular).IsRequired().HasMaxLength(12);

            Property(x => x.DtIniVigencia).IsRequired();
            Property(x => x.DtFinVigencia).IsRequired();

            Property(x => x.CodCorretor).IsRequired().HasMaxLength(6);
            Property(x => x.INDI_Corretor).IsRequired();

            Property(x => x.NroParcelas).IsRequired();
            Property(x => x.Dt1Parcela).IsRequired();

            Property(x => x.VL_CS_MA).IsRequired();
            Property(x => x.VL_CS_IPA).IsRequired();
            Property(x => x.VL_CS_DMH).IsRequired();

            Property(x => x.NroPredio).IsRequired();

            Property(x => x.Perc_IOF).IsOptional();
            Property(x => x.Perc_ProLabore).IsRequired();
            Property(x => x.Perc_Agravo).IsRequired();
            Property(x => x.VL_PR_LIQ_INF).IsRequired().HasColumnType("money");
            Property(x => x.VL_IOF_INF).IsRequired().HasColumnType("money");
            Property(x => x.VL_PR_TOT_INF).IsRequired().HasColumnType("money");
            Property(x => x.Faturamento).IsRequired().HasMaxLength(1); //A = Anual
            Property(x => x.QtdVeiculo).IsRequired();

            Property(x => x.DtEnvio).IsRequired();
            Property(x => x.DtIntegracao).IsOptional();
            Ignore(x => x.ValidationResult);
            //Veiculos 
            //Boletos 


            //.IsRequired()
            //    .HasMaxLength(11)
            //    .IsFixedLength()
            //    .HasColumnAnnotation("Index", new IndexAnnotation(
            //        new IndexAttribute() {IsUnique = true}));



            ///*Na entidade Veiculo, a propriedade do tipo Proposta é obrigatória*/
            ////1:N - 1 veiculo DEVE ter 1 proposta e 1 proposta pode ter muitos veiculos
            //HasRequired(x => x.Proposta)
            //   .WithMany(x => x.Veiculos) //Proposta pode ter muitos Veiculos
            //   .Map(m => m.MapKey("PropostaId"));//a chave estrangeira em Veiculo é PropostaId


            //HasMany(x => x.ProfessorLista)
            //             .WithMany(x => x.CursoLista)
            //             .Map(m =>
            //             {
            //                 m.MapLeftKey("CursoId");
            //                 m.MapRightKey("ProfessorId");
            //                 m.ToTable("CursoProfessor");
            //             });

        }
    }
}
