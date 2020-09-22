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

        public Cliente(string documento, string id_documento, string nombre, string apellido, string telefono, string calle, string numeroCalle, string email, string activos)
        {
            Documento = documento;
            TipoDocumento = id_documento;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Calle = calle;
            NumeroCalle = numeroCalle;
            Email = email;
            Activo = activos;
        }

        public override void Cargar_datos(DataRow fila)
        {
            Documento = fila["nroDocumento"].ToString();
            TipoDocumento = fila["id_documento"].ToString();
            Nombre = fila["nombres"].ToString();
            Apellido = fila["apellido"].ToString();
            Telefono = fila["telefono"].ToString();
            Calle = fila["calle"].ToString();
            NumeroCalle = fila["numeroCalle"].ToString();
            Email = fila["email"].ToString();
            Activo = fila["activos"].ToString();
        }

        //public override void Eliminar(int Id)
        //{
        //    Activo = "false";
        //}

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[9] { "nroDocumento", "id_documento", "nombres", "apellido", "telefono", "calle", "numeroCalle", "email", "activos" }, new string[9] { Documento, TipoDocumento, Nombre, Apellido, Telefono, Calle, NumeroCalle, Email, Activo });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdateDocumento(new string[7] {"id_documento", "nombres", "apellido", "telefono", "calle", "numeroCalle", "email"}, new string[7] {TipoDocumento, Nombre, Apellido, Telefono, Calle, NumeroCalle, Email }, int.Parse(Documento));
        }

        public override void Eliminar(int Id)
        {
            //string cadena = SqlUpdateDocumento(new string[1] { "activos" }, new string[1] { Activo }, int.Parse(Documento));
            string sql = "UPDATE " + NombreTabla + " SET " + "activos=0" + "WHERE nroDocumento=" + Id;
            _BD.Comando(sql);
        }

        public override DataTable Listar(string[] Columnas, string[] Valores)
        {
            //Condicion por la que se filtra la busqueda
            string Condiciones = " WHERE ( ";
            for (int i = 0; i < Columnas.Length; i++)
            {
                Condiciones += Columnas[i] + " = '" + Valores[i] + "'";
                //Agrega una coma salvo en el ultimo caso
                if (i < Columnas.Length - 1) Condiciones += " , ";
            }
            Condiciones += ", activos='1' ) ";
            return _BD.Consulta("SELECT * FROM " + NombreTabla + Condiciones);
        }

        public override DataTable Listar()
        {
            //Obtiene todos las filas de la BD
            return _BD.Consulta("SELECT * FROM " + NombreTabla + " WHERE activos='1'");
        }
    }
}
