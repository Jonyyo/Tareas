using System;


namespace Promedio_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] Arreglo = new int[4];
            int i, promedio = 0, n, mayor =Arreglo[0], menor=Arreglo[0];
            string cadena;

            Console.WriteLine("Escriba la cantidad de edades a ingresar");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba las edades");
            for (i = 0; i < n; i++)
            {
                cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena);
                
            }
           

            for (i = 0; i < n; i++)
            {
                promedio = promedio + Arreglo[i];
                
            }

            for (i = 0; i < n; i++)
            {
                 if (Arreglo[i] < menor)

                {
                    menor = Arreglo[i];
                }
                if (Arreglo[i] > mayor)
                {
                    mayor = Arreglo[i];
                }
               


            }
            promedio = promedio  / n;

            Console.WriteLine("\nEl promedio es: "+promedio);
            Console.WriteLine("\nEl mayor es : " + mayor);
            Console.WriteLine("\nEl menor es: " + menor);


            Console.ReadKey();
        }
    }
}
