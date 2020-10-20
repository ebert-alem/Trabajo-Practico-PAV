using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Clases;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_HorasEmpleado
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();

        public DataTable Consulta()
        {
            //string consulta = "SELECT p.id, p.nombre AS nombreProducto, (c.nombres + ' ' + c.apellido) AS nombreCliente, v.fecha_venta, v.fecha_inicio_instalacion AS inicioInstalacion, v.fecha_fin_instalacion AS finInstalacion, (e.nombres + ' ' + e.apellido) AS nombreEmpleado, v.nroDocumento, v.tipoDocumento " +
            //    "FROM ventaProducto v INNER JOIN producto p ON(v.id_producto = p.id) INNER JOIN clientes c ON(v.nroDocumento = c.nroDocumento) INNER JOIN empleados e ON(v.legajo_lider = e.legajo) ORDER BY v.fecha_venta DESC";
            //SELECT e.legajo, e.nombres, e.apellido, e.documento, e.fecha_ingresante FROM empleadosEtapaProyecto v INNER JOIN Proyectos p ON(v.cod_proyecto = p.codigo) INNER JOIN empleados e ON(v.legajo = e.legajo)
            //SELECT e.legajo, e.nombres, e.apellido, e.documento, e.fecha_ingresante, p.descripcion AS nombre_proyecto, SUM(h.horas) AS horas FROM horas h INNER JOIN Proyectos p ON(h.codigo_proyecto = p.codigo) INNER JOIN empleados e ON(h.legajo = e.legajo) INNER JOIN etapas et ON (h.id_etapa_proyecto = et.id) GROUP BY e.legajo          //

            string consulta = "SELECT e.legajo, e.nombres, p.descripcion AS nombre_proyecto, et.descripcion AS nombre_etapa, SUM(h.horas) AS horas FROM horas h INNER JOIN Proyectos p ON(h.codigo_proyecto = p.codigo) INNER JOIN empleados e ON(h.legajo = e.legajo) INNER JOIN etapas et ON(h.id_etapa_proyecto = et.id) GROUP BY e.legajo, e.nombres, p.descripcion, et.descripcion";
               
            return _BD.Consulta(consulta);
        }
        public DataTable ConsultaFiltrada(string Codigo)

        {
            string consulta = "SELECT e.legajo, e.nombres, p.descripcion AS nombre_proyecto, et.descripcion AS nombre_etapa, SUM(h.horas) AS horas FROM horas h INNER JOIN Proyectos p ON(h.codigo_proyecto = p.codigo) INNER JOIN empleados e ON(h.legajo = e.legajo) INNER JOIN etapas et ON(h.id_etapa_proyecto = et.id)";
            consulta += " WHERE (p.codigo='" + Codigo + "')"; 
            //Es necesario agrupar para realizar la suma correctamente
            consulta += " GROUP BY e.legajo, e.nombres, p.descripcion, et.descripcion";

            //string consulta = "SELECT e.legajo, e.nombres, e.apellido, e.documento, e.fecha_ingresante " +
            //  "FROM empleadosEtapaProyecto v INNER JOIN Proyectos p ON(v.cod_proyecto = p.codigo) INNER JOIN empleados e ON(v.legajo = e.legajo) WHERE (p.codigo='" + Codigo + "')";

            return _BD.Consulta(consulta);
        }
    }
}
