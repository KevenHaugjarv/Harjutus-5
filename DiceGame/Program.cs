﻿using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib kumb viskab rohkem
            //mängija kes viskab rohkem on võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja
            int i = 0;
            while (i < 3)
                         
            {
                Random rnd = new Random();
                i++;
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Mängija on võitnud. Palju õnne!");
                    userScore = userScore + 1;
                    

                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on võitnud. Ehk on rohkem õnne järgmine kord");
                    cpuScore = cpuRandom + 1;
                }
                else
                {
                    
                    Console.WriteLine("Viik!");
                    
                }

                

            }
        }
    }
}