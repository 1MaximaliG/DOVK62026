using System.Security.Cryptography;

namespace Passwörter
{
    internal class Program
    {
        static void Aufgabe1()
        {
            char[] pw = "dubidubidu".ToCharArray();
            /* Erste Idee: Farbe der schrift so ändern, 
               dass die Buchstaben nicht mehr lesbar sind */
            //Console.Write("Passwort eingeben -> ");
            //char[] eingabe = new char[10];
            //Console.ForegroundColor = ConsoleColor.Black;
            //for(int i = 0; i< eingabe.Length; i++)
            //{
            //    eingabe[i] = Console.ReadKey().KeyChar;

            //}
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(eingabe);


            /* Zweite Idee: Console jedesmal komplett leeren,
               wenn eine Eingabe getätigt wurde */
            char[] eingabe = new char[10];

            for (int i = 0; i < eingabe.Length; i++)
            {
                Console.Write("Passwort eingeben -> ");
                eingabe[i] = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            Console.WriteLine(eingabe);

            /* Können wir Sternchen anzeigen lassen für jeden 
               Buchstaben den wir schon eingegeben haben? */
            //char[] eingabe = new char[10];

            //for (int i = 0; i < eingabe.Length; i++)
            //{
            //    Console.Write("Passwort eingeben -> ");
            //    for(int x = 0; x < i; x++)
            //    {
            //        Console.Write('*');
            //    }
            //    eingabe[i] = Console.ReadKey().KeyChar;
            //    Console.Clear();
            //}
            //Console.WriteLine(eingabe);
            bool hatFehler = false;
            for (int i = 0; i < pw.Length; i++)
            {
                if (pw[i] != eingabe[i])
                {
                    hatFehler = true;
                    break;//bricht die schleife ab //muss nich gemacht werden
                }

            }
            if (hatFehler)
            {
                Console.WriteLine("Zugang verweigert");
            }
            else
            {
                Console.WriteLine("Zugang gewährt");
            }
        }
        static void Aufgabe2()
        {
            Random randy = new Random();
            int länge = randy.Next(8, 25);
            char[] pw = new char[länge];
            for (int i = 0; i < länge; i++)
            {
                pw[i] = (char)randy.Next(33, 127);
            }
            Console.WriteLine(pw);
        }
        static void Aufgabe3()
        {
            bool weiter = true;
            do
            {
                char[] klein = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                char[] groß = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();
                char[] number = "1234567890".ToCharArray();


                Random randy = new Random();
                int länge = randy.Next(8, 25);
                char[] pw = new char[länge];
                for (int i = 0; i < länge; i++)
                {
                    pw[i] = (char)randy.Next(33, 127);
                }
                Console.WriteLine(pw);
                //Zählvariablen
                //int A_klein = 0;
                int A_groß = 0;
                int A_sonder = 0;
                int A_Zahl = 0;
                //Überprüfen jedes buchstabens im Passwort
                for (int i = 0; i < pw.Length; i++)
                {
                    if (groß.Contains(pw[i]))//ist das ein Großbuchstabe?
                    {
                        A_groß++;
                    }
                    else if (number.Contains(pw[i]))//ist das eine Zahl?
                    {
                        A_Zahl++;
                    }
                    else if (!klein.Contains(pw[i]))//ist das KEIN kleiner Buchstabe
                    {
                        A_sonder++;
                    }
                }
                if (pw.Length >= 8 && A_Zahl >= 2 && A_sonder >= 1 && A_groß >= 3)
                {
                    Console.WriteLine("Passwort ist Gut");
                }
                else
                {
                    Console.WriteLine("Passwort ist schlecht");
                }

                Console.WriteLine("Möchten sie ein weiteres Passwort generieren?");
                char eingabe = Console.ReadKey().KeyChar;
                if (eingabe == 'j' || eingabe == 'J')
                {
                    weiter = true;
                }
                else
                {
                    weiter = false;
                }
            } while (weiter);
        }


        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            bool weiter = true;
            do
            {
                char[] klein = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                char[] groß = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();
                char[] number = "1234567890".ToCharArray();


                Random randy = new Random();
                int länge = randy.Next(8, 25);
                char[] pw = new char[länge];
                for (int i = 0; i < länge; i++)
                {
                    pw[i] = (char)randy.Next(33, 127);
                }
                Console.WriteLine(pw);
                //Zählvariablen
                //int A_klein = 0;
                int A_groß = 0;
                int A_sonder = 0;
                int A_Zahl = 0;
                //Überprüfen jedes buchstabens im Passwort
                for (int i = 0; i < pw.Length; i++)
                {
                    if (groß.Contains(pw[i]))//ist das ein Großbuchstabe?
                    {
                        A_groß++;
                    }
                    else if (number.Contains(pw[i]))//ist das eine Zahl?
                    {
                        A_Zahl++;
                    }
                    else if (!klein.Contains(pw[i]))//ist das KEIN kleiner Buchstabe
                    {
                        A_sonder++;
                    }
                }
                if (pw.Length >= 8 && A_Zahl >= 2 && A_sonder >= 1 && A_groß >= 3)
                {
                    Console.WriteLine("Passwort ist Gut");
                }
                else
                {
                    Console.WriteLine("Passwort ist schlecht");
                }

                Console.WriteLine("Möchten sie ein weiteres Passwort generieren?");
                char eingabe = Console.ReadKey().KeyChar;
                if(eingabe == 'j' || eingabe == 'J')
                {
                    weiter = true;
                }
                else
                {
                    weiter = false;
                }
            } while (weiter);
        }
    }
}
