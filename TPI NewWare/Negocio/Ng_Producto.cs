using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Producto
    {
        Producto etapa = new Producto();
        public void Alta(string nombre, string descripcion)
        {
            Producto producto_nueva = new Producto(nombre, denominacion, descripcion, fecha_fin_desarrollo);
            producto_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return etapa.Listar();
        }

        public DataTable ConsultaNombre(string descripcion)
        {
            return etapa.ListarLike("descripcion", descripcion);
        }

        public void Baja(int Id)
        {
            etapa.Eliminar(Id);
        }

        public Producto Buscar(int id)
        {
            Producto producto_nueva = new Etapa();
            producto_nueva.Buscar(id);
            return producto_nueva;
        }

    }
}
