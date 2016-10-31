using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using api.template.Domain.Entities;
using api.template.Domain.Repository;
using api.template.Infra.DataContexts;

namespace api.template.Infra.Repository
{

    public class PropostaRepository : Repository<Proposta>, IPropostaRepository
    {
        public PropostaRepository(AppDataContext context) : base(context)
        {
        }

        public Proposta ObterPorPoProposta(string idProposta)
        {
            throw new NotImplementedException();
        }

        public Proposta ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Proposta ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Proposta ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proposta> ObterPorProposta(string idProposta)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proposta> ObterAtivos()
        {
            throw new NotImplementedException();
        }

        public  void Remover(int id)
        {
            var proposta = ObterPorId(id);
            //proposta.Ativo = false;
            Atualizar(proposta);
        }

        public override IEnumerable<Proposta> ObterTodos()
        {
            //throw new NotImplementedException();
            var query = Db.Propostas.ToList();
            return query;
            //var cn = Db.Database.Connection;
            //var sql = @"SELECT * FROM CLIENTES";

            //return cn.Query<Proposta>(sql);
        }

        public Proposta ObterPorId(int id)
        {
            throw new NotImplementedException();
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Clientes c " +
                       "LEFT JOIN Enderecos e " +
                       "ON c.ClienteId = e.ClienteId " +
                       "WHERE c.ClienteId = @sid";

            //var proposta = cn.Query<Proposta, Veiculo, Proposta>(sql,
            //    (c, e) =>
            //    {
            //        c.Veiculos.Add(e);
            //        return c;
            //    }, new { sid = id }, splitOn: "ProdutoId, VeiculosId");
            

            //return proposta.FirstOrDefault();
        }
    }
}
