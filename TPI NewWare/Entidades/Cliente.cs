using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TPI_NewWare.Entidades
{
    class Cliente : ClaseBase
    {
        protected override string NombreTabla => "CLIENTES";


        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string NumeroCalle { get; set; }
        public string Email { get; set; }
        public string Activo { get; set; }



        public Cliente()
        {
        }

        public Cliente(string documento, string id_documento, string nombre, string apellido, string telefono, string calle, string numeroCalle, string email, string activo)
        {
            Documento = documento;
            TipoDocumento = id_documento;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Calle = calle;
            NumeroCalle = numeroCalle;
            Email = email;
            Activo = activo;
        }

        public override void Cargar_datos(DataRow fila)
        {
            Documento = fila["nroDocumento"].ToString();
            TipoDocumento = fila["id_documento"].ToString();
            Nombre = fila["nombre"].ToString();
            Apellido = fila["apellido"].ToString();
            Telefono = fila["telefono"].ToString();
            Calle = fila["calle"].ToString();
            NumeroCalle = fila["numeroCalle"].ToString();
            Email = fila["email"].ToString();
            Activo = fila["activo"].ToString();
        }

        //public override void Eliminar(int Id)
        //{
        //    Activo = "false";
        //}

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[9] { "nroDocumento", "id_documento", "nombres", "apellido", "telefono", "calle", "numeroCalle", "email", "activo" }, new string[9] { Documento, TipoDocumento, Nombre, Apellido, Telefono, Calle, NumeroCalle, Email, Activo });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[9] { "nroDocumento", "id_documento", "nombres", "apellido", "telefono", "calle", "numeroCalle", "email", "activo" }, new string[9] { Documento, TipoDocumento, Nombre, Apellido, Telefono, Calle, NumeroCalle, Email, Activo }, int.Parse(Documento));
        }
    }
}
