using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            return "UPDATE " + NombreTabla + " SET " + 
                SqlEquals(new string[3] { "descripcion", "nroDoc_cliente", "tipoDoc_cliente" }, new string[3] { Descripcion, Documento, TipoDocumento }) 
                + ", fecha_inicio=CONVERT(date,'" + FechaInicio + "',103), "
                + " fecha_fin_probable=CONVERT(date,'" + FechaFinProbable + "',103) " 
                + " WHERE codigo=" + Codigo;
        }

        //Setea un objeto como finalizado indicando su fecha de finalizacion
        public void Finalizar(int Codigo) {
            string sql = "UPDATE " + NombreTabla + " SET " + "fecha_fin_real=CONVERT(date,'" + DateTime.Now + "',103)" + "WHERE codigo=" + Codigo;
            _BD.Comando(sql);
        }
        
        public override void Eliminar(int Id)
        {
            string sql = "UPDATE " + NombreTabla + " SET " + "activos=0" + "WHERE codigo=" + Id;
            _BD.Comando(sql);
        }


        public override string SentciaSqlCrear()
        {
            string[] Columnas = new string[5] { "descripcion", "nroDoc_cliente", "tipoDoc_cliente", "fecha_inicio", "fecha_fin_probable" };
            string[] Valores = new string[3] { Descripcion, Documento, TipoDocumento };
            return "INSERT INTO " + NombreTabla + "(" + string.Join(", ", Columnas) + ") Values ('"+ Descripcion + "', '"+ Documento + "', ' " + TipoDocumento +  "', "+ "CONVERT(date,'" + FechaInicio + "',103)" + ", CONVERT(date,'" + FechaFinProbable + "',103)" + ")";
        }


    }
}
