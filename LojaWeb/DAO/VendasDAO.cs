using LojaWeb.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class VendasDAO
    {
        private ISession session;

        public void Adiciona(Venda venda)
        {
            ITransaction transaction = this.session.BeginTransaction();
            this.session.Save(venda);
            transaction.Commit();
        }

        public IList<Venda> Lista()
        {
            return new List<Venda>();
        }
    }
}