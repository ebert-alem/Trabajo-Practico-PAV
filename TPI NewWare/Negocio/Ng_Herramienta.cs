using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_NewWare.Entidades;

namespace TPI_NewWare.Negocio
{
    class Ng_Herramienta
    {
        public void Alta(string nombre, string descripcion)
        {
            Herramienta herramienta = new Herramienta(nombre, descripcion);
            herramienta.Guardar();
        }

        public DataTable Lista()
        {
            Herramienta herramienta = new Herramienta();
            return herramienta.Listar();
        }

        public DataTable Lista_nombre(string Nombre)
        {
            Herramienta herramienta = new Herramienta();
            return herramienta.ListarLike("nombre", Nombre);
        }
    }
}
