using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class FarmaciaDB : DbContext
    {
        public FarmaciaDB() : base ("name=ConStr")
        {

        }

        public virtual DbSet<Usuarios> Usuario { get; set; }

        public virtual DbSet<Categorias> Categoria { get; set; }






    }
}
