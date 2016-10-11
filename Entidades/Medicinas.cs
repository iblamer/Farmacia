using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Medicinas
    {
        public const double ITBIS = 0.18;
        [Key]
        public int idMed { set; get; }
        public string nombreMed { set; get; }
        public string descripcionMed { set; get; }
        public float precioCompra { set; get; }
        public float precioVenta { set; get; }
        public DateTime FechaVencimiento { set; get; }
        public float precioDetalle { set; get; }
        public int cantidadExistencia { set; get; }

    }
}
