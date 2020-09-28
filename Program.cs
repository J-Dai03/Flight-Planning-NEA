using System;
using System.IO;

namespace Flight_Planning_NEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load text file
            string AirportDataFile;
            AirportDataFile = File.ReadAllText("Airports.txt");
            Console.WriteLine(AirportDataFile);
            
            //Divide up text file
            string[] AirportDataLines = AirportDataFile.Split("/n");
            Console.WriteLine(AirportDataLines);

            int Lines = AirportDataLines.length;
            Console.WriteLine("Number of airports: " + Convert.ToString(Lines));

            //Put data into arrays
            PortCode = new string[Lines];
            PortName = new string[Lines];
            DistanceFromLPL = new int[Lines];
            DistanceFromBOH = new int[Lines];

            for (int i = 0; i < Lines; i++)
            {
                string[] Fields = AirportDataLines[i].Split(",");
                PortCode[i] = Fields[0];
                PortName[i] = Fields[1];
                DistanceFromLPL[i] = Convert.ToInt32(Fields[2]);
                DistanceFromBOH[i] = Convert.ToInt32(Fields[3]);
            }
            Console.WriteLine(PortCode);
            Console.WriteLine(PortName);
            Console.WriteLine(Convert.ToString(DistanceFromLPL));
            Console.WriteLine(Convert.ToString(DistanceFromBOH));
        }
    }
}