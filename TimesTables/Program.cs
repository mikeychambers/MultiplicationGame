using System;
using System.Collections.Generic;

namespace TimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int score;
            string qAmount;
            List<int> wrongAnswers = new List<int>();

            Loop();

            void wa()
            {
                int j = 0;
                int p = 1;

                for (int i = 0; i < wrongAnswers.Count / 2; i++)
                {
                    Console.Clear();
                    Console.Write("{0} x {1} = ", wrongAnswers[j], wrongAnswers[p]);
                    string ans = Console.ReadLine();
                    if (Int32.Parse(ans) == wrongAnswers[j] * wrongAnswers[p])
                    {
                        Console.WriteLine("Correct Answer");
                        j += 2;
                        p += 2;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer");
                        wrongAnswers.Add(wrongAnswers[j]);
                        wrongAnswers.Add(wrongAnswers[p]);
                    }

                    Console.ReadLine();

                }




            }

           void GotWrong()
            {
                Console.WriteLine("Do you want to:\n1) Go again\n2) Retry failed questions ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Loop();
                }

                if (choice == "2")
                {
                    wa();
                }
                else
                {
                    Environment.Exit(0);
                }
            } 

            void Loop()
            {
                Console.Clear();
                Console.WriteLine("How many questions? ");
                qAmount = Console.ReadLine();
                score = 0;
                for (int i = 0; i < Int32.Parse(qAmount); i++)
                {
                    Console.Clear();
                    Questions(rnd.Next(11), rnd.Next(11));
                }
                PlayAgain();

            }

            void PlayAgain()
            {
                Console.Clear();
                Console.WriteLine("You got {0} out of {1} correct", score, qAmount);
                GotWrong();
            }

            void Questions(int x, int y)
            {
                Console.Write("{0} x {1} = ", x.ToString(), y.ToString());
                string answer = Console.ReadLine();

                if (Int32.Parse(answer) == x * y)
                {
                    Console.WriteLine("Correct");
                    score++;
                }

                else
                {
                    Console.WriteLine("Incorrect");
                    wrongAnswers.Add(x);
                    wrongAnswers.Add(y);
                }

                
                Console.ReadLine();
                
            }
            
        }
    }
}
