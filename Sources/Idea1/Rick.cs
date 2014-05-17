using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace Idea1
{
    public class Rick
    {
        private static void NeverGonna()
        {
            Console.Write("Ne");
            Thread.Sleep(100);
            Console.Write("ver ");
            Thread.Sleep(100);
            Console.Write("Gon");
            Thread.Sleep(100);
            Console.Write("na ");
            Thread.Sleep(100);
        }

        private static void StartSong()
        {
            SoundPlayer play = new SoundPlayer("Roll.wav");
            play.Play();
        }

        /// <summary>
        /// RickRolls the player with a famous verse!
        /// </summary>
        public static void RickRoll()
        {
            try
            {
                StartSong();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("(Silently: )");
            }
            

            NeverGonna();
            Console.Write("Give ");
            Thread.Sleep(400);            
            Console.Write("You ");            
            Thread.Sleep(400);
            Console.Write("U");
            Thread.Sleep(100);
            Console.Write("u");
            Thread.Sleep(100);
            Console.Write("u");
            Thread.Sleep(100);
            Console.WriteLine("p!");

            Thread.Sleep(380);
            NeverGonna();
            Console.Write("Let ");
            Thread.Sleep(450);
            Console.Write("You ");
            Thread.Sleep(400);
            Console.Write("Do-");
            Thread.Sleep(100);
            Console.Write("o-");
            Thread.Sleep(200);
            Console.Write("o-");
            Thread.Sleep(100);
            Console.Write("o-");
            Thread.Sleep(100);
            Console.WriteLine("wn!");

            Thread.Sleep(380);
            NeverGonna();
            Console.Write("R");
            Thread.Sleep(100);
            Console.Write("u-");
            Thread.Sleep(200);
            Console.Write("u");
            Thread.Sleep(100);
            Console.Write("n ");
            Thread.Sleep(100);
            Console.Write("A");
            Thread.Sleep(100);
            Console.Write("ro-");
            Thread.Sleep(120);
            Console.Write("o-");
            Thread.Sleep(120);
            Console.Write("un");
            Thread.Sleep(100);
            Console.WriteLine("d");

            Thread.Sleep(500);
            Console.Write("And ");

            Thread.Sleep(400);
            Console.Write("De");
            Thread.Sleep(100);
            Console.Write("se-");
            Thread.Sleep(150);
            Console.Write("e-");
            Thread.Sleep(150);
            Console.Write("e-");
            Thread.Sleep(150);
            Console.Write("e");
            Thread.Sleep(150);
            Console.Write("rt ");
            Thread.Sleep(250);
            Console.Write("you");
            Thread.Sleep(100);
            Console.WriteLine(".");
            Thread.Sleep(1100);

            NeverGonna();
            Console.Write("Make ");
            Thread.Sleep(400);
            Console.Write("You ");
            Thread.Sleep(400);
            Console.Write("C");
            Thread.Sleep(100);
            Console.Write("r");
            Thread.Sleep(100);
            Console.Write("y");
            Thread.Sleep(100);
            Console.Write("y");
            Thread.Sleep(100);
            Console.WriteLine("y!");

            Thread.Sleep(380);
            NeverGonna();
            Console.Write("S");
            Thread.Sleep(120);
            Console.Write("a");
            Thread.Sleep(160);
            Console.Write("a");
            Thread.Sleep(160);
            Console.Write("a");
            Thread.Sleep(160);
            Console.Write("y ");
            Thread.Sleep(100);
            Console.Write("Go");
            Thread.Sleep(100);
            Console.Write("od");
            Thread.Sleep(100);
            Console.Write("b");
            Thread.Sleep(100);
            Console.Write("i");           
            Thread.Sleep(150);
            Console.Write("i");
            Thread.Sleep(150);
            Console.Write("y");
            Thread.Sleep(150);
            Console.WriteLine("e!");

            Thread.Sleep(380);
            NeverGonna();
            Console.Write("T");
            Thread.Sleep(100);
            Console.Write("e-");
            Thread.Sleep(200);
            Console.Write("e-");
            Thread.Sleep(200);
            Console.Write("e");
            Thread.Sleep(100);
            Console.Write("l ");
            Thread.Sleep(100);
            Console.Write("a ");
            Thread.Sleep(100);
            Console.Write("L");
            Thread.Sleep(100);
            Console.Write("i-");
            Thread.Sleep(170);
            Console.Write("i-");
            Thread.Sleep(170);
            Console.Write("i");
            Thread.Sleep(140);
            Console.WriteLine("e ");

            Thread.Sleep(500);
            Console.Write("And ");
            Thread.Sleep(100);
            Console.Write("H");
            Thread.Sleep(120);
            Console.Write("u");
            Thread.Sleep(250);
            Console.Write("-u");
            Thread.Sleep(250);
            Console.Write("rt ");
            Thread.Sleep(150);
            Console.Write("Y");
            Thread.Sleep(100);
            Console.Write("o");
            Thread.Sleep(100);
            Console.Write("u");
            Thread.Sleep(400);
            Console.Write(" !");
            
        }

        static void Main()
        {
            RickRoll();
            Thread.Sleep(1000);
        }
    }
}
