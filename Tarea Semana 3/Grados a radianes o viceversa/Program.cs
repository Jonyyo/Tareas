using System;

namespace Grados_a_radianes_o_viceversa
{
    class Program
    {
        static void Main(string[] args)
        {

            int option;
            double grados, radianes;

            Console.WriteLine("Ingrese la opcion deseada\n");
            Console.WriteLine("1. De grados a radianes");
            Console.WriteLine("2. De radianes a grados");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Console.WriteLine("\nIngrese los grados ");
                grados = double.Parse(Console.ReadLine());

                radianes = grados * 0.0174533;

                Console.WriteLine("{0} grados = {1} radianes", grados, radianes);

            }
            else if (option == 2)
            {
                Console.WriteLine("\nIngrese los radianes ");
                radianes = double.Parse(Console.ReadLine());

                grados = radianes * 57.296;

                Console.WriteLine("{0} radianes = {1} grados", radianes, grados);

            }

        }
    }
}
