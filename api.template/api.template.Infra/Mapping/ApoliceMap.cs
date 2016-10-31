using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.template.Domain.Entities;

namespace api.template.Infra.Mapping
{
    public class ApoliceMap : EntityTypeConfiguration<Apolice>
    {
        public ApoliceMap()
        {
            ToTable("Apolice");
            HasKey(x => x.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            /*Na entidade Boleto, a propriedade do tipo Proposta é obrigatória*/
            //1:N - 1 Boleto pode ter 1 proposta e 1 proposta pode ter muitos Boletos
            //HasOptional(x => x.Proposta)
            //    .WithMany(x => x.Boletos)
            //    .HasForeignKey(a => a.ProdutoId); //Proposta pode ter muitos Boletos
            // .Map(m => m.MapKey("PropostaId"));//a chave estrangeira em Boleto é PropostaId


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
