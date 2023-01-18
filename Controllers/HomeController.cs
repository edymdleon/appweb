using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrainConnect.Controllers
{
    public class HomeController : Controller
    {
        private readonly VWorkS.IConnectRepository _repository;
        private readonly ILogger _logger;

        public HomeController(VWorkS.IConnectRepository repository, ILogger<HomeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.MensajeBienvenida = "SI";
            ViewBag.EmpleadosActivas = _repository.EmpleadosCount(true);
            ViewBag.EmpleadosCount = _repository.EmpleadosCount();

            ViewBag.UsuariosActivas = _repository.UsuariosCount(true);
            ViewBag.UsuariosCount = _repository.UsuariosCount();
            return View();
        }
    }
}
