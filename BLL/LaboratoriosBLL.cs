using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;

namespace BLL
{
    public class LaboratoriosBLL
    {
        public static bool AddLab(Laboratorios lab)
        {
            bool retorno = false;
            try
            {
               var db = new FarmaciaDB();
                db.Laboratorio.Add(lab);
                db.SaveChanges();
                retorno = true;
                
            }
            catch(Exception)
            {
                throw;
            }

            return retorno;
        }

        public static void Borrar(int id)
        {
            var db = new FarmaciaDB();

            Laboratorios lab = (from l in db.Laboratorio
                                where id == l.labId
                                select l).FirstOrDefault();
            db.Laboratorio.Remove(lab);
            db.SaveChanges();
        }

        public static Laboratorios Buscar(int id)
        {
            var db = new FarmaciaDB();

            return db.Laboratorio.Find(id);
        }

        public static List<Laboratorios> GetLista()
        {
            List<Laboratorios> lista = new List<Laboratorios>();

            var db = new FarmaciaDB();

            lista = db.Laboratorio.ToList();

            return lista;
        }

        public static List<Laboratorios> GetLista(int id)
        {
            List<Laboratorios> lista = new List<Laboratorios>();

            var db = new FarmaciaDB();

            lista = db.Laboratorio.Where(l => l.labId == id).ToList();

            return lista;
        }

       

       
    }
}
