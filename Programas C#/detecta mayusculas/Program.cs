using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detecta_mayusculas
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Escriba una letra: ");
            letra = Console.ReadKey().KeyChar;

            if (letra == 'a' || letra=='b' || letra == 'c' || letra == 'd' || letra == 'e'
                || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'i' || letra == 'j'
                || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'ñ'
                || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's'
                || letra == 't' || letra == 'u' || letra == 'v' || letra == 'w' || letra == 'x'
                || letra == 'y' || letra == 'z')
                Console.Write("\nMinuscula");
              else if(letra== 'A' || letra=='B' || letra == 'C' || letra == 'D' || letra == 'E'
                || letra == 'F' || letra == 'G' || letra == 'H' || letra == 'I' || letra == 'J'
                || letra == 'K' || letra == 'L' || letra == 'M' || letra == 'N' || letra == 'Ñ'
                || letra == 'O' || letra == 'P' || letra == 'Q' || letra == 'R' || letra == 'S'
                || letra == 'T' || letra == 'U' || letra == 'V' || letra == 'W' || letra == 'X'
                || letra == 'Y' || letra == 'Z')
                Console.Write("\nMayuscula");


            Console.ReadKey();
        }
    }
}
