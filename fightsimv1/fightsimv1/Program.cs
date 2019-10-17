using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fightsimv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();

            Console.WriteLine("Hello and welcome to a fight simulator");
            Console.WriteLine("Here you will be able to make people figt");

            Console.WriteLine("Please name your first fighter");
            Console.WriteLine();

            f1.name = Console.ReadLine();

            Console.WriteLine(f1.name);

            Console.ReadLine();
        }
    }
}
