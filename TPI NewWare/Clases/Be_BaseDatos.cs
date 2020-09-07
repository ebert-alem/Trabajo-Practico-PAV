using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TPI_NewWare.Clases
{
    public class Be_BaseDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();

        //Cadena con la informacion del servidor y bd a conectar
        string Cadena_conexion = "Data Source = pavTpGrupal.mssql.somee.com; Persist Security Info = True; User ID = ebertalem_SQLLogin_1; Password = 4m8u7yha3i";

        //Abre la conexion con el servidor
        private void Conectar()
        {
            Conexion.ConnectionString = Cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }

        //Cierra la conexion con el servidor
        private void Desconectar()
        {
            Conexion.Close();
        }

        //Envia una consulta sql al servidor
        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        //Inserta un nuevo elemento en la tabla 
        public void Comando(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Desconectar();
        }

        public String SentenciaInsertar(string Atributos)
        {
            //Devuelve una cadena con la sentencia para insertar
            return "";
        }
        public String SentenciaConsultar(string Atributos)
        {
            //Devuelve una cadena con la sentencia realizar una consulta
            return "";
        }

    }
}
