using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Proyecto
    {
        Proyecto proyecto = new Proyecto();
        public void Alta(string documento, string tipoDocumento, string nombre, string apellido, string telefono, string calle, string numeroCalle, string email, string activos)
        {
            Cliente empleado_nueva = new Cliente(documento, tipoDocumento, nombre, apellido, telefono, calle, numeroCalle, email, activos);
            empleado_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return proyecto.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return proyecto.ListarLike("nombres", Nombre);
        }

        public void Baja(int legajo)
        {
            proyecto.Eliminar(legajo);
        }

        

    }
}
