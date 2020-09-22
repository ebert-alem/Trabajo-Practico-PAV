﻿using System;
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
        Producto producto = new Producto();
        public void Alta(string nombre, string denominacion, string descripcion, string fecha_fin_desarrollo)
        {
            Producto producto_nueva = new Producto(nombre, denominacion, descripcion, fecha_fin_desarrollo);
            producto_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return producto.Listar();
        }

        public DataTable ConsultaNombre(string nombre)
        {
            return producto.ListarLike("nombre", nombre);
        }

        public void Baja(int Id)
        {
            producto.Eliminar(Id);
        }

        public Producto Buscar(int id)
        {
            Producto producto_nueva = new Producto();
            producto_nueva.Buscar(id);
            return producto_nueva;
        }

    }
}
