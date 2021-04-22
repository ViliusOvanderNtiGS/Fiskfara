using System;
using System.Collections.Generic;

namespace blackjack
{
    class Program
    {



        static void Main(string[] args)
        {
            intro();

            Console.WriteLine(@"Tryck på ""Enter""");
            string svar1 = Console.ReadLine();

            senario1();
            svar1 = Console.ReadLine();
            while (svar1 != "1" || svar1 != "2" || svar1 != "3")
            {
                svar1 = Console.ReadLine();
                Console.WriteLine("Skriv in ett av alternativen");
            }

            int time = 0;
            int shelter = 0; // 1 = tent 2 = hammock
            int heat = 0;
            //int hp = 100;


            svar1 = Console.ReadLine();
            if (svar1 == "1")
            {
                Console.WriteLine("Du sammlar pinnar i en närliggande skog och drivträ från stranden, samt palmblad från marken.");
                Console.WriteLine("Hur vill du att ditt skydd ska se ut.");
                Console.WriteLine("1: Standard tält");
                Console.WriteLine(@"   __ ");
                Console.WriteLine(@"  /  \");
                Console.WriteLine(@" /____\");
                Console.WriteLine();
                Console.WriteLine("2: Hammock");
                Console.WriteLine(@" |\__/|");
                Console.WriteLine(@" |    |");

                while (svar1 == "1" || svar1 == "2")
                {
                    Console.WriteLine("Skriv in alternativen");
                    svar1 = Console.ReadLine();
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

        static void senario1()
        {
            Console.WriteLine("Du är strandsatt på en ö i Karibiska havet.");
            Console.WriteLine("Du ser lite skumma fiskar, men tänker inte mer på det.");
            Console.WriteLine("Du måste förbereda för att överleva natten");
            Console.WriteLine(@"Vad gör du? (Skriv antingen ""1"", ""2"" eller ""3"" )");
            Console.WriteLine("1: Sätt upp skydd");
            Console.WriteLine("2: Sätt upp en eld");
            Console.WriteLine("3: Hitta mat");
        }
    }
}
