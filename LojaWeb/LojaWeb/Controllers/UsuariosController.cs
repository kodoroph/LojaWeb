﻿using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
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
        UsuariosDAO dao;

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
            dao.Adiciona(usuario);
            return RedirectToAction("Visualiza", new { id = usuario.Id});
        }

        public ActionResult Remove(int id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        public ActionResult Atualiza(Usuario usuario)
        {
            dao.Atualiza(usuario);
            return RedirectToAction("Index");
        }

    }
}
