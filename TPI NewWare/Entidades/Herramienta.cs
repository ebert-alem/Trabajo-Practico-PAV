using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Entidades
{
    class Herramienta: ClaseBase
    {
        protected override string NombreTabla => "HERRAMIENTAS";

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            Nombre = fila["nombre"].ToString();
            Descripcion = fila["descripcion"].ToString();
        }
    }
}
