using System;
using System.IO;

namespace Flight_Planning_NEA
{
    class Program
    {
        static void Main(string[] args)
        {
            string AirportData;
            AirportData = File.ReadAllText("Airports.txt");
            Console.WriteLine(AirportData);
        }
    }
}

