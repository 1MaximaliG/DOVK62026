using System.Reflection.Metadata.Ecma335;

namespace Verzweigung
{
    internal class Program
    {
        static void Aufgabe1()
        {
            Console.WriteLine("Bitte gibt eine Zahl ein");
            int zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl < 5)
            {
                Console.WriteLine("Die Zahl ist klein als 5");
            }

        }
        static void Aufgabe2()
        {
            Console.WriteLine("Bitte gibt eine Gewicht in Pfund ein");
            int zahl = Convert.ToInt32(Console.ReadLine());

            //Variante 1
            if (zahl < 235)
            {
                Console.WriteLine("nicht zugelassen, du Hungerhacken");
            }
            else if (zahl > 265)
            {
                Console.WriteLine("Nicht zugelassen, du fettes Stück!!");
            }
            else
            {
                Console.WriteLine("Du bist zugelassen, du geile Sau");
            }

            //Varinate 2
            if (zahl < 265)
            {
                if (zahl > 235)
                {
                    Console.WriteLine("Perfekt Brudi");
                }
                else
                {
                    Console.WriteLine("Sind sie zu stark bist du zu schwach, iss mal was!");
                }
            }
            else
            {
                Console.WriteLine("Too fett to Fly");
            }

        }
        static void Aufgabe3()
        {
            Console.WriteLine("Bitte gibt deinen Girokontostand ein");
            double giro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gibt deinen Sparbuchkontostand ein");
            double spar = Convert.ToDouble(Console.ReadLine());
            //Variante 1
            if (giro > 1000)
            {
                Console.WriteLine("Es fallen keine an");
            }
            else if (spar > 1500)
            {
                Console.WriteLine("Es fallen keine an");
            }
            else
            {
                Console.WriteLine("Es fallen gebühren von 0,15€ an");
            }
            //Variante 2
            if (giro > 1000 || spar > 1500)
            {
                Console.WriteLine("Es fallen keine an");
            }
            else
            {
                Console.WriteLine("Es fallen gebühren von 0,15€ an");
            }
        }
        static void Aufgabe4()
        {
            Console.WriteLine("Bitte gibt das Gewicht des Pakets ein");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            if (gewicht <= 10)
            {
                Console.WriteLine("Das macht 3 Euro");
            }
            else
            {
                Console.WriteLine($"Das macht {(gewicht - 10) * 0.25 + 3} Euro");
            }
        }
        static void Aufgabe5()
        {
            Console.WriteLine("Bitte gibt einen Betrag ein:");
            double geld = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In welche Währung soll umgerechnet werden (e = Euro)");
            string eingabe = Console.ReadLine();
            if (eingabe == "e" || eingabe == "E")
            {
                Console.WriteLine($"das sind {geld / 1.95583} Euro");
            }
            else
            {
                Console.WriteLine($"das sind {geld * 1.95583} DM");
            }
        }
        static void Aufgabe6()
        {
            Console.WriteLine("Bitte gibt das Gewicht des Pakets ein");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            if (gewicht <= 10)
            {
                Console.WriteLine("Das macht 3 Euro");
            }
            else if (gewicht >= 20)
            {
                Console.WriteLine($"Das macht {(gewicht - 10) * 0.5 + 3} Euro");
            }
            else
            {
                Console.WriteLine($"Das macht {(gewicht - 10) * 0.25 + 3} Euro");
            }
        }
        static void Aufgabe7()
        {
            Console.WriteLine("Bitte gibt das aktuelle Jahr ein");
            int aktuell = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gibt dein Geburtsjahr ein");
            int geburt = Convert.ToInt32(Console.ReadLine());
            if (aktuell > geburt)
                Console.WriteLine($"Ihr alter ist {aktuell - geburt}");
            else
                Console.WriteLine($"Ihr alter ist {aktuell - geburt + 100}");
        }
        static void Aufgabe8()
        {
            Console.WriteLine("Bitte gibt da Jahr ein");
            int jahr = Convert.ToInt32(Console.ReadLine());
            if (jahr % 400 == 0)
            {
                Console.WriteLine("Das ist ein Schaltjahr");
            }
            else
            {
                if (jahr % 4 == 0)
                {

                    if (jahr % 100 == 0)
                    {
                        Console.WriteLine("Das ist kein Schaltjahr");
                    }
                    else
                    {
                        Console.WriteLine("Das ist ein Schaltjahr");
                    }
                }
                else
                {
                    Console.WriteLine("Das ist kein Schaltjahr");
                }
            }

            //Variante 2
            if (jahr % 400 == 0)
            {
                Console.WriteLine("Das ist ein Schaltjahr");
            }
            else if (jahr % 4 == 0 && jahr % 100 != 0)
            {
                Console.WriteLine("Das ist kein Schaltjahr");
            }
            else
            {
                Console.WriteLine("Das ist kein Schaltjahr");
            }


            //Variante 3 
            if ((jahr % 400 == 0) || (jahr % 4 == 0 && jahr % 100 != 0))
                Console.WriteLine("Das ist ein Schaltjahr");
            else
                Console.WriteLine("Das ist kein Schaltjahr");

        }
        static void Aufgabe9()
        {
            Console.WriteLine("Bitte gib die Anzahl der Portionen ein");
            int portion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib die empfohlene Erhitzungszeit ein");
            double zeit = Convert.ToDouble(Console.ReadLine());

            if (portion == 1)
                Console.WriteLine($"Erhitze deine Mahlzeit für {zeit} minuten");
            if (portion == 2)
                Console.WriteLine($"Erhitze deine Mahlzeit für {zeit * 1.5} minuten");
            if (portion == 3)
                Console.WriteLine($"Erhitze deine Mahlzeit für {zeit * 2} minuten");
            if (portion >= 4)
                Console.WriteLine("Mikrowelle ist zu voll!!");
        }
        static void Aufgabe10()
        {
            Console.WriteLine("Bitte gib die Tankkapazität in Litern ein");
            int kapazität = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib die Benzinanzeige in Prozent ein");
            int prozent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib den Verbrauch in km pro Liter ein");
            int km = Convert.ToInt32(Console.ReadLine());

            if (200 > kapazität * prozent / 100 * km)
                Console.WriteLine("Tanken");
            else
                Console.WriteLine("Weiterfahren!");
        }
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe5();
            //Aufgabe6();
            //Aufgabe7();
            //Aufgabe8();
            //Aufgabe9();
            Aufgabe10();
        }
    }
}
