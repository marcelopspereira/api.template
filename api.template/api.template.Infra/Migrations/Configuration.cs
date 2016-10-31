using System;
using System.Collections.Generic;
using api.template.Domain.Entities;
using api.template.Infra.DataContexts;

namespace api.template.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDataContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AppDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Propostas.AddOrUpdate(
                new Proposta
                {
                    IdPropostaExt = "0001",
                    CodPN = "FC0001",
                    Bairro = "Bonsucesso",
                    CEP = "90620555",
                    CPF_CNPJ = "12345678901",
                    Celular = "51998689",
                    Cidade = "Porto Alegre",
                    CodCorretor = "AFCS12",
                    Complemento = "Apto 45",
                    DDD = "051",
                    Fone = "3356599",
                    Faturamento = "A",
                    Endereco = "Av. Prc. Isabel 44",
                    Nome = "sss",
                    NroParcelas = 5,
                    NroPredio = 546,
                    Sucursal = 1,
                    Dt1Parcela = new DateTime(2016, 6, 10),
                    DtIniVigencia = new DateTime(2016, 5, 1),
                    DtFinVigencia = new DateTime(2017, 5, 1),
                    INDI_Corretor = 99,
                    Perc_Agravo = 5,
                    Perc_IOF = 2,
                    Perc_ProLabore = 10,
                    QtdVeiculo = 1,
                    Tipo = "A",
                    TipoPessoa = "F",
                    UF = "RS",
                    VL_CS_DMH = 1,
                    VL_CS_IPA = 1,
                    VL_CS_MA = 2,
                    VL_IOF_INF = 0.15M,
                    VL_PR_LIQ_INF = 100,
                    VL_PR_TOT_INF = 100,

                    Veiculos = new List<Veiculo>
                    {
                        new Veiculo
                        {
                            AnoFab = "1989",
                            CPFCondutor = "00809104055",
                            NomeCondutor = "Teste Condutor",
                            Chassi = "1201212",
                            Fabricante = "Ford",
                            Marca = "Fista",
                            Modelo = "Hacth",
                            Lotacao = 5,
                            Modalidade = "C",
                            Placa = "1123abc",
                            Regiao = "SU",
                            Renavan = "1234566",
                            Uso = "D",
                            PremioLiquido = 2900.00M,
                            PremioLiquidoCalculado = 2900.00M
                            //VlSaf = 
                            //CodSaf = 

                        }
                    },
                }
                );
        }
    }
}
