using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            int j = 5;
            for (int i= 1; i <=5; i++)
                suma += Math.Pow(2, i) * factorial(j--);

            Console.WriteLine($"Resultado de la serie {suma}");
            Console.ReadKey();
        }

        public static double factorial(int num)
        {
            double fac = 1;
            for (int i = 1; i <= num; i++)
                fac *= i;

                return fac;
        }
    }
}
