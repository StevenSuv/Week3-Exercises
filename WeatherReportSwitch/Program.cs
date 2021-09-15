using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current temperature outside");
            int temperature = Convert.ToInt32(Console.ReadLine());

            switch(temperature)
            {
                case var _ when temperature < 0:
                    Console.WriteLine("Cold");
                    break;
                case var _ when (temperature > 0 && temperature < 10):
                    Console.WriteLine("Chilly");
                    break;
                case var _ when (temperature > 10 && temperature < 20):
                    Console.WriteLine("Okayish");
                    break;
                case var _ when (temperature > 20 && temperature < 30):
                    Console.WriteLine("Fine");
                    break;
                case var _ when (temperature > 30 && temperature < 35):
                    Console.WriteLine("Hot");
                    break;
                default:
                    Console.WriteLine("Boiling hot");
                    break;
            }

        }
    }
}
