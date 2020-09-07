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
        Herramienta herramienta = new Herramienta();
        public void Alta(string nombre, string descripcion)
        {
            Herramienta herramienta_nueva = new Herramienta(nombre, descripcion);
            herramienta_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return herramienta.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return herramienta.ListarLike("nombre", Nombre);
        }

        public void Baja(int Id)
        {
            herramienta.Eliminar(Id);
        }

        public Herramienta Buscar(int id)
        {
            Herramienta herramienta_nueva = new Herramienta();
            herramienta_nueva.Buscar(id);
            return herramienta_nueva;
        }

    }
}