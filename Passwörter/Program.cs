using System.Security.Cryptography;

namespace Passwörter
{
    internal class Program
    {
        static void Main(string[] args)
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
            for(int i = 0; i< pw.Length; i++)
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
    }
}
