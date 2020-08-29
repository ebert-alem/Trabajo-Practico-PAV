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
    public class ClaseBase
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        //Para hacer
        //Funcion que permita hacer una consulta con filtros
        //Funcion que permita buscar un objeto por otros parametros

        //Funcion que busca un objeto por su id
        public bool Buscar(int id)
        {
            //Obtiene el nombre de la clase
            string clase = this.GetType().ToString().ToUpper();
            string consulta = "SELECT * FROM" + clase + "WHERE id = '" + id + "'";
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
            //Obtiene el nombre de la clase
            string clase = this.GetType().ToString().ToUpper();
            //Obtiene todos las filas de la BD
            return _BD.Consulta("SELECT * FROM" + clase);
        }

        //La funcion listar con otros parametros puede representar los filtros


        //Carga los datos desde la fila al objeto
        public void Cargar_datos(DataRow fila)
        {
        }

    }
}
