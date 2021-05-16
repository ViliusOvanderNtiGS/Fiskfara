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

            List<string> choices = new List<string>() { "1: Sätt upp skydd", "2: Sätt upp en eld", "3: Hitta mat" };// det som man gör
            List<string> options = new List<string>() { "1", "2", "3" }; //det som man skriver

            //choices = new List<string>() { "1: Sätt upp skydd", "2: Sätt upp en eld", "3: Hitta mat" };

            int time = 0;
            int shelter = 0; // 1 = tent 2 = hammock
            int heat = 0;
            int hung = 100; //hunger
            int hp = 100;
            int dagNum = 0;

            while (choices.Count > 0)
            {
                WriteLine("Du är strandsatt på en ö i Karibiska havet.");
                WriteLine("Du ser lite skumma fiskar, men tänker inte mer på det.");
                WriteLine("Du måste förbereda för att överleva natten");

                scenario(@"Vad gör du? Skriv antingen ""1"", ""2"" eller ""3""", choices);

                string svar1 = Console.ReadLine();

                while (!options.Contains(svar1))    // detta gör så att man bara kan skriva de svar man har
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

                    svar1 = Console.ReadLine();
                    while (svar1 != "1" && svar1 != "2")
                    {
                        svar1 = Console.ReadLine();
                        Console.WriteLine("Skriv in ett av alternativen");
                    }

                    if (svar1 == "1")
                    {

                        Console.WriteLine("Du gör ett Standard tält");
                        shelter = 1;
                        heat = heat + 10;
                        time++;

                    }
                    else if (svar1 == "2")
                    {
                        Console.WriteLine("Du gör en Hammock");
                        shelter = 2;
                        heat = heat + 0;
                        time++;

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
                    heat = heat + 20;
                    ReadLine();
                    time++;
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
                        time++;
                    }
                    ReadLine();
                    Clear();
                }
            }


            natt(shelter, hung, hp, heat, time, dagNum);


            //-------------------dag 2---------------------------------------------------------------------------------------------------------------\\



            choices.Add("1: Sitt lungt");
            choices.Add("2: Ta en pinne");
            choices.Add("3: Sök skydd");
            options.Add("1");
            options.Add("2");
            options.Add("3");

            WriteLine("Du vaknar av soljuset.");
            WriteLine("De skumma fiskarna är ännu skummare och har nu växt ben.");
            WriteLine("De påbörjar sin vandring mot dig med en hotfull fisk-blick.");
            scenario(@"Vad gör du? Skriv antingen ""1"", ""2"" eller ""3""", choices);
            time = 0;

            while (time < 3)
            {


                string svar1 = Console.ReadLine();

                while (!options.Contains(svar1))
                {
                    svar1 = Console.ReadLine();
                    WriteLine("Skriv in ett av alternativen");
                }

                Random generator = new Random();
                int fiskattack = generator.Next(1, 100);

                if (svar1 == "1")
                {
                    WriteLine("Du sitte lungt.");
                    WriteLine("Fiskarna börjar springa mot dig.");
                    WriteLine("Du blir nertacklad av dem från alla håll.");
                    WriteLine("Du skakar undan dom och springer ifrån dem.");
                    WriteLine("De skadar dig rijält");
                    hp = hp - 50;
                    ReadLine();
                }
                else if (svar1 == "2")
                {
                    WriteLine("Du tar en pinne och viftar mot fiskarnas riktning.");
                    WriteLine("Du träffar en fisk och den flyger bort några meter bort.");
                    WriteLine("Du träffar några fler och de börjar dra sig tillbaka mot vattnet");
                    if (fiskattack >= 49)
                    {
                        WriteLine("Du strider tappert och kommer undan oskadd.");
                    }
                    else
                    {
                        WriteLine("Du slogs väl men tar lite skada under striden.");
                        hp = hp - 10;
                    }
                    ReadLine();
                }
                else if (svar1 == "3")
                {
                    string shelterS = "";
                    if (shelter == 1)
                    {
                        shelterS = "ditt tält";
                    }
                    else if (shelter == 2)
                    {
                        shelterS = "din hammock";
                    }

                    WriteLine("Du springer mot " + shelterS + " för att ta skydd.");
                    if (shelter == 1)
                    {
                        WriteLine("Fiskarana springer mot tältet.");
                        WriteLine("De flockas vid öppningen.");
                        WriteLine("Du ligger på rygg och sparkar bort dem.");
                        WriteLine("Efter en stund så slutar de deras attak.");
                        WriteLine("Du tog en del skada från detta.");
                        hp = hp - 30;
                        ReadLine();

                    }
                    else if (shelter == 2)
                    {
                        WriteLine("Fiskarna kan inte ta sig upp till dig.");
                        WriteLine("Du hör schattrandet av deras tänder.");
                        WriteLine("Efter en stund så slutar schattrandet och fiskarna drar sig tillbaka.");
                        ReadLine();
                    }


                }
            }

            while (true) // samma sak som dag 1 fast med 4 alternativ och olika options
            {

            }


        }
        static void intro() // detta är intro saken till spelet. den visar titlen och man måste skriva start.
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



            int gameScene = 0;

            while (gameScene == 0)
            {
                string svar = Console.ReadLine();
                if (svar == "start")
                {
                    Console.Clear();
                    gameScene++;

                }
                else
                {
                    Console.WriteLine(@"Du måste skriva något antingen ""quit"" eller ""start"".");
                    gameScene = 0;

                }
            }
        }


        static void scenario(string frågan, List<string> options) //  detta gör så att jag kan ha så många options jag vill tilll ett scenario
                                                                  //  genom listor som är skrivna i program
        {
            Console.WriteLine(frågan);

            foreach (var option in options)
            {
                WriteLine(option);
            }
        }

        static void natt(int shelter, int hung, int hp, int heat, int time, int dagNum) // detta visar alla stats i spelet och säger vilken dag som är förbi
        {
            dagNum++;
            WriteLine("Dag " + dagNum + " är nu förbi.");
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
            // WriteLine(time);
            ReadLine();
            Clear();
        }

        // jag tänkte göra en metod där det står att man har dött // varje while loop ska läggas till med om hp != 0
    }
}
