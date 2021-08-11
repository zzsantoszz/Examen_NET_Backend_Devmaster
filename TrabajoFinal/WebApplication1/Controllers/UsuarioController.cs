using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO.Modelo;
using DAO;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        private connBD_EF conn = new connBD_EF();
        // GET: Usuario
        public ActionResult Index()
        {
            
            return View(conn.tb_usuario.ToList());
        }
    }
}