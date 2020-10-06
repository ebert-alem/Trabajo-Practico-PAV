using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_NewWare.Entidades
{
    class VentaProducto : ClaseBase
    {
        protected override string NombreTabla => "VENTAPRODUCTO";

        public string CodProducto { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string FechaVenta { get; set; }
        public string InicioInstalacion { get; set; }
        public string FinInstalacion { get; set; }
        public string LegajoLider { get; set; }


        public VentaProducto()
            {

            }


        public VentaProducto(string CodProducto, string Documento, string TipoDocumento, string FechaVenta, string LegajoLider)
        {
            this.CodProducto = CodProducto;
            this.Documento = Documento;
            this.TipoDocumento = TipoDocumento;
            this.FechaVenta = FechaVenta;
            //this.InicioInstalacion = InicioInstalacion;
            //this.FinInstalacion = FinInstalacion;
            this.LegajoLider = LegajoLider;
            
        }

        public VentaProducto(string CodProducto, string Documento, string TipoDocumento, string FechaVenta, string LegajoLider, string InicioInstalacion, string FinInstalacion)
        {
            this.CodProducto = CodProducto;
            this.Documento = Documento;
            this.TipoDocumento = TipoDocumento;
            this.FechaVenta = FechaVenta;
            this.InicioInstalacion = InicioInstalacion;
            this.FinInstalacion = FinInstalacion;
            this.LegajoLider = LegajoLider;

        }

        public override void Cargar_datos(DataRow fila)
        {
            CodProducto = fila["id_producto"].ToString();
            Documento = fila["nroDocumento"].ToString();
            TipoDocumento = fila["tipoDocumento"].ToString();
            FechaVenta = fila["fecha_venta"].ToString();
            InicioInstalacion = fila["fecha_inicio_instalacion"].ToString();
            FinInstalacion = fila["fecha_fin_instalacion"].ToString();
            LegajoLider = fila["legajo_lider"].ToString();
        }

        public override string SentciaSqlActualizar()
        {

            if (FinInstalacion == "")
            {
                return "UPDATE ventaProducto SET fecha_inicio_instalacion = CONVERT(date, '" + InicioInstalacion + "', 103) " +
                   "WHERE id_producto = " + CodProducto + "AND nroDocumento = " + Documento + "AND tipoDocumento = " + TipoDocumento;
            }
            else
            {
                return "UPDATE ventaProducto SET fecha_fin_instalacion = CONVERT(date, '" + FinInstalacion + "', 103) " +
                   "WHERE id_producto = " + CodProducto + "AND nroDocumento = " + Documento + "AND tipoDocumento = " + TipoDocumento;
            }

            
            //Armamos la cadena de condiciones...
            //string condicion = SqlEqualsUpdate(new string[3] { "id_producto", " nroDocumento", "tipoDocumento" }, new string[3] { Convert.ToString(CodProducto), Convert.ToString(Documento), Convert.ToString(TipoDocumento)});

            //return SqlUpdateCondicionNew(new string[2] {"fecha_inicio_instalacion", "fecha_fin_instalacion" }, new string[2] { InicioInstalacion, FinInstalacion }, condicion);
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[5] { "id_producto", "nroDocumento", "tipoDocumento", "fecha_venta", "legajo_lider" },
                             new string[5] { CodProducto, Documento, TipoDocumento, FechaVenta, LegajoLider });
        }



    }
}
