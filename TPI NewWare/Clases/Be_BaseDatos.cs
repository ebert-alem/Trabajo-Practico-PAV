using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TPI_NewWare.Clases
{
    public class Be_BaseDatos
    {
        public enum EstadoAccionBD { correcto, error };
        public enum TipoConexion { simple, transaccional };
        public enum EstadoTransaccion { correcta, error };

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;
        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcta;
        //Cadena con la informacion del servidor y bd a conectar
        string Cadena_conexion = "Data Source = pavTpGrupal.mssql.somee.com; Persist Security Info = True; User ID = ebertalem_SQLLogin_1; Password = 4m8u7yha3i";

        //Comandos de transacciones
        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccional;
            ControlTransaccion = EstadoTransaccion.correcta;
        }
        public EstadoTransaccion CerrarTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccional)
            {
                if (ControlTransaccion == EstadoTransaccion.correcta)
                {
                    // terminar por commit
                    Transaccion.Commit();
                }
                else
                {
                    // terminar por rollback
                    Transaccion.Rollback();
                }
                ControlConexion = TipoConexion.simple;
                Desconectar();
            }
            return ControlTransaccion;
        }


        //Abre la conexion con el servidor
        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = Cadena_conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = System.Data.CommandType.Text;
                if (ControlConexion == TipoConexion.transaccional)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }

        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }

        //Envia una consulta sql al servidor
        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }
            Desconectar();
            return tabla;
        }

        private string EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
            }

            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                    tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                                    + "En el comando:" + "\n"
                                    + sql + "\n"
                                    + "El mensaje es:" + "\n"
                                    + e.Message);

                }
                Desconectar();
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Desconectar();
                return "";
            }
        }

        //Inserta un nuevo elemento en la tabla 
        public void Comando(string sql)
        {
            EjecutarNoSelect(sql);
        }
    }
}
