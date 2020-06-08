using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Funciones.Operaciones op = new Funciones.Operaciones();
            double[] y = new Double[] {10, 11, 12, 13, 14, 20, 30};
            /*y[0] = 12;
            y[1] = 22;
            y[2] = 100;
            y[3] = 20;
            y[4] = 33;*/
            double x = op.Suma(y);
            Console.WriteLine("La suma del array es: {0}", x);
            Console.ReadKey();
        }
    }
}
