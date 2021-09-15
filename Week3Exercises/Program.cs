using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib sisestada kasutajal tema exami punktid
            //ja otsustab kas kasutaja saab arstiks õppida

            Console.WriteLine("Enter your math exam results");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your chemistry exam results");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your biology exam results");
            int biology = Convert.ToInt32(Console.ReadLine());

            if (math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("You are qualified to start learning doctoring");
            }
            else
            {
                Console.WriteLine("You are not qualified to learn doctoring. Perhaps try next year?");
            }

        }
    }
}
