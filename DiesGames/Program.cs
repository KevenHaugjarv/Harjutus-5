using System;

namespace DiesGames
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti ja kasutaja
            // mõlemad mängijad viskavad täringuid;
            // programm kontrollib kumb mängija viskas rohkem
            // mängija kes viskab rohkem ongi võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);
            int cpuScore = 0;
            int userScore = 0;
            Console.WriteLine($"arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

            if (cpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja võit. Palju õnne");
                userScore = userScore + 1;
            }
            else if (cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti võit. Järgmine kord läheb ehk paremini");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik.");

            }

        }
    }
}
