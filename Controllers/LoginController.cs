using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VWorkS.Data;

namespace VWorkS.Controllers
{
    public class LoginController : Controller
    {
        private readonly VWorkS.ConnectDBContext _ctx;

        public LoginController(VWorkS.ConnectDBContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index(string User)
        {
            if (User != null)
            {
                return View("Home");
            }
            return View();
        }

        public ActionResult ExisteUsuario(string user)
        {
            var existe = (from q in _ctx.Usuarios
                         where q.NombreUsuario == user
                         select q).ToList().Count();
            if (existe > 0)
                return View("../Home/Index");
            else
            {
                ViewBag.Mensaje = "No Existe usuario";
                return View("Index");
            }
        }
    }
}
