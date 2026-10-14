namespace Methoden
{
    internal class Program
    {
        static double Addieren(double erste, double zweite)
        {
            double ergebnis;
            ergebnis = erste + zweite;

            return ergebnis;
        }
        static double Subtrahieren(double erste, double zweite)
        {
            double ergebnis;
            ergebnis = erste - zweite;

            return ergebnis;
        }
        static double Multipilzieren(double erste, double zweite)
        {
            double ergebnis;
            ergebnis = erste * zweite;

            return ergebnis;
        }
        static double Dividieren(double zahl, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Ob du mich verarschen willst?");
                return 0;//da wir durch null teilen müsstem geben wir hier ein Dummywert zurück
            }
            else
            {
                double ergebnis = zahl / divisor;
                return ergebnis;
            }
        }
        static double Zahleingeben()
        {
            string eingabe;
            bool hasNotNumber = false;
            do
            {
                Console.WriteLine("Bitte geben sie eine Zahl ein");
                eingabe = Console.ReadLine();

                hasNotNumber = false;//muss hier im Falle eines fehlers zurückgesetzt werden
                for (int i = 0; i < eingabe.Length; i++)
                {
                    if (!char.IsDigit(eingabe[i]))
                    {
                        hasNotNumber = true;
                    }
                }
            } while (hasNotNumber == true);
            return Convert.ToDouble(eingabe);
        }
        static void Menue()
        {
            while (true)
            {
                Console.WriteLine("Sau geiler super Taschenrechner");
                Console.WriteLine("     1: Addiern");
                Console.WriteLine("     2: Subtrahieren");
                Console.WriteLine("     3: Multiplizieren");
                Console.WriteLine("     4: Dividieren");
                Console.Write("->");
                int zahl = (int)Zahleingeben();
                if (zahl == 1)
                {
                    Console.WriteLine("ADDITION");
                    double eins = Zahleingeben();
                    double zwei = Zahleingeben();
                    Console.Write("Ergebnis: " + Addieren(eins, zwei));
                }
                else if (zahl == 2)
                {
                    Console.WriteLine("SUBTRAKTION");
                    double eins = Zahleingeben();
                    double zwei = Zahleingeben();
                    Console.Write("Ergebnis: " + Subtrahieren(eins, zwei));
                }
                else if (zahl == 3)
                {
                    Console.WriteLine("MULTIPLIKATION");
                    double eins = Zahleingeben();
                    double zwei = Zahleingeben();
                    Console.Write("Ergebnis: " + Multipilzieren(eins, zwei));
                }
                else if (zahl == 4)
                {
                    Console.WriteLine("DIVISION");
                    double eins = Zahleingeben();
                    double zwei = Zahleingeben();
                    Console.Write("Ergebnis: " + Dividieren(eins, zwei));
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            //Beispiel: Wir bauen einen Taschenrechner
            //double eineZahl = Addieren(1, 1);
            //double nochNeZahl = Addieren(5, 9);
            //double eineWeitereZahl = Multipilzieren(2, 5);
            //double divi = Dividieren(1, 0);
            //double divi2 = Dividieren(1, 26);
            Menue();

        }
    }
}
