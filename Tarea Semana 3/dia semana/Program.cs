using System;

namespace dia_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escriba un numero del 1 al 7: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: 
                        Console.WriteLine("Representa el dia lunes");
                    break;
                case 2:
                    Console.WriteLine("Representa el dia martes");
                    break;
                case 3:
                    Console.WriteLine("Representa el dia miercoles");
                    break;
                case 4:
                    Console.WriteLine("Representa el dia jueves");
                    break;
                case 5:
                    Console.WriteLine("Representa el dia viernes");
                    break;
                case 6:
                    Console.WriteLine("Representa el dia sabado");
                    break;
                case 7:
                    Console.WriteLine("Representa el dia domingo");
                    break;

                    Console.ReadKey();
            }
        }
    }
}
