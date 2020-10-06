using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_NewWare.Entidades
{
    class Proyecto : ClaseBase
    {
        protected override string NombreTabla => "PROYECTOS";

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        //Atributos del cliente
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        //Fechas del proyecto
        public string FechaInicio { get; set; }
        public string FechaFinProbable{ get; set; }
        public string FechaFinReal { get; set; }

        public Proyecto()
        {

        }

        public Proyecto(string descripcion, string documento, string tipoDocumento, string fechaInicio, string fechaFinProbable)
        {
            Descripcion = descripcion;
            Documento = documento;
            TipoDocumento = tipoDocumento;
            FechaInicio = fechaInicio;
            FechaFinProbable = fechaFinProbable;
        }


        public override void Cargar_datos(DataRow fila)
        {
            Codigo = fila["codigo"].ToString();
            Descripcion = fila["descripcion"].ToString();
            Documento = fila["nroDoc_cliente"].ToString();
            TipoDocumento = fila["tipoDoc_cliente"].ToString();
            FechaInicio = fila["fecha_inicio"].ToString();
            FechaFinProbable = fila["fecha_fin_probable"].ToString();
            FechaFinReal = fila["fecha_fin_real"].ToString();
        }

        public override string SentciaSqlActualizar()
        {
            return "UPDATE ventaProducto (" + Descripcion + ", " + Documento + ", " + TipoDocumento +
                   ", CONVERT(date, '" + FechaInicio + "', 103), CONVERT(date, '" + FechaFinProbable + "', 103), ";
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[5] { "descripcion", "nroDoc_cliente", "tipoDoc_cliente", "fecha_inicio", "fecha_fin_probable"},
                             new string[5] { Descripcion, Documento, TipoDocumento, FechaInicio, FechaFinProbable });
        }
    }
}
