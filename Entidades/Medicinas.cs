using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Medicinas
    {
        [Key]
        public int idMed { set; get; }
        public string nombreMed { set; get; }
        public string descripcionMed { set; get; }
        public double precioCompra { set; get; }
        public double precioVenta { set; get; }
    }
}
