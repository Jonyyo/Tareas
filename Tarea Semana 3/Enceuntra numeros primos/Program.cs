using System;

namespace Enceuntra_numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
        
            for (int j = 2; j <= 1000; j++)
            {
                int a = 0;
                for (int i = 1; i <= 1000; i++)
            {
                if (j % i == 0)
                {
                        a++;
                }
                    
            }
                if (a == 2)
                {
                    Console.WriteLine(j);
                }

            }
           


           
            Console.ReadKey();




        }
    }
}
