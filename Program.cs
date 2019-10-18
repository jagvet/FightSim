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
            bool keepPlaying = true;

            while (keepPlaying == true)
            {
                Fighter f1 = new Fighter();
                Fighter f2 = new Fighter();


                Console.WriteLine("Hello and welcome to a fight simulator");
                Console.WriteLine("Here you will be able to make people fight");
                Console.WriteLine();

                Console.WriteLine("Please name your first fighter");
                f1.name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Please name your second fighter");
                f2.name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("The two fighters are " + f1.name + " and " + f2.name);
                Console.WriteLine();

                Console.WriteLine(f1.name + " has " + f1.hp + " hp");
                Console.WriteLine(f2.name + " has " + f2.hp + " hp");
                Console.WriteLine();

                while (f1.isAlive() == true && f2.isAlive() == true)
                {
                    Console.WriteLine("'Fight'");
                    Console.WriteLine();

                    f2.Hurt(f1.Attack());
                    f1.Hurt(f2.Attack());

                    Console.WriteLine(f1.name + " has " + f1.GetHp() + " hp left");
                    Console.WriteLine(f2.name + " has " + f2.GetHp() + " hp left");

                    f1.isAlive();
                    f2.isAlive();

                    Console.ReadLine();
                }

                if (f1.isAlive() == true && f2.isAlive() == false)
                {
                    Console.WriteLine("Congratulations " + f1.name + "! You win!");
                }
                if (f1.isAlive() == false && f2.isAlive() == true)
                {
                    Console.WriteLine("Congratulations " + f2.name + "! You win!");
                }
                if (f1.isAlive() == false && f2.isAlive() == false)
                {
                    Console.WriteLine("They knocked each other out! Nobody win!");
                }

                Console.WriteLine("Do you want to play again?");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                while(answer != "yes" && answer != "no")
                {
                    Console.WriteLine("Yes or no?");
                    answer = Console.ReadLine();
                }
                if(answer == "no")
                {
                    keepPlaying = false;
                }
                Console.Clear();
            }
        }
    }
}
