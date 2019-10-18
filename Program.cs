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
            Console.WriteLine();

            Console.WriteLine("Please name your first fighter");

            f1.name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The first fighters name is " + f1.name);

            Console.WriteLine();
            Console.WriteLine("Please name your second fighter");

            f2.name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("The second fighters name is " + f2.name);
            
            Console.WriteLine(f1.name + " has " + f1.hp + " hp");
            Console.WriteLine(f2.name + " has " + f2.hp + " hp");

            while(f1.isAlive() == true && f2.isAlive() == true)
            {
                Console.WriteLine("Fight");

                f2.Hurt(f1.Attack());
                f1.Hurt(f2.Attack());

                Console.WriteLine(f1.name + " has " + f1.hp + " hp left");
                Console.WriteLine(f2.name + " has " + f2.hp + " hp left");

                f1.isAlive();
                f2.isAlive();

                Console.ReadLine();
            }
            Console.WriteLine("yay");

            Console.ReadLine();
        }
    }
}
