using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class MedsBLL
    {
        public static bool Insertar(Medicinas m)
        {
            var db = new FarmaciaDB();
            bool retorno = false;

            try
            {
                db.Medicina.Add(m);
                db.SaveChanges();

                retorno = true;
            }
            catch(Exception)
            {
                throw;
            }
            return retorno;

        }

        public static void Eliminar (int id)
        {
            var db = new FarmaciaDB();

            var med = (from m in db.Medicina
                       where id == m.idMed
                       select m).FirstOrDefault();
            db.Medicina.Remove(med);
            db.SaveChanges();
        }

        public static Medicinas Buscar(int id)
        {
            var db = new FarmaciaDB();

            return db.Medicina.Find(id);
        }

        public static List<Medicinas> GetLista()
        {
            List<Medicinas> lista = new List<Medicinas>();

            var db = new FarmaciaDB();

            lista = db.Medicina.Where(m => m.idMed == 1).ToList();

            return lista;
        }

        public static List<Medicinas> GetLista(int id)
        {
            List<Medicinas> lista = new List<Medicinas>();

            var db = new FarmaciaDB();

            lista = db.Medicina.Where(m => m.idMed == id).ToList();

            return lista;
        }
    }
}
