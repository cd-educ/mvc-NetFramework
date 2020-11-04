using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_NetFramework.Models;

namespace mvc_NetFramework.DAOs
{
    public class UsuarioDAO
    {

        public static UsuarioDAO instancia = null;
        public List<Usuario> usuarios = new List<Usuario>();

        private UsuarioDAO() { }

        public static UsuarioDAO getInstancia()
        {

            if (instancia == null)
            {
                instancia = new UsuarioDAO();
                instancia
                    .add(new Usuario(1, "pepito@gmail.com", "calle falsa 123", 170))
                    .add(new Usuario(2, "juan_hernesto@yahoo.com", "azcuenaga 78", 0))
                    .add(new Usuario(3, "admin@admin.com", "admin", 9999));

            }


            return instancia;

        }

        public UsuarioDAO add(Usuario user)
        {
            usuarios.Add(user);
            return this;

        }

        public Usuario getUsuarioById(int id)
        {
            return usuarios.Find(x => x.id == id);
        }

    }

}