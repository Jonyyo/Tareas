using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Descuento_a_clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            int compra;
            double descuento, total;

            Console.WriteLine("Ingrese el monto de su compra");
            compra = Int32.Parse(Console.ReadLine());

            if (compra > 300)
            {
                descuento = compra * 0.20;
                total = compra - descuento;
                Console.WriteLine("Su compra es mayor a 300 y su descuento es: {0} y su total a pagar es: {1} ",descuento, total);
            }
            else
            {

                Console.WriteLine("Su compra es menor a 300, no aplica descuento");

            }

            Console.ReadKey();
        }
    }
}

