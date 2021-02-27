using System;



namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fac = 1;

            Console.WriteLine("Deme un numero: ");
            numero = int.Parse(Console.ReadLine());

            while(numero!=0)
            {
                fac = fac * numero;
                numero = numero - 1;
            }

            Console.WriteLine("El factorial es {0} ", fac);
            Console.ReadKey();
        }
    }
}
