using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
   public class UsuariosBLL
    {
        public static bool Insertar(Usuarios usuario)
        {
            bool retorno = false;
            try
            {
                FarmaciaDB db = new FarmaciaDB();

                db.Usuario.Add(usuario);
                db.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                throw;  
            }
            return retorno;
        }

       public static  Usuarios Buscar (int id)
        {
            var db = new FarmaciaDB();

            return db.Usuario.Find(id);
        }

        public static void Remove(int id)
        {
            var db = new FarmaciaDB();

            Usuarios u = (from user in db.Usuario
                          where id == user.UserID select user).FirstOrDefault();
            db.Usuario.Remove(u);
            db.SaveChanges();
        }

        public static void Update(int id, Usuarios usuario)
        {
            var db = new FarmaciaDB();

            Usuarios user = db.Usuario.Find(id);


            user.Nombre = usuario.Nombre;
            user.Clave = usuario.Clave;

            db.SaveChanges();
        }

    }
}
