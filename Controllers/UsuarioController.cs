using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VWorkS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VWorkS.Clases;
using X.PagedList;
using System.Web;

namespace VWorkS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IConnectRepository _repository;
        private readonly ILogger _logger;
       
        public UsuarioController(VWorkS.IConnectRepository repository, ILogger<UsuarioController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public ActionResult Index(int? Page, string Busqueda, int? paginador)
        {
            if (Page == 0 || Page == null)
                Page = 1;
            if (paginador == 0 || paginador == null)
                paginador = 5;
            ViewBag.Filtro = Busqueda;
            ViewBag.Paginador = paginador;
            ViewBag.Pagina = Page;
            var Lista = _repository.UsuarioList(Busqueda, Page, paginador);
            var I = Lista.ToPagedList(Page ?? 1, paginador ?? 5);
            return View(I);//_repository.UsuarioList(Busqueda, pagina, paginador));
        }

        

        public ActionResult UsuarioAgregar()
        {
            var Modelo = new UsuarioManto();
            Modelo.Usuario = new Usuario();
            Modelo.Usuario.IdUsuario = 0;
            Modelo.Usuario.NombreUsuario = "";
            Modelo.Usuario.EstadoRegistro = VarGlobales.Activo;
            ViewBag.TipoManto = VarGlobales.Agregar;
            return PartialView("UsuarioManto", Modelo);
        }

        public ActionResult UsuarioEditar(int id)
        {
            var Modelo = new UsuarioManto();
            Modelo.Usuario = _repository.UsuariosGet(id);
            ViewBag.TipoManto = VarGlobales.Editar;
            return PartialView("UsuarioManto", Modelo);
        }

        public ActionResult UsuarioEliminar(int id)
        {
            var Modelo = new UsuarioManto();
            Modelo.Usuario = _repository.UsuariosGet(id);
            ViewBag.TipoManto = VarGlobales.Eliminar;
            return PartialView("UsuarioManto", Modelo);
        }
        

        [HttpPost]
        public ActionResult UsuarioManto(UsuarioManto Modelo)
        {
           
            string TipoManto = Request.Form["TipoManto"];
            if (ModelState.IsValid)
            {
                int Eliminar = 1;
                if ((TipoManto == VarGlobales.Agregar))
                    _repository.UsuariosAdd(Modelo.Usuario);

                if (TipoManto == VarGlobales.Editar)
                    _repository.UsuariosUpdate(Modelo);

                if (TipoManto == VarGlobales.Eliminar)
                    Eliminar = _repository.UsuariosRemove(Modelo.Usuario);
                if (Eliminar == 1){ 
                    _repository.Grabar();
                    return Json(new { success = true });
                }
                else
                {
                    ModelState.AddModelError("EliminarError", "No se puede eliminar solo Inactivar.");
                }
                
            }
           ViewBag.TipoManto = TipoManto;
            return PartialView("UsuarioManto", Modelo);
        }
    }
}