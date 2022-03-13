using System;

namespace ORoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast"
            //muul juhul konsoolis kuvatakse "vale kasutajatunnus või salasõna. Provi uuesti!"

            //OR (või) ||(pipes)

            // e. kui üks aksutaja esitatud andmedtest on õige siis on kõik õige

            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
