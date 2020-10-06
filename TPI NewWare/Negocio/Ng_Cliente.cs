using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;
using TPI_NewWare.Clases;

namespace TPI_NewWare.Negocio
{
    class Ng_Cliente
    {
        Cliente cliente = new Cliente();
        public void Alta(string documento, string tipoDocumento, string nombre, string apellido, string telefono, string calle, string numeroCalle, string email, string activos)
        {
            Cliente empleado_nueva = new Cliente(documento, tipoDocumento, nombre, apellido, telefono, calle, numeroCalle, email, activos);
            empleado_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return cliente.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return cliente.ListarLike("nombres", Nombre);
        }

        public void Baja(int legajo)
        {
            cliente.Eliminar(legajo);
        }

        public Cliente BuscarDocumento(int id)
        {
            Cliente cliente_nuevo = new Cliente();
            cliente_nuevo.Buscar(id, "nroDocumento");
            return cliente_nuevo;
        }

        //Retoma el nombre y apellido del cliente por documento y tipo...
        public string BuscarNombreCompleto(string nroDocumento, string tipoDocumento)
        {
            string consulta = "SELECT (nombres + ' ' + apellido) AS nombreCompleto FROM clientes WHERE nroDocumento = " + nroDocumento + " AND id_documento = " + tipoDocumento;
            Be_BaseDatos _BD = new Be_BaseDatos();
            DataTable tab =_BD.Consulta(consulta);
            return Convert.ToString(tab.Rows[0]["nombreCompleto"]);
        }

    }
}
