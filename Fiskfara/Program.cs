using static System.Console;
using System;
using System.Collections.Generic;

namespace FiskFara
{
    class Program
    {



        static void Main(string[] args)
        {
            intro();

            WriteLine("Du är strandsatt på en ö i Karibiska havet.");
            WriteLine("Du ser lite skumma fiskar, men tänker inte mer på det.");
            WriteLine("Du måste förbereda för att överleva natten");
            string opt1 = "1: Sätt upp skydd";
            string opt2 = "2: Sätt upp en eld";
            string opt3 = "3: Hitta mat";
            //detta är för att senare göra ett system som tar bort frågan efter att amn har tryckt på fågan

            // string fråga 2
            scenario(@"Vad gör du? Skriv antingen ""1"", ""2"" eller ""3""", opt1, opt2, opt3);

            string svar1 = Console.ReadLine();

            while (svar1 != "1" && svar1 != "2" && svar1 != "3")
            {
                svar1 = Console.ReadLine();
                WriteLine("Skriv in ett av alternativen");
            }

            int time = 0;
            int shelter = 0; // 1 = tent 2 = hammock
            int heat = 0;
            //int hp = 100;

            if (svar1 == "1")
            {
                WriteLine("Du sammlar pinnar i en närliggande skog och drivträ från stranden, samt palmblad från marken.");
                WriteLine("Hur vill du att ditt skydd ska se ut.");
                WriteLine();
                WriteLine(@"                   __ ");
                WriteLine(@"1: Standard tält  /  \");
                WriteLine(@"                 /____\");
                WriteLine();
                WriteLine();
                WriteLine(@"2: Hammock |\__/|");
                WriteLine(@"           |    |");
                WriteLine();

                while (svar1 != "1" && svar1 != "2")
                {
                    svar1 = Console.ReadLine();
                    Console.WriteLine("Skriv in ett av alternativen");
                }

                svar1 = Console.ReadLine();
                if (svar1 == "1")
                {

                    Console.WriteLine("Du gör ett Standard tält");
                    time++;
                    shelter = 1;
                    heat = heat + 10;

                }
                else if (svar1 == "2")
                {
                    Console.WriteLine("Du gör en Hammock");
                    time++;
                    shelter = 2;
                    heat = heat + 0;

                }
                Console.WriteLine(shelter);
                Console.ReadLine();
            }
            else if (svar1 == "2")
            {
                Console.WriteLine("Du gör upp en eld med trä du hittar i närheten. ");
                time++;
                heat = heat + 20;

            }
            else if (svar1 == "3")
            {
                Console.WriteLine("Du hittar ett par bär buskar som du inte känner igen. ");

            }



            Console.Clear();

            Console.ReadLine();




        }
        static void intro()
        {
            WriteLine("");
            WriteLine("");
            WriteLine(@"                    ______ _     _     ______              ");
            WriteLine(@"                    |  ___(_)   | |    |  ___|             ");
            WriteLine(@"                    | |_   _ ___| | __ | |_ __ _ _ __ __ _ ");
            WriteLine(@"                    |  _| | / __| |/ / |  _/ _` | '__/ _` |");
            WriteLine(@"                    | |   | \__ \   <  | || (_| | | | (_| |");
            WriteLine(@"                    \_|   |_|___/_|\_\ \_| \__,_|_|  \__,_|");
            WriteLine("");
            WriteLine("                              Kommer du att överleva?");
            WriteLine("");
            WriteLine("");
            WriteLine(@"                          Skriv ""start"" för att starta.");
            WriteLine(@"                       Skriv ""quit"" för att göra motsattsen.");


            int gameScene = 0;

            while (gameScene == 0)
            {
                string svar = Console.ReadLine();
                if (svar == "start")
                {
                    Console.Clear();
                    gameScene++;

                }
                else if (svar == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("lol");
                    gameScene = 999;
                }
                else
                {
                    Console.WriteLine(@"Du måste skriva något antingen ""quit"" eller ""start"".");
                    gameScene = 0;

                }
            }
        }


        static void scenario(string frågan, params string[] options) // array till att ha så många options jag vill
        {
            Console.WriteLine(frågan);

            foreach (var option in options)
            {
                WriteLine(option);
            }
        }
    }
}
