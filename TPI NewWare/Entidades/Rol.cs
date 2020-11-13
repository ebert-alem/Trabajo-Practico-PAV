using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Entidades
{
    class Rol :ClaseBase
    {
        protected override string NombreTabla => "ROLES";

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Rol()
        {
        }

        public Rol(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override void Cargar_datos(DataRow fila)
        {
            Id = fila["id"].ToString();
            Nombre = fila["nombre"].ToString();
            Descripcion = fila["descripcion"].ToString();
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[2] { "nombre", "descripcion" }, new string[2] { Nombre, Descripcion });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[2] { "nombre", "descripcion" }, new string[2] { Nombre, Descripcion }, int.Parse(Id));
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
