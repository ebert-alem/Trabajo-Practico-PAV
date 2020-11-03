using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Clases;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_ProyectoDuracion
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();
        public DataTable Consulta()
        {
            
            string consulta = "SELECT descripcion AS Proyecto, fecha_inicio AS Inicio, fecha_fin_real AS Finalizacion, DATEDIFF(day, fecha_inicio, fecha_fin_real) AS Duración FROM dbo.proyectos WHERE fecha_fin_real IS NOT NULL";

            return _BD.Consulta(consulta);
        }
        public DataTable ConsultaFiltrada(string Codigo)
        {
            string consulta = "SELECT e.legajo, e.nombres, e.apellido, p.descripcion AS nombre_proyecto, et.descripcion AS nombre_etapa FROM empleadosEtapaProyecto v INNER JOIN Proyectos p ON(v.cod_proyecto = p.codigo)INNER JOIN empleados e ON(v.legajo = e.legajo) INNER JOIN etapas et ON(v.id_etapa= et.id)";
            consulta += "WHERE (p.codigo='" + Codigo + "')";
            //            string consulta = "SELECT e.legajo, e.nombres, e.apellido, e.documento, e.fecha_ingresante " +
            //              "FROM empleadosEtapaProyecto v INNER JOIN Proyectos p ON(v.cod_proyecto = p.codigo) INNER JOIN empleados e ON(v.legajo = e.legajo) WHERE (p.codigo='" + Codigo + "')";

            return _BD.Consulta(consulta);
        }

        public DataTable ConsultaEstadistica(string proy)
        {

            string consulta = "SELECT et.descripcion AS Etapa, " +
                "DATEDIFF(day, v.fecha_inicio, fecha_fin) AS Duración FROM dbo.etapasProyecto v INNER JOIN etapas et " +
                "ON(v.id_etapa = et.id) INNER JOIN proyectos p ON(v.cod_proyecto = codigo) WHERE fecha_fin IS NOT NULL " +
                "AND cod_proyecto ='" + proy+"'";

            return _BD.Consulta(consulta);
        }
    }
}
