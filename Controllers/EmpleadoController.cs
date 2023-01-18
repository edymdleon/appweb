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
    public class EmpleadoController : Controller
    {
        private readonly IConnectRepository _repository;
        private readonly ILogger _logger;
       
        public EmpleadoController(VWorkS.IConnectRepository repository, ILogger<EmpleadoController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index(int? Page, string Busqueda, int? paginador)
        {
            if (Page == 0 || Page == null)
                Page = 1;
            if (paginador == 0 || paginador == null)
                paginador = 5;
            ViewBag.Filtro = Busqueda;
            ViewBag.Paginador = paginador;
            ViewBag.Pagina = Page;
            var Lista = _repository.EmpleadoList(Busqueda, Page, paginador);
            var I = Lista.ToPagedList(Page ?? 1, paginador ?? 5);
            return View(I);
        }



        public ActionResult EmpleadoAgregar()
        {
            var Modelo = new EmpleadoManto();
            Modelo.Empleado = new Empleado();
            Modelo.Empleado.IdEmpleado = 0;
            Modelo.Empleado.NombreCompleto = "";
            Modelo.Empleado.EstadoRegistro = VarGlobales.Activo;
            ViewBag.TipoManto = VarGlobales.Agregar;
            return PartialView("EmpleadoManto", Modelo);
        }

        public ActionResult EmpleadoEditar(int id)
        {
            var Modelo = new EmpleadoManto();
            Modelo.Empleado = _repository.EmpleadosGet(id);
            ViewBag.TipoManto = VarGlobales.Editar;
            return PartialView("EmpleadoManto", Modelo);
        }

        public ActionResult EmpleadoEliminar(int id)
        {
            var Modelo = new EmpleadoManto();
            Modelo.Empleado = _repository.EmpleadosGet(id);
            ViewBag.TipoManto = VarGlobales.Eliminar;
            return PartialView("EmpleadoManto", Modelo);
        }
        

        [HttpPost]
        public ActionResult EmpleadoManto(EmpleadoManto Modelo)
        {
           
            string TipoManto = Request.Form["TipoManto"];
            if (ModelState.IsValid)
            {
                int Eliminar = 1;
                if ((TipoManto == VarGlobales.Agregar))
                    _repository.EmpleadosAdd(Modelo.Empleado);

                if (TipoManto == VarGlobales.Editar)
                    _repository.EmpleadosUpdate(Modelo);

                if (TipoManto == VarGlobales.Eliminar)
                    Eliminar = _repository.EmpleadosRemove(Modelo.Empleado);
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
            return PartialView("EmpleadoManto", Modelo);
        }
    }
}