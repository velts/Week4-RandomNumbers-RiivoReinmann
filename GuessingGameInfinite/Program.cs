using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            Console.WriteLine("Tere tulemast numbri ära arvamise mängu!");
            

            while (loopActive)
            {
                Console.WriteLine("Sisesta number:");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == cpuNumber)
                {
                    Console.WriteLine("Palju õnne arvasid numbri ära!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Sinu pakutud number oli vale, proovi uuesti");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
