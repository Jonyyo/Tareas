using System;

namespace Perimetro_y_area_de_poligono_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, lados;
            double apo, tamaLado, angu, area, perimetro, radians;
            Console.WriteLine("Ingrese la opcion deseada\n");
            Console.WriteLine("1. calcular area");
            Console.WriteLine("2. calcular perimetro");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Ingrese la cantidad de lados de su figura");
                lados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tamanio del lado");
                tamaLado = double.Parse(Console.ReadLine());

                
                angu = 360 / (2 * lados);
                perimetro = lados * tamaLado;
                apo = lados/(2* Math.Tan(angu));

                area = (perimetro * apo) / 2;

                Console.WriteLine("El area es " + area);

            }
            else if(option==2)
            {
                Console.WriteLine("Ingrese la cantidad de lados de su figura");
                lados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tamanio del lado");
                tamaLado = double.Parse(Console.ReadLine());
                perimetro = lados * tamaLado;
                Console.WriteLine("El perimetro es " + perimetro);
            }
            Console.ReadKey();


        }
    }
}
