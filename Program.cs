using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA4_PARIMPAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    Console.WriteLine("dame un numero y te dire si es par o impar");
                    int numero = int.Parse(Console.ReadLine());
                    if (numero == 0)
                    {
                        Console.WriteLine("tu numero es par");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("tu numero es impar");
                    }
                    Console.ReadKey();

                  }
        }
    }

