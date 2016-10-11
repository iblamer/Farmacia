using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogIn_design
{
    public class Utilidades
    {
        public static int StringToInt(string numero)
        {
            int n = 0;

            int.TryParse(numero, out n);

            return n;
        }
    }
}
