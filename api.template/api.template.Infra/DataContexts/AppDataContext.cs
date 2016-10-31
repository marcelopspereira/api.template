using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using api.template.Domain.Entities;
using api.template.Infra.Mapping;

namespace api.template.Infra.DataContexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppConnectionString")
        {
          //  Database.SetInitializer<AppDataContext>(new AppDataContextInitializer());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }


        public DbSet<Proposta> Propostas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Apolice> Apolices { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Aqui vamos remover a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /*Desabilitamos o delete em cascata em relacionamentos 1:N evitando
             ter registros filhos     sem registros pai*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            /*Toda propriedade do tipo string na entidade POCO
             seja configurado como VARCHAR no SQL Server*/
            modelBuilder.Properties<string>()
                      .Configure(p => p.HasColumnType("varchar"));

            /*Toda propriedade do tipo string na entidade POCO seja configurado como VARCHAR (150) no banco de dados */
            modelBuilder.Properties<string>()
                   .Configure(p => p.HasMaxLength(150));

            /*Definimos usando reflexão que toda propriedade que contenha
           "Nome da classe" + Id como "CursoId" por exemplo, seja dada como
           chave primária, caso não tenha sido especificado*/
            modelBuilder.Properties()
               .Where(p => p.Name == p.ReflectedType.Name + "Id")
               .Configure(p => p.IsKey());


            //modelBuilder.Properties<DateTime>()
            //    .Configure(c => c.HasColumnType("datetime2"));

            modelBuilder.Configurations.Add(new VeiculoMap());
            modelBuilder.Configurations.Add(new PropostaMap());
           
        }
    }

    //public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext>
    //{

    //}
}
