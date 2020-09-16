using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Museet3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sätt menyVal som "0"
            string menyVal = "0";
            // while (menyVal != "9")
            while (menyVal != "9")
            {

                Brand.Meny(); // Skriver ut menyn

                string rumVal = (Console.ReadLine()); // Tar emot input från användaren(Val av rum)
                // 
                switch (rumVal)
                {
                    case "0":
                        // Kalla på metoden
                        Brand.StatyRummet();
                        break;

                    case "1":
                        // Kalla på metoden
                        Brand.StoraTavelRummet();
                        break;

                    case "2":
                        // Kalla på metoden
                        Brand.LillaTavelRummet();
                        break;

                    case "3":
                        // Kalla på metoden
                        Brand.ModernKonst();
                        break;

                    case "4":
                        // Kalla på metoden
                        Brand.FilmRummet();
                        break;

                    case "5":
                        // Kalla på metoden
                        Brand.SouvenirButiken();
                        break;

                    case "6":
                        // Tomt rum
                        Console.WriteLine("Du är nu i ett tomt rum");
                        Console.WriteLine();
                        Console.WriteLine("Här kan du göra vad du vill och ingenting");
                        Console.WriteLine();
                        Console.WriteLine("Enter för att komma till menyn");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "7":
                        // Kalla på metoden
                        Brand.MonaLisa();
                        break;

                    case "8":
                        // Kalla på metoden
                        Brand.Picasso();
                        break;

                    case "9":
                        // Kalla på metoden
                        Brand.SkulpturRummet();
                        break;

                    case "q":
                        Console.WriteLine("Tack för ditt besök, välkommen åter!");
                        Console.Clear();
                        Environment.Exit(-1);
                        break;


                    default:
                        Console.WriteLine("Skriv endast in nummer!"); // Felhantering, detta kommer upp om du skriver något annat än en siffra
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            }
        }
    }

    class Brand
    {
        // Variabler till att slumpa branden och att räkna poäng
        public static int slumpTal = 0;
        public static int högstaSlumpTal = 11;
        public static int minstaSlumpTal = 1;
        public static int poäng = 0;

        public static Random slump = new Random();


        // Metod för att slumpa tal
        public static void SlumpaTal()
        {
            slumpTal = slump.Next(minstaSlumpTal, högstaSlumpTal);
        }

        // Metod som finns till om det brinner
        public static void DetBrinner()
        {
            // Det brinner!
            Console.WriteLine("Det brinner! Ta snabbaste vägen ut!");

            // Fråga om användaren vill fortsätta till lobbyn
            Console.WriteLine("Fortsätt till lobbyn! Tryck (j)");
            string val = "";
            // Läs in kortval
            bool röv = true;
            while (röv)
            {
                val = Console.ReadLine();

                // switch kortVal
                switch (val.ToLower())
                {
                    case "j": // case "j": 

                        poäng++;
                        Console.WriteLine($"Du samlade ihop {poäng} poäng!");
                        Console.WriteLine($"Du är nu i lobbyn. Nu kan du fortsätta ditt besök!");
                        Console.WriteLine();
                        Console.WriteLine("Vill du fortsätta ditt besök? j/n");
                        try
                        {
                            // Placera kod här som KAN ge ett oväntat undantag
                            val = Console.ReadLine();
                            if (val == "j")
                            {
                                Console.WriteLine("Fortsätt kika runt på all konst, tryck enter för att fortsätta");
                                Console.ReadLine();
                                röv = false;
                                Console.Clear();
                            }
                            else if (val == "n")
                            {
                                poäng++;
                                Console.WriteLine($"Du lämnade museet. Du samlade ihop {poäng} poäng, Välkommen åter!");
                                Environment.Exit(-1);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            throw;
                        }



                        poäng--;
                        break;

                    //case "n":// case "n": Gör ingenting (loopen kommer sluta köras)
                        //poäng++;
                        //Console.WriteLine("Hoppa ut genom fönstret");
                        //Console.WriteLine($"Du samlade ihop {poäng} poäng, Välkommen åter!");
                        //Environment.Exit(-1);
                        //break;
                        //default:// default: Skriv att alternativet var ogiltigt
                        //Console.WriteLine("Ditt alternativ var inte giltigt!");
                        //Console.ReadLine();
                        //break;
                }
            }
        }

        // Metod för menyn
        public static void Meny()
        {
            Console.WriteLine("Vilket rum vill du gå till?");
            Console.WriteLine();


            Console.WriteLine("[0] Staty Rummet");
            Console.WriteLine("[1] Stora Tavelrummet");
            Console.WriteLine("[2] Lilla Tavelrummet");
            Console.WriteLine("[3] Modern Konst ");
            Console.WriteLine("[4] Filmer");
            Console.WriteLine("[5] Souvenirbutiken");
            Console.WriteLine("[6] - "); // Rummet är tomt
            Console.WriteLine("[7] Mona Lisa");
            Console.WriteLine("[8] Picasso");
            Console.WriteLine("[9] Skulptur-rummet");
            Console.WriteLine("[q] För att avsluta ditt besök");
        }

        // Metoder för respektive rum
        public static void StatyRummet()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i Statyrummet!");
                Console.WriteLine();
                Console.WriteLine("Här finns 10 av de mest kända statyerna i världen!");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void StoraTavelRummet()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else if (slumpTal != 5) // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i stora tavelrummet!");
                Console.WriteLine();
                Console.WriteLine("Här finns 10 av de mest kända tavlorna i världen!");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();

            }
        }

        public static void LillaTavelRummet()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine($"Du är nu i lilla tavelrummet!");
                Console.WriteLine();
                Console.WriteLine("Här finns tavlor från lokala konstnärer");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void ModernKonst()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i rummet med modern konst");
                Console.WriteLine();
                Console.WriteLine("Här finns obegriplig konst");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void FilmRummet()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i filmrummet!");
                Console.WriteLine();
                Console.WriteLine("Här kan du se svartvit film med Charlie Chaplin");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void SouvenirButiken()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i souvenirbutiken!");
                Console.WriteLine();
                Console.WriteLine("Här kan du köpa souvernirer!");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void MonaLisa()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i rummet med den berömda Mona Lisa tavlan");
                Console.WriteLine();
                Console.WriteLine("Här kan du glo på tavlan hur länge du vill");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Picasso()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i Picasso-rummet");
                Console.WriteLine();
                Console.WriteLine("Här finns alla Picassos konstverk");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void SkulpturRummet()
        {
            // Kalla på metoden SlumpaTal
            SlumpaTal();

            if (slumpTal == 5) // Om det slumpade talet är 5 så börjar det brinna
            {
                DetBrinner(); // Kalla på metoden DetBrinner
            }
            else // Annars fortsätter programmet som vanligt
            {
                Console.WriteLine("Slumptalet var: " + slumpTal);

                Console.WriteLine("Du är nu i Skulptur-rummet!");
                Console.WriteLine();
                Console.WriteLine("Här finns Picassos skulpturer");
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att komma till lobbyn");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
