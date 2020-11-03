using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TPI_NewWare.Clases;

namespace TPI_NewWare.Negocio
{
    class Ng_Tareas
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();

        public DataTable Consulta()
        {

            string consulta = "SELECT nombre AS Tarea, et.descripcion AS Etapa, p.descripcion AS Proyecto, v.legajo AS Legajo, " +
                "e.nombres AS Nombre, e.apellido AS Apellido FROM tareas v INNER JOIN etapas et ON(v.id_etapa = et.id) " +
                "INNER JOIN proyectos p ON(v.cod_proyecto = p.codigo) INNER JOIN empleados e ON(v.legajo = e.legajo) " +
                "ORDER BY e.apellido";

            return _BD.Consulta(consulta);
        }

        public DataTable ConsultaFiltrada(string legajo)
        {

            string consulta = "SELECT nombre AS Tarea, et.descripcion AS Etapa, p.descripcion AS Proyecto, v.legajo AS Legajo, " +
                "e.nombres AS Nombre, e.apellido AS Apellido FROM tareas v INNER JOIN etapas et ON(v.id_etapa = et.id) " +
                "INNER JOIN proyectos p ON(v.cod_proyecto = p.codigo) INNER JOIN empleados e ON(v.legajo = e.legajo) " +
                "WHERE v.legajo='" + legajo + "'";

            return _BD.Consulta(consulta);
        }

        public DataTable ConsultaEstadistica()
        {

            string consulta = "SELECT e.apellido AS Apellido, COUNT(t.nombre) AS Cantidad FROM tareas t " +
                "LEFT JOIN empleados e ON t.legajo = e.legajo GROUP BY apellido; ";

            return _BD.Consulta(consulta);
        }
    }
}
