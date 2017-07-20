using LojaWeb.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class UsuariosDAO
    {
        private ISession session;

        public UsuariosDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Usuario usuario)
        {
            //ITransaction transaction = this.session.BeginTransaction();
            this.session.Save(usuario);
            //transaction.Commit();
        }

        public void Remove(Usuario usuario)
        {
            //ITransaction transaction = this.session.BeginTransaction();
            this.session.Delete(usuario);
            //transaction.Commit();
        }

        public void Atualiza(Usuario usuario)
        {
            //ITransaction transaction = this.session.BeginTransaction();
            this.session.Merge(usuario);
            //transaction.Commit();
        }

        public Usuario BuscaPorId(int id)
        {
            return session.Get<Usuario>(id);
        }

        public IList<Usuario> Lista()
        {
            return new List<Usuario>();
        }
    }
}