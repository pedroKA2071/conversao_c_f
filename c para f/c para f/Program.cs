using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_para_f
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c, f;

            Console.WriteLine("escreva o valor de celsius: ");

            c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            f = (c * 9 / 5) + 32;

            Console.WriteLine("seu Fahrenheit " +  f);



            Console.ReadKey();

           







        }
    }
}
