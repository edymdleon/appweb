using VWorkS.Data;
using System.Collections.Generic;

namespace VWorkS
{
    public interface IConnectRepository
    {
        
        // No importa la entidad, graba el DBContext
        bool Grabar();

        #region - Empleados -
        IEnumerable<Empleado> EmpleadoList(string busqueda, int? pagina, int? paginador);
        int EmpleadosCount(bool activas = false);
        Empleado EmpleadosGet(int id);
        void EmpleadosAdd(Empleado Empleado);
        void EmpleadosUpdate(EmpleadoManto Empleado);
        int EmpleadosRemove(Empleado Empleado);
        #endregion

        #region - Usuarios -
        IEnumerable<Usuario> UsuarioList(string busqueda, int? pagina, int? paginador);
        int UsuariosCount(bool activas = false);
        Usuario UsuariosGet(int id);
        void UsuariosAdd(Usuario Usuario);
        void UsuariosUpdate(UsuarioManto Usuario);
        int UsuariosRemove(Usuario Usuario);
        #endregion
    }
}
