using System;


namespace eleva_a_potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pot, resul;
            Console.WriteLine("Ingrese la base  ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente");
            pot = int.Parse(Console.ReadLine());

            resul = num;

            while(pot>1)
            {
                resul = resul * num;
                pot--;
            }
            Console.WriteLine(resul);





            Console.ReadKey();
        }
    }
}
