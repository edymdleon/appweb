using VWorkS.Data;
using Microsoft.EntityFrameworkCore;


namespace VWorkS
{
    public class ConnectDBContext : DbContext
    {
        

        public ConnectDBContext(DbContextOptions<ConnectDBContext> options) : base(options){}

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
