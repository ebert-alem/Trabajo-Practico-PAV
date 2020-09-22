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
        public string Activo { get; set; }




        public Empleado()
        {
        }

        public Empleado(string legajo, string id_egreso, string id_documento, string nombreUsuario, string documento, string nombre, string apellido, string fecha_ingresante, string fecha_egreso, string domicilio, string fecha_nacimiento, string activo)
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
            Activo = activo;

        }

        public override void Cargar_datos(DataRow fila)
        {
            Legajo = fila["legajo"].ToString();
            Nombre = fila["nombres"].ToString();
            Apellido = fila["apellido"].ToString();
            FechaIngreso = fila["fecha_ingresante"].ToString();
            FechaEgreso = fila["fecha_egreso"].ToString();
            FechaNacimiento = fila["fecha_nacimiento"].ToString();
            Domicilio = fila["domicilio"].ToString(); 
            TipoDocumento = fila["id_documento"].ToString();
            Documento = fila["documento"].ToString();
            Usuario = fila["nombreUsuario"].ToString();
            Id_Egreso = fila["id_egreso"].ToString();
            Id_Egreso = fila["activo"].ToString();
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[12] { "legajo", "id_egreso", "id_documento", "nombreUsuario", "documento", "nombres", "apellido", "fecha_ingresante", "fecha_egreso", "domicilio", "fecha_nacimiento", "activo"}, new string[12] { Legajo, Id_Egreso, TipoDocumento,  Usuario, Documento, Nombre, Apellido, FechaIngreso, FechaEgreso, (string) Domicilio, FechaNacimiento, Activo});
        }

        public override string SentciaSqlActualizar()
        {
            return SqlUpdateLegajo(new string[12] { "legajo", "id_egreso", "id_documento", "nombreUsuario", "documento", "nombres", "apellido", "fecha_ingresante", "fecha_egreso", "domicilio", "fecha_nacimiento", "activo" }, new string[12] { Legajo, Id_Egreso, TipoDocumento, Usuario, Documento, Nombre, Apellido, FechaIngreso, FechaEgreso, (string) Domicilio, FechaNacimiento, Activo }, int.Parse(Legajo));
        }
    }
}
