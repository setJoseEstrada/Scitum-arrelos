using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arreglo = new int[5] { 1, 2, 4, 5, 1 };


            var suma = arreglo.Where(x => (x % 2) == 0).Sum();
            var par = arreglo.Where(x => (x % 2) == 0);

            if (suma != 6)
            {
                Console.WriteLine(-1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(suma);
                foreach (var item in par)
                {

                    Console.WriteLine($"Numeros multiplicados del arreglo: [{item}]");
                }
                Console.ReadKey();
            }


        }
    }
}
