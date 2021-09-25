using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            Console.WriteLine("Tere tulemast numbri ära arvamis mängu! Sul on 3 katset, kui " +
                "ära ei arva, arvuti võidab. Edu!");
            Console.WriteLine("Sisesta number: ");
            while (i < 3)
            {
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if(userAnswer == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale! Proovimis võimalusi alles: {3 - i}");
                }
                

                
            }
            
        }
    }
}
