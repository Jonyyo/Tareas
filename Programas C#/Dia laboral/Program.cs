using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dia_laboral
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;

            Console.Write("Escriba un dia de la semana: ");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "miercoes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("No es un dia laboral");
                    break;
                case "domingo":
                    Console.WriteLine("Dia No es un dia laboral");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
