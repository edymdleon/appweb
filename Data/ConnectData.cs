using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//VWorkS cambiar el nombre 
namespace VWorkS.Data
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public int DPI { get; set; }
        public int CantidadHijos { get; set; }
        public int SalarioBase { get; set; }
        public int BonoDecreto { get; set; }
        public DateTime? FechaHoraModifica  { get; set; }
        public int? UsuarioModifica  { get; set; }
        public string EstadoRegistro  { get; set; }
        [NotMapped]
        public string Usuario { get; set; }

    }

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }
        public DateTime? FechaHoraModifica { get; set; }
        public int? UsuarioModifica { get; set; }
        public string EstadoRegistro { get; set; }
    }

   

}
