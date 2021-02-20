using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ano_bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("Ingrese el ano");
            ano = Int32.Parse(Console.ReadLine());

            if ((ano % 4 == 0) && (ano % 100 == 0) && (ano % 400 == 0))
            {
                Console.WriteLine("El ano si es biciesto");
            }
            else
            {
                Console.WriteLine("El ano no es biciesto");
            }
            Console.ReadKey();

        }
    }
}
