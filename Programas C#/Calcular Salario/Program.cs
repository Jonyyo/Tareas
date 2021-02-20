using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calcular_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, pago, horasExtras;

            Console.WriteLine("Ingrese el monto de su salario: ");
            horas = Int32.Parse(Console.ReadLine());

            if(horas<40)
            {
                pago = horas * 16;
                Console.WriteLine("Su pago es: {0}", pago);
            }
            else
            {
                horasExtras = horas - 40;
                pago = (40*16)+(horasExtras*20);
                Console.WriteLine("Su pago es: {0}", pago);
            }
            Console.ReadKey();

        }
    }
}
