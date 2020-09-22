using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TPI_NewWare.Entidades
{
    class MotivoEgreso : ClaseBase
    {
        protected override string NombreTabla => "MOTIVOEGRESO";

        public string Id { get; set; }
        public string Nombre { get; set; }

        public MotivoEgreso()
        {
        }

        public MotivoEgreso(string nombre)
        {
            Nombre = nombre;
        }

        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            Nombre = fila["nombre"].ToString();
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[1] { "nombre" }, new string[1] { Nombre });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[1] { "nombre" }, new string[1] { Nombre }, int.Parse(Id));
        }

    }
}
