using System;
using System.Collections.Generic;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"                    ______ _     _     ______              ");
            Console.WriteLine(@"                    |  ___(_)   | |    |  ___|             ");
            Console.WriteLine(@"                    | |_   _ ___| | __ | |_ __ _ _ __ __ _ ");
            Console.WriteLine(@"                    |  _| | / __| |/ / |  _/ _` | '__/ _` |");
            Console.WriteLine(@"                    | |   | \__ \   <  | || (_| | | | (_| |");
            Console.WriteLine(@"                    \_|   |_|___/_|\_\ \_| \__,_|_|  \__,_|");
            Console.WriteLine("");
            Console.WriteLine("                              Kommer du att överleva?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"                          Skriv ""start"" för att starta.");
            Console.WriteLine(@"                       Skriv ""quit"" för att göra motsattsen.");


            int gameScene = 0;

            while (gameScene == 0)
            {
                string svar = Console.ReadLine();
                if (svar == "start")
                {
                    Console.Clear();
                    Console.WriteLine("ballt");
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
            string svar1 = Console.ReadLine();
            //int time = 0;


            Console.WriteLine("Du är strandsatt på en ö i Karibiska havet.");
            Console.WriteLine("Du ser lite skumma fiskar, men tänker inte mer på det.");
            Console.WriteLine("Du måste förbereda för att överleva natten");
            Console.WriteLine(@"Vad gör du? (Skriv antingen ""1"", ""2"" eller ""3"" )");
            Console.WriteLine("1: Sätt upp skydd");
            Console.WriteLine("2: Sätt upp en eld");
            Console.WriteLine("3: Hitta mat");

            while (svar1 != "1" || svar1 != "2" || svar1 != "3")
            {
                Console.WriteLine("Skriv in alternativen");
            }

            if (svar1 == "1")
            {
                Console.WriteLine("");
            }


            Console.ReadLine();




        }
    }
}
