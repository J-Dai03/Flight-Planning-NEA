using System;
using System.IO;

namespace Flight_Planning_NEA
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------
            //--                   --
            //--Load data from file--
            //--Begin              --
            //--                   --
            //-----------------------

            //Load text file
            string AirportDataFile;
            AirportDataFile = File.ReadAllText("Airports.txt");
            Console.WriteLine(AirportDataFile);
            NewLine();

            //Divide up text file
            string[] AirportDataLines = AirportDataFile.Split(System.Environment.NewLine);
            int Lines = AirportDataLines.Length;
            Console.WriteLine("Number of airports: " + Convert.ToString(Lines));
            NewLine();

            //Declare array references
            string[] PortCode, PortName;
            int[] DistanceFromLPL, DistanceFromBOH;

            //Create new arrays and connect references
            PortCode = new string[Lines];
            PortName = new string[Lines];
            DistanceFromLPL = new int[Lines];
            DistanceFromBOH = new int[Lines];

            //Put data into arrays
            for (int i = 0; i < (Lines - 1); i++)
            {
                string[] Fields = AirportDataLines[i].Split(",");
                for (int x = 0; x < 4; x++)
                {
                    Console.WriteLine(Fields[x]);
                }
                PortCode[i] = Fields[0];
                PortName[i] = Fields[1];
                DistanceFromLPL[i] = Convert.ToInt32(Fields[2]);
                DistanceFromBOH[i] = Convert.ToInt32(Fields[3]);
            }

            //-----------------------
            //--                   --
            //--Load data from file--
            //--End              --
            //--                   --
            //-----------------------




        }

        static void Menu()
        {

            bool ProgramRunning = True, EntryValid = False;
            string UKport, OVSport;
            string option = "";

            do {
                Console.WriteLine("1 - ?????????");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        //Enter Port Details subroutine
                        break;
                    case "2":
                        Console.WriteLine("Enter flight details selected");
                        break;

                    case "3":
                        Console.WriteLine("Enter price plan and calculate profit selected");
                        break;

                    case "4":
                        Console.WriteLine("Clear data");
                        break;

                    case "5":
                        Console.WriteLine("Quitting");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Try again");
                        break;
                }






            } while (option != "5");
        }

        static void NewLine()
        {
            Console.WriteLine("");
        }
        static void NewLine(int Lines)
        {
            for (int x = 0; x < Lines; x++)
            {
                Console.WriteLine("");
            }
        }
    }
}