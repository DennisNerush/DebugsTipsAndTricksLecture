using System;
using System.Threading;

namespace DebugTipsAndTricks
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //  Intro();
           





























            var findYossiService = new FindYossiService();

            var yossi = findYossiService.Find();

            if (yossi != null)
            {
                yossi.Assist();
                LaFinaly();
            }
            else
            {
                PooHappens();
            }

            Console.ReadKey();
        }




        private static void PooHappens()
        {
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.WriteLine();
            Console.WriteLine("No Luck :/");
        }


        private static void LaFinaly()
        {
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("That's it Doc :)");
            Console.ReadKey();
        }


        private static void Intro()
        {
            Console.WriteLine("I'm new here. :)");
            Thread.Sleep(1000);
            Console.WriteLine("It's a really cool place!");
            Thread.Sleep(1000);
            Console.WriteLine("But");
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.WriteLine();
            Console.WriteLine("Everybody uses buzz words here.");
            Thread.Sleep(1000);
            Console.WriteLine("CI");
            Thread.Sleep(1000);
            Console.WriteLine("GIT");
            Thread.Sleep(1000);
            Console.WriteLine("Fima");
            Thread.Sleep(2000);
            Console.WriteLine("What's a Fima??? :X");
            Thread.Sleep(2000);
            Console.WriteLine("Rummer has it the this guy Yossi knows EVERYTHING! I'll ask him :)");
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.WriteLine();
            Console.Write("That's Strange");
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.Write("He is not in his office");
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.Write("and this guy Avihu yells at me ");
            Thread.Sleep(700);
            Console.WriteLine(":0 :0 :0");
            DramaticEffect();
            DramaticEffect();
            DramaticEffect();
            Console.WriteLine("I'll find him!");
            Console.ReadKey();
        }

        private static void DramaticEffect()
        {
            Console.Write(".");
            Thread.Sleep(800);
        }
    }
}
