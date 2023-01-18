using VWorkS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using VWorkS.Clases;
using X.PagedList;

namespace VWorkS
{
    public class ConnectRepository : IConnectRepository
    {
        private readonly VWorkS.ConnectDBContext _ctx;
        private readonly ILogger<VWorkS.ConnectDBContext> _logger;

        public ConnectRepository(VWorkS.ConnectDBContext ctx, ILogger<VWorkS.ConnectDBContext> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public bool Grabar()
        {
            return _ctx.SaveChanges() > 0;
        }

        #region [Empleados]
        public IEnumerable<Empleado> EmpleadoList(string busqueda, int? pagina, int? paginador)
        {
            try
            {
                /*  if (busqueda == null)
                  {
                      var f = _ctx.Empleados.OrderBy(c => c.EstadoRegistro).ThenBy(c => c.NombreCompleto).ToList();
                      return f;
                  }
                  else
                  {
                      return _ctx.Empleados.Where(x => x.NombreCompleto.Contains(busqueda)).OrderBy(c => c.EstadoRegistro).ThenBy(c => c.NombreCompleto).ToList();
                  } */
                var Lista = _ctx.Empleados.ToList();
                Console.WriteLine(Lista);
                return Lista;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en Listar Empleados {ex}");
                return null;
            }
        }
        public void EmpleadosAdd(Empleado Empleado)
        {
            try
            {
                Empleado.UsuarioModifica = 1;
                Empleado.FechaHoraModifica = DateTime.Now;
                _ctx.Add(Empleado);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en agregar Empleado {ex}");
            }
            
        }
        public void EmpleadosUpdate(EmpleadoManto Modelo)
        {
            var modificacion = _ctx.Empleados.Find(Modelo.Empleado.IdEmpleado);
            modificacion.NombreCompleto = Modelo.Empleado.NombreCompleto;
            modificacion.SalarioBase = Modelo.Empleado.SalarioBase;
            modificacion.DPI = Modelo.Empleado.DPI;
            modificacion.CantidadHijos = Modelo.Empleado.CantidadHijos;
            modificacion.FechaHoraModifica = DateTime.Now;
            modificacion.UsuarioModifica = 1;
            modificacion.EstadoRegistro = Modelo.Empleado.EstadoRegistro;
            _ctx.Empleados.Update(modificacion);
        }
        public int EmpleadosRemove(Empleado Empleado)
        {
            var eliminar = _ctx.Empleados.Find(Empleado.IdEmpleado);
            var datos = (from q in _ctx.Empleados
                         where q.IdEmpleado == Empleado.IdEmpleado
                         select q).ToList().Count();
            if (datos == 0)
            {
                _ctx.Empleados.Remove(eliminar);
                return 1;
            }else{
                return 0;
            }
        }
        public Empleado EmpleadosGet(int id)
        {
            if (id == 0)
            {
                return _ctx.Empleados.ToList().LastOrDefault();
            }
            var Modelo = _ctx.Empleados.Where(w => w.IdEmpleado == id).FirstOrDefault();
            var x = _ctx.Usuarios.Where(j => j.IdUsuario == Modelo.UsuarioModifica).FirstOrDefault();
            Modelo.Usuario = x.NombreUsuario;
            return Modelo;
        }
        public bool GrabarEmpleado()
        {
            return _ctx.SaveChanges() > 0;
        }
        public int EmpleadosCount(bool activas = false)
        {
            if (activas)
                return _ctx.Empleados.Where(w => w.EstadoRegistro == "A").Count();
            else
                return _ctx.Empleados.Count();
        }
        #endregion


        #region [Usuarios]
        public IEnumerable<Usuario> UsuarioList(string busqueda, int? pagina, int? paginador)
        {
            try
            {
                if (busqueda == null)
                {
                    var u = _ctx.Usuarios.OrderBy(c => c.EstadoRegistro).ThenBy(c => c.NombreUsuario).ToList();
                    return u;
                }
                else
                {
                    return _ctx.Usuarios.Where(x => x.NombreUsuario.Contains(busqueda)).OrderBy(c => c.EstadoRegistro).ThenBy(c => c.NombreUsuario).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en Listar Usuarios {ex}");
                return null;
            }
        }
        public void UsuariosAdd(Usuario Usuario)
        {
            try
            {
                Usuario.UsuarioModifica = 1;
                Usuario.FechaHoraModifica = DateTime.Now;
                _ctx.Add(Usuario);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en agregar Usuario {ex}");
            }

        }
        public void UsuariosUpdate(UsuarioManto Modelo)
        {
            var modificacion = _ctx.Usuarios.Find(Modelo.Usuario.IdUsuario);
            modificacion.NombreUsuario = Modelo.Usuario.NombreUsuario;
            modificacion.Email = Modelo.Usuario.Email;
            modificacion.FechaNacimiento = Modelo.Usuario.FechaNacimiento;
            modificacion.FechaHoraModifica = DateTime.Now;
            modificacion.UsuarioModifica = 1;
            modificacion.EstadoRegistro = Modelo.Usuario.EstadoRegistro;
            _ctx.Usuarios.Update(modificacion);
        }
        public int UsuariosRemove(Usuario Usuario)
        {
            var eliminar = _ctx.Usuarios.Find(Usuario.IdUsuario);
            var datos = (from q in _ctx.Usuarios
                         where q.IdUsuario == Usuario.IdUsuario
                         select q).ToList().Count();
            if (datos == 0)
            {
                _ctx.Usuarios.Remove(eliminar);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public Usuario UsuariosGet(int id)
        {
            if (id == 0)
            {
                return _ctx.Usuarios.ToList().LastOrDefault();
            }
            var Modelo = _ctx.Usuarios.Where(w => w.IdUsuario == id).FirstOrDefault();
            var x = _ctx.Usuarios.Where(j => j.IdUsuario == Modelo.UsuarioModifica).FirstOrDefault();
            Modelo.NombreUsuario = x.NombreUsuario;
            return Modelo;
        }
        public bool GrabarUsuario()
        {
            return _ctx.SaveChanges() > 0;
        }
        public int UsuariosCount(bool activas = false)
        {
            if (activas)
                return _ctx.Usuarios.Where(w => w.EstadoRegistro == "A").Count();
            else
                return _ctx.Usuarios.Count();
        }
        #endregion



    }
}
