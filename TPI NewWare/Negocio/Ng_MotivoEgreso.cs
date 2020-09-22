using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using TPI_NewWare.Clases;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_MotivoEgreso
    {
        MotivoEgreso motivoEgreso = new MotivoEgreso();
        public void Alta(string nombre)
        {
            MotivoEgreso motivoEgreso_nueva = new MotivoEgreso(nombre);
            motivoEgreso_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return motivoEgreso.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return motivoEgreso.ListarLike("nombre", Nombre);
        }

        public void Baja(int Id)
        {
            motivoEgreso.Eliminar(Id);
        }

        public MotivoEgreso Buscar(int id)
        {
            MotivoEgreso motivoEgreso_nueva = new MotivoEgreso();
            motivoEgreso.Buscar(id);
            return motivoEgreso_nueva;
        }

    }
}
