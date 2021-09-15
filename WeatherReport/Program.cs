using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on
            //kui õues on rohkem kui 35 kraadi, programm kuvab "Boiling hot";
            //kui õues on 30 kuni 35 kraadi, programm kuvab "Hot";
            //kui õues on 20 kuni 30 kraadi, programm kuvab "Fine";
            //kui õues on 10 kuni 20 kraadi, programm kuvab "Okayish";
            //kui õues on 0 kuni 10 kraadi, programm kuvab "Chilly";
            //kui õues on alla 0 kraadi, programm kuvab "Cold".

            Console.WriteLine("Enter the current temperature outside");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (temperature >= 30 && temperature < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Fine");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Okayish");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Chilly");
            }
            else
            {
                Console.WriteLine("Cold");
            }

        }
    }
}
