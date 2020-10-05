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
    class Ng_VentaProducto
    {
        VentaProducto venta = new VentaProducto();
        Be_BaseDatos _BD = new Be_BaseDatos();
        public void Alta(string id_producto, string nroDocumento, string tipoDocumento, string fecha_venta, string fecha_inicio_instalacion, string fecha_fin_instalacion, string legajolider)
        {
            VentaProducto venta_nueva = new VentaProducto(id_producto, nroDocumento, tipoDocumento, fecha_venta, fecha_inicio_instalacion, fecha_fin_instalacion, legajolider);
            venta_nueva.Crear();
        }

        public DataTable Consulta()
        {          
            string consulta = "SELECT p.id, p.nombre AS nombreProducto, (c.nombres + ' ' + c.apellido) AS nombreCliente, v.fecha_venta, v.fecha_inicio_instalacion AS inicioInstalacion, v.fecha_fin_instalacion AS finInstalacion, (e.nombres + ' ' + e.apellido) AS nombreEmpleado " +
                "FROM ventaProducto v INNER JOIN producto p ON(v.id_producto = p.id) INNER JOIN clientes c ON(v.nroDocumento = c.nroDocumento) INNER JOIN empleados e ON(v.legajo_lider = e.legajo) ORDER BY v.fecha_venta DESC";

            return _BD.Consulta(consulta);


            //return venta.Listar(new string[4] { venta.CodProducto.ToString, venta.Documento.ToString, venta.TipoDocumento});
        }


        public DataTable ConsultaFiltrada(string desde, string hasta, string producto, string cliente, string lider)
        {
            string consultaSQL = "SELECT p.id, p.nombre AS nombreProducto, (c.nombres + ' ' + c.apellido) AS nombreCliente, v.fecha_venta, v.fecha_inicio_instalacion AS inicioInstalacion, v.fecha_fin_instalacion AS finInstalacion, (e.nombres + ' ' + e.apellido) AS nombreEmpleado " +
                                 "FROM ventaProducto v INNER JOIN producto p ON(v.id_producto = p.id) INNER JOIN clientes c ON(v.nroDocumento = c.nroDocumento) INNER JOIN empleados e ON(v.legajo_lider = e.legajo)";
                         

            consultaSQL += "WHERE v.fecha_venta BETWEEN CONVERT(date,'" + desde + "',103) AND CONVERT(date,'" + hasta + "',103)";

            if (!string.IsNullOrEmpty(producto))
                consultaSQL += " AND v.id_producto = " + producto;
            if (cliente != "")
                consultaSQL += " AND v.nroDocumento = " + cliente;
            if (lider != "")
                consultaSQL += " AND v.legajo_lider = " + lider;


            consultaSQL += " ORDER BY v.fecha_venta DESC";

            return _BD.Consulta(consultaSQL);
        }



            public DataTable ConsultaNombre(string Nombre)
        {
            return venta.ListarLike("nombre", Nombre);
        }

        public void Baja(int legajo)
        {
            venta.Eliminar(legajo);
        }


        public Empleado BuscarLegajo(int legajo)
        {
            Empleado empleado_nueva = new Empleado();
            empleado_nueva.BuscarLegajo(legajo);
            return empleado_nueva;
        }
    }
}
