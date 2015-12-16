using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheOneWhoGotTheMap
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Sure! I know where it is");
            Thread.Sleep(1000);

            Console.WriteLine("I'll give it to you right now");
            Wait();
            Wait();
            Wait();
            
            try
            {
                File.WriteAllText(@"d:\NewFolder\GreatPlaceToPutAMAp\map.txt", "The map :) :) ;)");

                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Here you go. ");
                Thread.Sleep(800);
                Console.WriteLine("Good Luck! ");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("F#$%");
                Thread.Sleep(1000);
                Console.WriteLine("Cant find the...");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Wait();
                Wait();
                Wait();
                Console.Write("  What");
                WaitShort();
                Console.Write(" we");
                WaitShort();
                Console.Write("  have");
                WaitShort();
                Console.Write(" here");
                WaitShort();
                Console.Write(" is");
                WaitShort();
                Console.Write("  fai");
                WaitShort();
                Console.Write("ii");
                WaitShort();
                Console.Write("l");
                WaitShort();
                Console.Write("l");
                WaitShort();
                Console.Write("u");
                WaitShort();
                Console.Write("r");
                WaitShort();
                Console.Write("e");
                WaitShort();
                Console.Write(" to");
                WaitShort();
                Console.Write(" communicate");
                Thread.Sleep(3000);
                return 2;
            }
            return 1;
        }

        private static void WaitShort()
        {
            Thread.Sleep(300);
        }

        private static void Wait()
        {
            Thread.Sleep(800);
            Console.Write(". ");
        }
    }
}
