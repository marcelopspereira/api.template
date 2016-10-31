namespace api.template.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CraateDBApiName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apolice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Boleto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Proposta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proposta", t => t.Proposta_Id)
                .Index(t => t.Proposta_Id);
            
            CreateTable(
                "dbo.Proposta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF_CNPLJ = c.String(nullable: false, maxLength: 14, unicode: false),
                        Tipo = c.String(maxLength: 150, unicode: false),
                        Sucursal = c.Int(nullable: false),
                        TipoPessoa = c.String(nullable: false, maxLength: 1, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 35, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 30, unicode: false),
                        Complemento = c.String(nullable: false, maxLength: 30, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 20, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 20, unicode: false),
                        CEP = c.String(nullable: false, maxLength: 8, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, unicode: false),
                        DDD = c.String(nullable: false, maxLength: 3, unicode: false),
                        Fone = c.String(nullable: false, maxLength: 8, unicode: false),
                        Celular = c.String(nullable: false, maxLength: 12, unicode: false),
                        CodCorretor = c.String(nullable: false, maxLength: 6, unicode: false),
                        INDI_Corretor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DtIniVigencia = c.DateTime(nullable: false),
                        DtFinVigencia = c.DateTime(nullable: false),
                        NroParcelas = c.Int(nullable: false),
                        Dt1Parcela = c.DateTime(nullable: false),
                        VL_CS_MA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VL_CS_IPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VL_CS_DMH = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NroPredio = c.Int(nullable: false),
                        Perc_IOF = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Perc_ProLabore = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Perc_Agravo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VL_PR_LIQ_INF = c.Decimal(nullable: false, storeType: "money"),
                        VL_IOF_INF = c.Decimal(nullable: false, storeType: "money"),
                        VL_PR_TOT_INF = c.Decimal(nullable: false, storeType: "money"),
                        Faturamento = c.String(nullable: false, maxLength: 1, unicode: false),
                        QtdVeiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(nullable: false, maxLength: 6, unicode: false),
                        Fabricante = c.String(maxLength: 150, unicode: false),
                        Marca = c.String(nullable: false, maxLength: 15, unicode: false),
                        Modelo = c.String(nullable: false, maxLength: 15, unicode: false),
                        Modalidade = c.String(nullable: false, maxLength: 1, unicode: false),
                        AnoFab = c.String(nullable: false, maxLength: 4, unicode: false),
                        Chassi = c.String(nullable: false, maxLength: 30, unicode: false),
                        Renavan = c.String(nullable: false, maxLength: 30, unicode: false),
                        Lotacao = c.Int(nullable: false),
                        Regiao = c.String(nullable: false, maxLength: 2, unicode: false),
                        Uso = c.String(nullable: false, maxLength: 22, unicode: false),
                        PremioLiquido = c.Decimal(nullable: false, storeType: "money"),
                        PremioLiquidoCalculado = c.Decimal(nullable: false, storeType: "money"),
                        CodSaf = c.String(nullable: false, maxLength: 1, unicode: false),
                        VlSaf = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CPFCondutor = c.String(nullable: false, maxLength: 11, unicode: false),
                        NomeCondutor = c.String(nullable: false, maxLength: 35, unicode: false),
                        PropostaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Proposta", t => t.PropostaId)
                .Index(t => t.PropostaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculo", "PropostaId", "dbo.Proposta");
            DropForeignKey("dbo.Boleto", "Proposta_Id", "dbo.Proposta");
            DropIndex("dbo.Veiculo", new[] { "PropostaId" });
            DropIndex("dbo.Boleto", new[] { "Proposta_Id" });
            DropTable("dbo.Veiculo");
            DropTable("dbo.Proposta");
            DropTable("dbo.Boleto");
            DropTable("dbo.Apolice");
        }
    }
}
