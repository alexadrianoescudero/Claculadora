using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claculadora.Model
{
    class Operaciones
    {
        public int Suma(string[] num)
        {
            int sumador = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (!string.IsNullOrEmpty(num[i]))
                    sumador = sumador + Convert.ToInt32(num[i]);
            }
            return sumador;
        }
        public int Resta()
        {

            return 0;
        }
    }
}
