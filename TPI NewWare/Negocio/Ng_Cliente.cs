using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Cliente
    {
        Cliente cliente = new Cliente();
        public void Alta(string documento, string tipoDocumento, string nombre, string apellido, string telefono, string calle, string numeroCalle, string email, string activo)
        {
            Cliente empleado_nueva = new Cliente(documento, tipoDocumento, nombre, apellido, telefono, calle, numeroCalle, email, activo);
            empleado_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return cliente.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return cliente.ListarLike("nombre", Nombre);
        }

        public void Baja(int legajo)
        {
            cliente.Eliminar(legajo);
        }

        public Cliente Buscar(int legajo)
        {
            Cliente cliente_nuevo = new Cliente();
            cliente_nuevo.Buscar(legajo);
            return cliente_nuevo;
        }
    }
}
