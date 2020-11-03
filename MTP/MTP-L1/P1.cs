using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTP_Lab1_Popescu
{
    class P1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 5 numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximul este: " + Math.Max(Math.Max(Math.Max(Math.Max(a,b),c),d), e));

            Console.ReadKey();



        }
    }
}
