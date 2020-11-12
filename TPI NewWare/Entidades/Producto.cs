using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TPI_NewWare.Entidades
{
    class Producto : ClaseBase
    {
        protected override string NombreTabla => "PRODUCTO";

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string Denominacion { get; set; }
        public string FechaFinDesarrollo { get; set; }
        public string Nombre { get; set; }


        public Producto()
        {
        }

        public Producto(string nombre, string denominacion, string descripcion, string fecha_fin_desarrollo)
        {
            Nombre = nombre;
            Denominacion = denominacion;
            Descripcion = descripcion;
            FechaFinDesarrollo = fecha_fin_desarrollo;

        }

        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            Nombre = fila["nombre"].ToString();
            Descripcion = fila["descripcion"].ToString();
            Denominacion = fila["denominacion"].ToString();
            FechaFinDesarrollo = fila["fecha_fin_desarrollo"].ToString();
        }

        public override string SentciaSqlActualizar()
        {
            return "UPDATE producto SET nombre = '" + Nombre + "', descripcion = '" + Descripcion + "', denominacion = '" + Denominacion + "', fecha_fin_desarrollo = " + " CONVERT(date, '" + FechaFinDesarrollo + "', 103) WHERE id = " + Id;
            //return SqlUpdate(new string[4] { "nombre", "descripcion", "denominacion", "fecha_fin_desarrollo"}, new string[4] { Nombre, Descripcion, Denominacion, FechaFinDesarrollo}, int.Parse(Id));
        }

        public override string SentciaSqlCrear()
        {
            return "INSERT INTO producto (nombre, denominacion, descripcion, fecha_fin_desarrollo) VALUES ('" + Nombre + "', '" + Denominacion + "', '" + Descripcion + "', " + " CONVERT(date, '" + FechaFinDesarrollo + "', 103) " + ")";
            //return SqlInsert(new string[4] { "nombre", "descripcion", "denominacion", "fecha_fin_desarrollo" }, new string[4] { Nombre, Descripcion, Denominacion, FechaFinDesarrollo });
        }

        public override void Eliminar(int Id)
        {
            string sql = "UPDATE " + NombreTabla + " SET " + "activo=0" + "WHERE id=" + Id;
            _BD.Comando(sql);
        }

        public override DataTable Listar()
        {
            //Obtiene todos las filas de la BD
            return _BD.Consulta("SELECT * FROM " + NombreTabla + " WHERE activo='1'");
        }

    }
}
