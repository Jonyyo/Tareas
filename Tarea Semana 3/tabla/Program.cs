using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i +" = " + i*num);
            }
            Console.ReadKey();
        }
    }
}
