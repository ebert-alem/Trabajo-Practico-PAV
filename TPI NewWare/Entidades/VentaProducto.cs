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


        public VentaProducto(string CodProducto, string Documento, string TipoDocumento, string FechaVenta, string InicioInstalacion, string FinInstalacion, string LegajoLider)
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
            return "UPDATE ventaProducto (" + CodProducto + ", " + Documento + ", " + TipoDocumento + 
                   ", CONVERT(date, '" + FechaVenta + "', 103), CONVERT(date, '" + InicioInstalacion + "', 103), " +
                   "CONVERT(date, '" + FinInstalacion + "', 103), " + LegajoLider + ")";
        }

        public override string SentciaSqlCrear()
        {
            return SqlInsert(new string[7] { "id_producto", "nroDocumento", "tipoDocumento", "fecha_venta", "fecha_inicio_instalacion", "fecha_fin_instalacion", "legajo_lider" },
                             new string[7] { CodProducto, Documento, TipoDocumento, FechaVenta, InicioInstalacion, FinInstalacion, LegajoLider });
        }
    }
}
