using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Entidades
{
    class TipDoc : ClaseBase
    {
        protected override string NombreTabla => "TIPDOC";

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string NombreTipoDocumento { get; set; }

        public TipDoc()
        {
        }

        public TipDoc(string nombre, string descripcion)
        {
            NombreTipoDocumento = nombre;
            Descripcion = descripcion;
        }

        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            NombreTipoDocumento = fila["nombreTipoDocumento"].ToString();
            Descripcion = fila["descripcion"].ToString();
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[2] { "nombreTipoDocumento", "descripcion"}, new string[2] { NombreTipoDocumento, Descripcion });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[2] { "nombreTipoDocumento", "descripcion"}, new string[2] { NombreTipoDocumento, Descripcion }, int.Parse(Id));
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
