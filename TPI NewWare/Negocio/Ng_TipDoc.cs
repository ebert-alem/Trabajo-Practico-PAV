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
    class Ng_TipDoc
    {
        TipDoc tipDoc = new TipDoc();
        public void Alta(string nombre, string descripcion)
        {
            TipDoc tipDoc_nueva = new TipDoc(nombre, descripcion);
            tipDoc_nueva.Crear();
        }

        public DataTable Consulta()
        {
            return tipDoc.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return tipDoc.ListarLike("nombreTipoDocumento", Nombre);
        }

        public void Baja(int Id)
        {
            tipDoc.Eliminar(Id);
        }

        public TipDoc Buscar(int id)
        {
            TipDoc tipDoc_nueva = new TipDoc();
            tipDoc_nueva.Buscar(id);
            return tipDoc_nueva;
        }

    }
}
