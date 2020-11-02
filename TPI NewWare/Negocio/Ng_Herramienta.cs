using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Entidades;
using TPI_NewWare.Clases;

namespace TPI_NewWare.Negocio
{
    class Ng_Herramienta
    {
        Herramienta herramienta = new Herramienta();
        Be_BaseDatos _BD = new Be_BaseDatos();
        public void Alta(string nombre, string descripcion)
        {
            Herramienta herramienta_nueva = new Herramienta(nombre, descripcion);
            herramienta_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return herramienta.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return herramienta.ListarLike("nombre", Nombre);
        }

        public void Baja(int Id)
        {
            herramienta.Eliminar(Id);
        }

        public Herramienta Buscar(int id)
        {
            Herramienta herramienta_nueva = new Herramienta();
            herramienta_nueva.Buscar(id);
            return herramienta_nueva;
        }

        public DataTable ConsultaFiltrada(string desde, string hasta, string herramienta, string proyecto, string etapa)
        {
            string consultaSQL = @"SELECT h.id, h.nombre, p.descripcion AS 'proyecto', e.descripcion AS 'etapa',p.fecha_inicio AS 'inicioProyecto', p.fecha_fin_real AS 'finProyecto', he.cod_proyecto, he.id_etapa, he.id_herramienta
                                   FROM herramientasEtapas he 
                                   INNER JOIN etapasProyecto ep ON (he.cod_proyecto = ep.cod_proyecto AND he.id_etapa = ep.id_etapa)
                                   INNER JOIN herramientas h ON (he.id_herramienta = h.id)
                                   INNER JOIN proyectos p ON (ep.cod_proyecto = p.codigo)
                                   INNER JOIN etapas e ON (ep.id_etapa = e.id) ";


            consultaSQL += "WHERE p.fecha_inicio BETWEEN CONVERT(date,'" + desde + "',103) AND CONVERT(date,'" + hasta + "',103)";

            if (!string.IsNullOrEmpty(herramienta))
                consultaSQL += " AND he.id_herramienta = " + herramienta;
            if (proyecto != "")
                consultaSQL += " AND he.cod_proyecto = " + proyecto;
            if (etapa != "")
                consultaSQL += " AND he.id_etapa = " + etapa;


            consultaSQL += " ORDER BY he.id_etapa";

            return _BD.Consulta(consultaSQL);
        }

        public DataTable obtenerCantidad(string desde, string hasta, string herramienta, string proyecto, string etapa)
        {
            string consultaSQL = @"SELECT h.nombre, COUNT (h.id) AS 'Cantidad'
                                   FROM herramientasEtapas he 
                                   INNER JOIN etapasProyecto ep ON (he.cod_proyecto = ep.cod_proyecto AND he.id_etapa = ep.id_etapa)
                                   INNER JOIN herramientas h ON (he.id_herramienta = h.id)
                                   INNER JOIN proyectos p ON (ep.cod_proyecto = p.codigo)
                                   INNER JOIN etapas e ON (ep.id_etapa = e.id) ";


            consultaSQL += "WHERE p.fecha_inicio BETWEEN CONVERT(date,'" + desde + "',103) AND CONVERT(date,'" + hasta + "',103)";

            //if (!string.IsNullOrEmpty(producto))
            //    consultaSQL += " AND v.id_producto = " + producto;
            if (proyecto != "")
                consultaSQL += " AND he.cod_proyecto = " + proyecto;
            if (etapa != "")
                consultaSQL += " AND he.id_etapa = " + etapa;

            consultaSQL += "GROUP BY h.nombre";

            

            return _BD.Consulta(consultaSQL);
        }
    }
}