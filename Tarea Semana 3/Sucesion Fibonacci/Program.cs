using System;

namespace Sucesion_Fibonacci
{
    class Program
    {
        static bool esFibonacci(int numero)
        {
            int pre = 0, pos = 1, suma;
            bool bandera = false;

            while (pre <= numero)
            {
                if (pre == numero)
                    bandera = true;

                suma = pre + pos;
                pre = pos;
                pos = suma;
            }
            return bandera;
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Deme numero: ");
            numero = int.Parse(Console.ReadLine());

            if (esFibonacci(numero))
                Console.WriteLine("El numero pertenece a la serie Fibonacci");
            else
                Console.WriteLine("El numero no pertenece a la serie Fibonacci");

            Console.ReadKey();
        }
    }
}
