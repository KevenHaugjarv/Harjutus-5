using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //i will not skateboard in the halls.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. i will not skateboard in the hall.".ToUpper());

            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
