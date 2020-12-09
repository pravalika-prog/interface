using System;

namespace Rockpaperscissor
{
    class Program
    {
        static void Main(string[] args, string scissor, string paper, string rock)
        {
           
            string inputplayer,  inputcpu;

            int randomint;
            bool playagain = true;
            while (playagain)
            {

                int scoreplayer = 0;
                int scorecpu = 0;
                while (scoreplayer < 3 && scorecpu < 3)
                {
                    Console.WriteLine("choose rock,paper,scissor");
                    inputplayer = Console.ReadLine();
                    Random rd = new Random();
                    randomint = rd.Next(1, 4);
                    switch (randomint)
                    {

                        case 1:
                            inputcpu = "rock";
                            Console.WriteLine("computer chooses rock");
                            if (inputplayer == rock)
                            {
                                Console.WriteLine("draw");
                            }
                            else if (inputplayer == paper)
                            {
                                Console.WriteLine(" computer wins");
                                scorecpu++;
                            }
                            else if (inputplayer == scissor)
                            {
                                Console.WriteLine("player wins");
                                scoreplayer++;
                            }
                            break;
                        case 2:
                            inputcpu = "paper";
                            Console.WriteLine("computer chooses paper");
                            if (inputplayer == paper)
                            {
                                Console.WriteLine("draw");
                            }
                            else if
                                 (inputplayer == rock)
                            {
                                Console.WriteLine(" computer wins");
                                scorecpu++;
                            }
                            else if (inputplayer == scissor)
                            {
                                Console.WriteLine("player wins");
                                scoreplayer++;
                            }
                            break;
                        case 3:
                            inputcpu = "scissor";
                            Console.WriteLine("computer chooses scissor");
                            if (inputplayer == scissor)
                            {
                                Console.WriteLine("draw");
                            }
                            else if
                               (inputplayer == rock)
                            {
                                Console.WriteLine(" computer wins");
                                scorecpu++;
                            }
                            else if (inputplayer == scissor)
                            {
                                Console.WriteLine("player wins");
                                scoreplayer++;
                            }
                            break;

                        default:
                            Console.WriteLine("invalid entry");
                            break;

                    }
                    Console.WriteLine("display:{0},{1}", scoreplayer, scorecpu);
                }
                if (scoreplayer == 3)
                {
                    Console.WriteLine("player wins");
                }
                else if
                    (scorecpu == 3)
                {

                    Console.WriteLine("cpu wins");
                }
                Console.WriteLine("do you want to play again? y/n");
                string loop = Console.ReadLine();
                if (loop == " y")
                {
                    playagain = true;
                }
                else if (loop == "n")
                {
                    playagain = false;
                }
            }
        }
    }
}



