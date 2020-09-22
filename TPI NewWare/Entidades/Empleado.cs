using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Entidades
{
    class Empleado : ClaseBase
    {
        protected override string NombreTabla => "EMPLEADOS";

        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaEgreso { get; set; }
        public string FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public string Id_Egreso { get; set; }
        public string Usuario { get; set; }
        public string Domicilio { get; set; }




        public Empleado()
        {
        }

        public Empleado(string legajo, string nombre, string apellido, string documento, string fecha_ingresante, string fecha_egreso, string domicilio, string fecha_nacimiento, string id_documento, string nombreUsuario, string id_egreso)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            FechaIngreso = fecha_ingresante;
            FechaEgreso = fecha_egreso;
            FechaNacimiento = fecha_nacimiento;
            Domicilio = domicilio;
            TipoDocumento = id_documento;
            Documento = documento;
            Usuario = nombreUsuario;
            Id_Egreso = id_egreso;

        }

        public override void Cargar_datos(DataRow fila)
        {
            Legajo = fila["legajo"].ToString();
            Nombre = fila["nombre"].ToString();
            Apellido = fila["apellido"].ToString();
            FechaIngreso = fila["fecha_ingresante"].ToString();
            FechaEgreso = fila["fecha_egreso"].ToString();
            FechaNacimiento = fila["fecha_nacimiento"].ToString();
            Domicilio = fila["domicilio"].ToString(); 
            TipoDocumento = fila["id_documento"].ToString();
            Documento = fila["documento"].ToString();
            Usuario = fila["nombreUsuario"].ToString();
            Id_Egreso = fila["id_egreso"].ToString();

        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[11] { "legajo", "nombres", "apellido", "fecha_ingresante", "fecha_egreso", "fecha_nacimiento", "domicilio", "id_documento", "documento", "nombreUsuario", "id_egreso" }, new string[11] { Legajo, Nombre, Apellido, FechaIngreso, FechaEgreso, FechaNacimiento, Domicilio, TipoDocumento, Documento, Usuario, Id_Egreso });
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdate(new string[11] { "legajo", "nombres", "apellido", "fecha_ingresante", "fecha_egreso", "fecha_nacimiento", "domicilio", "id_diocumento", "documento", "nombreUsuario", "id_egreso" }, new string[11] { Legajo, Nombre, Apellido, FechaIngreso, FechaEgreso, FechaNacimiento, Domicilio, TipoDocumento, Documento, Usuario, Id_Egreso}, int.Parse(Legajo));
        }
    }
}
