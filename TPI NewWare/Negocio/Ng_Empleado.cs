using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Empleado
    {
        Empleado empleado = new Empleado();
        public void Alta(string legajo, string id_Egreso, string tipoDocumento, string usuario, string documento, string nombre, string apellido, string fecha_ingresante, string fecha_egreso, string domicilio, string fecha_nacimiento, string activo)
        {
            Empleado empleado_nueva = new Empleado(legajo, id_Egreso, tipoDocumento, usuario, documento, nombre, apellido, fecha_ingresante, fecha_egreso, domicilio, fecha_nacimiento, activo);
            empleado_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return empleado.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return empleado.ListarLike("nombre", Nombre);
        }

        public void Baja(int legajo)
        {
            empleado.Eliminar(legajo);
        }

        public Empleado BuscarLegajo(int legajo)
        {
            Empleado empleado_nueva = new Empleado();
            empleado_nueva.Buscar(legajo, "legajo");
            return empleado_nueva;
        }



    }
}
