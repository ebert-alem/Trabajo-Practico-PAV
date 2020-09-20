
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Etapa
    {
        Etapa etapa = new Etapa();
        public void Alta(string descripcion)
        {
            Etapa etapa_nueva = new Etapa(descripcion);
            etapa_nueva.Crear();
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

        public Etapa Buscar(int id)
        {
            Etapa etapa_nueva = new Etapa();
            etapa_nueva.Buscar(id);
            return etapa_nueva;
        }
    }
}
