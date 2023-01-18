using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VWorkS.Data
{
    public class EmpleadoManto
    {
        public Empleado Empleado { get; set; }
        public List<Modificacion> OtraModificacion { get; set; }
    }
    public class Modificacion
    {
        public DateTime? FechaHora { get; set; }
        public string Usuario { get; set; }
    }

    public class Select1
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Select2
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class UsuarioManto
    {
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public List<Modificacion> OtraModificacion { get; set; }
    }
}
