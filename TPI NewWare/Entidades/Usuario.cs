using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TPI_NewWare.Clases;
using System.Security.Cryptography.X509Certificates;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Entidades
{
    public class Usuario : ClaseBase
    {
        private string Nombre;
        private string Pass;

        protected override string NombreTabla => "USUARIOS";

        public Usuario(string Nombre, string Pass)
        {
            this.Nombre = Nombre;
            this.Pass = Pass;
        }
        public Usuario()
        {
        }

        //Busca un usuario en BD e indica si lo encuentra
        public bool Buscar(string nombre, string pass)
        {
            string consulta = "SELECT * FROM USUARIOS WHERE nombreUsuario = '" + nombre + "' and contraseña = HASHBYTES('SHA1','" + pass + "')";
            DataTable tabla = _BD.Consulta(consulta);

            if (tabla.Rows.Count > 0)
            {
                //se encontro el usuario
                Cargar_datos(tabla.Rows[0]);
                return true;
            }
            return false;
        }

        //Busca un usuario por su nombre
        public bool Buscar(string nombre)
        {
            string consulta = "SELECT * FROM USUARIOS WHERE nombreUsuario = '" + nombre + "'";
            DataTable tabla = _BD.Consulta(consulta);

            if (tabla.Rows.Count > 0)
            {
                //se encontro el usuario
                Cargar_datos(tabla.Rows[0]);
                return true;
            }
            return false;
        }

        //Carga los datos desde la fila al objeto

        public void Insertar()
        {
            //Inserta una nueva fila en la tabla de usuario con los atributos del objeto
            string sql = "INSERT INTO USUARIOS (nombreUsuario,contraseña) VALUES ('" + this.Nombre + "',HASHBYTES('SHA1','" + this.Pass + "'))";
            _BD.Comando(sql);
        }

        public override void Cargar_datos(DataRow fila)
        {
            this.Nombre = fila["nombreUsuario"].ToString();
            this.Pass = fila["contraseña"].ToString();
        }

        public override string SentciaSqlCrear()
        {
            return "(nombreUsuario, contraseña) VALUES('" + this.Nombre + "',HASHBYTES('SHA1', '" + this.Pass + "'))";
        }

        public override string SentciaSqlActualizar()
        {
            //Completar
            throw new NotImplementedException();
        }
    }
}
