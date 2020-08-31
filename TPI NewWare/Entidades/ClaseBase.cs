using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TPI_NewWare.Clases;


namespace TPI_NewWare.Entidades
{   
    // Clase base para todas las clases del proyecto
    public abstract class ClaseBase
    {
        protected Be_BaseDatos _BD = new Be_BaseDatos();

        protected abstract string NombreTabla { get; }
        //Para hacer
        //Funcion que permita hacer una consulta con filtros
        //Funcion que permita buscar un objeto por otros parametros

        //Funcion que busca un objeto por su id
        public bool Buscar(int id)
        {
            //Obtiene el nombre de la clase
            string clase = this.GetType().ToString().ToUpper();
            string consulta = "SELECT * FROM " + NombreTabla + " WHERE id = '" + id + "'";
            DataTable tabla = _BD.Consulta(consulta);

            //Verifica si se encontro la fila
            if (tabla.Rows.Count > 0)
            {
                //Carga al objeto con los datos de la fila
                Cargar_datos(tabla.Rows[0]);
                return true;
            }
            return false;
        }

        public DataTable Listar()
        {
            //Obtiene todos las filas de la BD
            return _BD.Consulta("SELECT * FROM " + NombreTabla);
        }

        //Genera una lista que cumpla las condiciones de las columnas ingresadas
        public DataTable Listar(string[] Columnas, string[] Valores)
        {
            //Condicion por la que se filtra la busqueda
            string Condiciones = " WHERE ( ";
            for (int i = 0; i < Columnas.Length; i++)
            {   
                Condiciones += Columnas[i] + " = '" + Valores[i] + "'";
                //Agrega una coma salvo en el ultimo caso
                if (i < Columnas.Length - 1) Condiciones +=  " , ";
            }
            Condiciones += " ) ";
            return _BD.Consulta("SELECT * FROM " + NombreTabla + Condiciones);
        }

        //Caso simplificado cuando se tiene una sola cadena a verificar
        public DataTable Listar(string Columna, string Valor)
        {
            return Listar(new string[1] { Columna }, new string[1] { Valor });
        }

        //Genera una lista que filtra los parametros de una columna que coincidan con el texto


        public DataTable ListarLike(string[] Columnas, string[] Valores)
        {
            string Condiciones = " WHERE ( ";
            for (int i = 0; i < Columnas.Length; i++)
            {
                Condiciones += Columnas[i] + " LIKE '%" + Valores[i] + "%'";
                
                if (i < Columnas.Length - 1) Condiciones += " , ";
            }
            Condiciones += " ) ";

            return _BD.Consulta("SELECT * FROM " + NombreTabla + Condiciones);
        }

        //Caso simplificado cuando se tiene una sola cadena a verificar
        public DataTable ListarLike(string Columna, string Valor)
        {
            //Ingresa los valores en el formato de la funcion anterior
            return ListarLike(new string[1] { Columna }, new string[1] { Valor });
        }




        //Carga los datos desde la fila al objeto
        public abstract void Cargar_datos(DataRow fila);

    }
}
