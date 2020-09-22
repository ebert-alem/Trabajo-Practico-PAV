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
        public void Alta(string legajo, string nombre, string apellido, string documento, string tipoDocumento, string fecha_ingresante, string fecha_egreso, string domicilio, string fecha_nacimiento, string id_Egreso, string usuario)
        {
            Empleado empleado_nueva = new Empleado(legajo, nombre, apellido, documento, tipoDocumento, fecha_ingresante, fecha_egreso, domicilio, fecha_nacimiento, id_Egreso, usuario);
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

        public Empleado Buscar(int legajo)
        {
            Empleado empleado_nueva = new Empleado();
            empleado_nueva.Buscar(legajo);
            return empleado_nueva;
        }
    }
}
