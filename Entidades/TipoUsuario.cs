using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class TipoUsuarios
    {
        [Key]
        public int Id { get; set; }
        public string NomTipo { get; set; }        
    }

  

}
