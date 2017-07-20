using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class UsuariosController : Controller
    {
        //
        // GET: /Usuarios/

        private UsuariosDAO dao;
        public UsuariosController(UsuariosDAO dao)
        {
            this.dao = dao;
        }

        public ActionResult Index()
        {
            IList<Usuario> usuarios = new List<Usuario>();
            return View(usuarios);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            //ISession session = NHibernateHelper.AbreSession();
            //UsuariosDAO dao = new UsuariosDAO(session);
            //dao.Adiciona(usuario);

            //return RedirectToAction("Visualiza", new { id = usuario.Id });

            dao.Adiciona(usuario);
            return View("Index");
        }

        public ActionResult Remove(int id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            ISession session = NHibernateHelper.AbreSession();
            UsuariosDAO dao = new UsuariosDAO(session);
            Usuario usuario = dao.BuscaPorId(id);
            session.Close();

            return View(usuario);
        }

        public ActionResult Atualiza(Usuario usuario)
        {
            ISession session = NHibernateHelper.AbreSession();
            UsuariosDAO dao = new UsuariosDAO(session);
            dao.Atualiza(usuario);
            session.Close();

            return RedirectToAction("Index");
        }

    }
}
