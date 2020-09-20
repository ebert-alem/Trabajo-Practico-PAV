using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_NewWare.Entidades
{
    class Etapa : ClaseBase
    {
        protected override string NombreTabla => "ETAPAS";

        public string Id { get; set; }
        public string Descripcion { get; set; }

        public Etapa()
        {
        }

        public Etapa(string descripcion)
        {
            Descripcion = descripcion;
        }
        
        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            Descripcion = fila["descripcion"].ToString();
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[1] { "descripcion" }, new string[1] { Descripcion }, int.Parse(Id));
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[1] { "descripcion" }, new string[1] { Descripcion });
        }
    }
}
