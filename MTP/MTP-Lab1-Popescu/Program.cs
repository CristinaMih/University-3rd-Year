using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTP_Lab1_Popescu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti trei numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int suma = a + b + c;
            Console.WriteLine("Suma numerelor este: " + suma);


            Console.ReadKey();
        }
    }
}
