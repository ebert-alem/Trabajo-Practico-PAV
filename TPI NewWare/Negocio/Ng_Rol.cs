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
    class Ng_Rol
    {
        Rol rol = new Rol();
        public void Alta(string nombre, string descripcion)
        {
            Rol rol_nuevo = new Rol(nombre, descripcion);
            rol_nuevo.Crear();
        }

        public DataTable Consulta()
        {
            return rol.Listar();
        }

        public DataTable ConsultaNombre(string Nombre)
        {
            return rol.ListarLike("nombre", Nombre);
        }

        public void Baja(int Id)
        {
            rol.Eliminar(Id);
        }

        public Rol Buscar(int id)
        {
            Rol rol_nuevo = new Rol();
            rol_nuevo.Buscar(id);
            return rol_nuevo;
        }

    }
}