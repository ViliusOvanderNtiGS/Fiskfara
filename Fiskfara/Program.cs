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
            //gör en lista med alla opt i och visa bara relevanta opts för frågan. sen ta bort opten som är vald.

            List<string> choices = new List<string>() { "1: Sätt upp skydd", "2: Sätt upp en eld", "3: Hitta mat" };
            List<string> options = new List<string>() { "1", "2", "3" };

            //choices = new List<string>() { "1: Sätt upp skydd", "2: Sätt upp en eld", "3: Hitta mat" };

            int time = 0;
            int shelter = 0; // 1 = tent 2 = hammock
            int heat = 0;
            int hung = 100; //hunger
            int hp = 100;


            while (choices.Count > 0)
            {
                WriteLine("Du är strandsatt på en ö i Karibiska havet.");
                WriteLine("Du ser lite skumma fiskar, men tänker inte mer på det.");
                WriteLine("Du måste förbereda för att överleva natten");
                // string fråga 2
                scenario(@"Vad gör du? Skriv antingen ""1"", ""2"" eller ""3""", choices);

                string svar1 = Console.ReadLine();

                while (!options.Contains(svar1))
                {
                    svar1 = Console.ReadLine();
                    WriteLine("Skriv in ett av alternativen");
                }


                if (svar1 == "1")
                {
                    choices.Remove("1: Sätt upp skydd");
                    options.Remove("1");
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
                    WriteLine(shelter);
                    ReadLine();
                    Clear();
                }
                else if (svar1 == "2")
                {
                    Console.WriteLine("Du gör upp en eld med trä du hittar i närheten. ");
                    choices.Remove("2: Sätt upp en eld");
                    options.Remove("2");
                    time++;
                    heat = heat + 20;
                    ReadLine();
                    Clear();

                }
                else if (svar1 == "3")
                {
                    Console.WriteLine("Du hittar ett par bär buskar som du inte känner igen. ");
                    WriteLine(@"Äter du bären? Skriv 1 eller 2");
                    WriteLine("1: Ja");
                    WriteLine("2: Nej");
                    choices.Remove("3: Hitta mat");
                    options.Remove("3");

                    svar1 = Console.ReadLine();
                    while (svar1 != "1" && svar1 != "2")
                    {
                        svar1 = Console.ReadLine();
                        Console.WriteLine("Skriv in ett av alternativen");
                    }

                    // svar1 = Console.ReadLine();
                    if (svar1 == "1")
                    {
                        Random generator = new Random();
                        int bär = generator.Next(99);

                        if (bär >= 49)
                        {
                            WriteLine("Det gick bra, bären var goda :-)");
                            hung = hung + 15;
                            WriteLine(bär);
                            time++;
                        }
                        else
                        {
                            WriteLine("Det gick inte så bra, och du spyr");
                            hung = hung - 10;
                            hp = hp - 20;
                            time++;
                        }

                    }
                    else if (svar1 == "2")
                    {
                        WriteLine("Du väljer att inte äta bären");
                        hung = hung - 20;
                    }
                    ReadLine();
                    Clear();
                }
            }

            WriteLine("Dag 1 är nu förbi.");
            string sheltVisa = "";
            if (shelter == 1)
            {
                sheltVisa = "ditt tält";
            }
            else if (shelter == 2)
            {
                sheltVisa = "din hammock";
            }
            WriteLine("Du går och lägger dig i " + sheltVisa);
            WriteLine("Hunger: " + hung);
            if (hung <= 10)
            {
                hp = hp - 20;
            }

            WriteLine("Värme: " + heat);    // man kan få tillbaka hp om amn håller sig varm
            if (heat <= 20)
            {
                hp = hp - 20;
            }
            else if (heat >= 37)
            {
                hp = hp + 20;
            }
            WriteLine("Hälsa: " + hp);
            WriteLine(time);
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


        static void scenario(string frågan, List<string> options) // array till att ha så många options jag vill
        {
            Console.WriteLine(frågan);

            foreach (var option in options)
            {
                WriteLine(option);
            }
        }
    }
}
