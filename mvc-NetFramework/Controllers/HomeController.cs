using mvc_NetFramework.DAOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace mvc_NetFramework.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarUsuarioSinAjax(int usuarioId)
        {

            ViewBag.usuario = UsuarioDAO.getInstancia().getUsuarioById(usuarioId);

            return View("Index");

        }

        [HttpPost]
        public JsonResult BuscarUsuarioConAjax([FromBody] JsonUsuario jsonUsuario)
        {

            var usuario = UsuarioDAO.getInstancia().getUsuarioById(jsonUsuario.id);
            return Json(JsonConvert.SerializeObject(usuario));

        }

        public class JsonUsuario
        {
            public int id { get; set; }
        }

    }
}