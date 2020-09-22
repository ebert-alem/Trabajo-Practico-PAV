using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_NewWare.Entidades;
using System.Data;

namespace TPI_NewWare.Negocio
{
    class Ng_Usuario
    {
        Usuario usu = new Usuario();
        //Valida la existencia de un usuario en BD
        public bool Validar_usuario(string nombre, string pass)
        {   
            //Crea un objeto usuario vacio
            Usuario usuario = new Usuario();
            //Busca al usuario y devuelve troo si lo encuentra
            return usuario.Buscar(nombre, pass);
        }
        
        //Inserta un usuario en BD validando su existencia
        public bool Insertar_usuario(string nombre, string pass)
        {
            //Crea un objeto usuario con los atributos del usuario
            Usuario usuario = new Usuario(nombre, pass);
            //Verifica que el usuario no exista
            if (usuario.Buscar(nombre)) 
            {
                return false;
            }
            //Guarda el objeto en bd
            usuario.Insertar();
            return true;
        }

        public DataTable Consulta()
        {
            return usu.Listar();
        }

    }
}
