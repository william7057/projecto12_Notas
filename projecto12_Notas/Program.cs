using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto12_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 1;
            int Nota = 0;
            int suma = 0;
            while (x<=8)
            {
                Console.WriteLine("Ingrese la nota 0" + x+" :");
                Nota = int.Parse(Console.ReadLine());// 10 , 15 , 12
                if (Nota >=0 && Nota<=20)
                {
                    suma = suma + Nota;
                }
                else
                {
                    Console.WriteLine("Nota no Valida !!");
                    x = x - 1;
                }
                x = x + 1;
            }
            Console.WriteLine("El promedio es : {0} " + (suma/8.0));
            Console.ReadLine();


        }
    }
}
