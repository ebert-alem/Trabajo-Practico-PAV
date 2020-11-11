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
    class Ng_Proyecto
    {
        Proyecto proyecto = new Proyecto();
        Be_BaseDatos _BD = new Be_BaseDatos();

        public DataTable ConsultaFiltrada(string desde, string hasta, string proyecto, string cliente, bool Eliminados)
        {
            string consultaSQL = "SELECT p.codigo, p.descripcion, (c.nombres + ' ' + c.apellido) AS nombre_cliente, p.fecha_inicio, p.fecha_fin_probable, p.fecha_fin_real FROM proyectos p INNER JOIN clientes c ON(p.nroDoc_cliente = c.nroDocumento) ";

            consultaSQL += " WHERE p.fecha_inicio BETWEEN CONVERT(date,'" + desde + "',103) AND CONVERT(date,'" + hasta + "',103)";

            if (!string.IsNullOrEmpty(proyecto))
                consultaSQL += " AND p.codigo = " + proyecto;
            if (cliente != "")
                consultaSQL += " AND p.nroDoc_cliente = " + cliente;

            if (Eliminados) consultaSQL += " AND p.activos=0";
            else consultaSQL += " AND p.activos=1";

            consultaSQL += " ORDER BY p.fecha_inicio DESC";

            return _BD.Consulta(consultaSQL);
        }

        public DataTable Consulta(bool Eliminados)
        {
            string consultaSQL = "SELECT p.codigo, p.descripcion, (c.nombres + ' ' + c.apellido) AS nombre_cliente, p.fecha_inicio, p.fecha_fin_probable, p.fecha_fin_real FROM proyectos p INNER JOIN clientes c ON(p.nroDoc_cliente = c.nroDocumento) ";
            if (Eliminados) consultaSQL += " WHERE p.activos=0";
            else consultaSQL += " WHERE p.activos=1";
            
            return _BD.Consulta(consultaSQL);

        }

    }
}
