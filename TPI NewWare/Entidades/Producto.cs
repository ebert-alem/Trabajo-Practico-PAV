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
            return SqlUpdate(new string[4] { "nombre", "descripcion", "denominacion", "fecha_fin_desarrollo"}, new string[4] { Nombre, Descripcion, Denominacion, FechaFinDesarrollo}, int.Parse(Id));
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[4] { "nombre", "descripcion", "denominacion", "fecha_fin_desarrollo" }, new string[4] { Nombre, Descripcion, Denominacion, FechaFinDesarrollo });
        }
    }
}
