using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TPI_NewWare.Clases;
using System.Reflection;

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


        //Funcion que permita buscar un objeto por cualquier valor especificando su campo
        public bool Buscar(int Valor, string Columna)
        {
            //Obtiene el nombre de la clase
            string clase = this.GetType().ToString().ToUpper();
            string consulta = "SELECT * FROM " + NombreTabla + " WHERE "+ Columna + " = '" + Valor + "'";
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
        
        //Funcion que busca un objeto por su id
        public bool Buscar(int id)
        {
            return Buscar(id, "id");
        }

        public virtual DataTable Listar()
        {
            //Obtiene todos las filas de la BD
            return _BD.Consulta("SELECT * FROM " + NombreTabla);
        }

        //Genera una lista que cumpla las condiciones de las columnas ingresadas
        public virtual DataTable Listar(string[] Columnas, string[] Valores)
        {
            //Condicion por la que se filtra la busqueda
            string Condiciones = " WHERE ( ";
            for (int i = 0; i < Columnas.Length; i++)
            {
                Condiciones += Columnas[i] + " = '" + Valores[i] + "'";
                //Agrega una coma salvo en el ultimo caso
                if (i < Columnas.Length - 1) Condiciones += " , ";
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

        //Crea una nueva fila en la bd
        public void Crear()
        {
            _BD.Comando(SentciaSqlCrear());
        }

        //Esta funcion provee a la funcion sqlInsert de los parametros propios del objeto en el que se implementa
        public abstract string SentciaSqlCrear();

        public void Guardar()
        {
            string sentencia = SentciaSqlActualizar();
            _BD.Comando(sentencia);
        }

        public abstract string SentciaSqlActualizar();

        public string SqlInsert(string[] Columnas, string[] Valores)
        {
            return "INSERT INTO " + NombreTabla + "(" + string.Join(", ", Columnas) + ") Values (" + string.Join(", ", Envolver("'", "'", Valores)) + ")";
        }

        public string SqlUpdate(string[] Columnas, string[] Valores, int Id)
        {
            return "UPDATE " + NombreTabla + " SET " + SqlEquals(Columnas, Valores) + " WHERE ID=" + Id;
        }

        public string SqlUpdateLegajo(string[] Columnas, string[] Valores, int Id)
        {
            return "UPDATE " + NombreTabla + " SET " + SqlEquals(Columnas, Valores) + "WHERE legajo=" + Id;
        }

        public string SqlUpdateDocumento(string[] Columnas, string[] Valores, int Id)
        {
            return "UPDATE " + NombreTabla + " SET " + SqlEquals(Columnas, Valores) + "WHERE nroDocumento=" + Id;
        }


        public string SqlEquals(string[] Columnas, string[] Valores)
        {
            string Condiciones = "";
            for (int i = 0; i < Columnas.Length; i++)
            {
                //Produce la cadena "atributo = valor," para cada par de atributos y valores
                Condiciones += Columnas[i] + " = '" + Valores[i] + "'";
                //Agrega una coma salvo en el ultimo caso
                if (i < Columnas.Length - 1) Condiciones += " , ";
            }
            return Condiciones;
        }


        //Funciones de modificacion de texto
        private string Envolver(string Envoltorio, string Cadena)
        {
            return Envoltorio + Cadena + Envoltorio;
        }

        private string Envolver(string EnvoltorioInicio, string EnvoltorioFin, string Cadena)
        {
            return EnvoltorioInicio + Cadena + EnvoltorioFin;
        }

        private string[] Envolver(string EnvoltorioInicio, string EnvoltorioFin, string[] Cadenas)
        {
            for (int i = 0; i < Cadenas.Length; i++)
            {
                Cadenas[i] = Envolver(EnvoltorioInicio, EnvoltorioFin, Cadenas[i]);
            }
            return Cadenas;
        }

        public virtual void Eliminar(int Id)
        {
            string sql = "DELETE FROM " + NombreTabla + " WHERE ID=" + Id.ToString();
            _BD.Comando(sql);
        }

        /*
        //Devuelve el nombre de los atributos de un objeto
        public string[] Atributos(bool Id=true)
        {
            //Obtengo el tipo de objeto actual
            Type datos = this.GetType();
            //Obtengo los campos de ese objeto
            FieldInfo[] field = datos.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Guardo el nombre de los campos como cadena
            string[] atributos = new string[0];
            string[] valores = new string[0];

            for (int i = 0; i < field.Length; i++)
            {   
                //Si esta seleccionada la opcion del id o es un campo distino
                if (Id || field[i].Name.ToUpper() != "ID")
                {
                    atributos.Append(field[i].Name);
                }
            }
            return atributos;
        }
        
        //Devuelve un array con los valores de los nombres de los atributos que se le pasa
        public string[] Valores(string[] atributos)
        {
            //Obtengo el tipo de objeto actual
            Type datos = this.GetType();
            //Obtengo los campos de ese objeto
            FieldInfo[] field = datos.GetFields(BindingFlags.Public | BindingFlags.Instance);

            string[] valores = new string[atributos.Length];
            foreach (string atributo in atributos)
            {
                valores.Length = 
            }
            return valores;
        }
        */
    }
}
