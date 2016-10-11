using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Laboratorios
    {
        [Key]
        public int labId { set; get; }

        public string labName { set; get; }
    }
}
