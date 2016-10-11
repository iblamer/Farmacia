using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class TiposBLL
    {
        public static bool Insertar(TipoUsuarios tipo)
        {
            bool retorno = false;

            try
            {
                var db = new FarmaciaDB();

                db.TipoUsuario.Add(tipo);
                db.SaveChanges();
                retorno = true;
            }
            catch(Exception)
            {
                throw;
            }
            return retorno;
        }

        public static void Eliminar(int id)
        {
            var db = new FarmaciaDB();

            var tipo = (from t in db.TipoUsuario
                        where id == t.Id
                        select t).FirstOrDefault();
            db.TipoUsuario.Remove(tipo);
            db.SaveChanges();
        }

        public static TipoUsuarios Buscar(int id)
        {
            var db = new FarmaciaDB();

            return db.TipoUsuario.Find(id);
        }

        public static List<TipoUsuarios> GetList(int tipoId)
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new FarmaciaDB();

            lista = db.TipoUsuario.Where(u => u.Id == tipoId).ToList();

            return lista;
        }

        public static List<TipoUsuarios> GetList()
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new FarmaciaDB();

            lista = db.TipoUsuario.ToList();

            return lista;
        }

    }

   
}
