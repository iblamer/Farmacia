using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UserID { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int IdTipo { get; set; }

        


    }

}
