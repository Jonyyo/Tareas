using System;

namespace Par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, a;

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
           
            if (num % 2 == 0)
            {

                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }


        }
    }
}
