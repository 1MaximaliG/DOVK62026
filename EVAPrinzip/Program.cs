using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace EVAPrinzip
{
    internal class Program
    {
        static void Aufgabe1a()
        {
            //Wechselkursumrechnung
            Console.WriteLine("Bitte gib einen Eurobetrag ein:");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Der Betrag {euro} Euro sind {euro * 1.5} Dollar");
        }
        static void Aufgabe1b()
        {
            //Wechselkursumrechnung
            Console.WriteLine("Bitte gib einen Eurobetrag ein:");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib einen Wechselkurs ein:");
            double wechsel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Der Betrag {euro} Euro sind {euro * wechsel} Dollar");
        }
        static void Aufgabe1c()
        {
            //Wechselkursumrechnung
            Console.WriteLine("Bitte gib einen Eurobetrag ein:");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In welche Währung soll konvertiert werden");
            string währung = Console.ReadLine();
            Console.WriteLine("Bitte gib einen Wechselkurs ein:");
            double wechsel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Der Betrag {euro} Euro sind {euro * wechsel} {währung}");
        }
        static void Aufgabe2()
        {
            Console.WriteLine("Wieviele Liter Diesel wurden nachgetankt?");
            double liter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib die seit dem letzten Tanken gefahrenen Kilometer ein");
            double km = Convert.ToDouble(Console.ReadLine());
            double verbrauch = liter / km * 100;
            Console.WriteLine($"Der durchschnittliche verbrauch beträgt: {verbrauch}l");
        }
        static void Aufgabe3()
        {
            //1 Ft = 30,48 cm
            //Breite = 41 Ft
            //anlauf = mindestens 15 Ft
            //Gesamtlänge = 62 Ft
            //Länge von der Foul - Linie zum 1.Pin(Kegel) 60 Ft
            //Querschnitt Kugel: 21,83 cm
            double umfang = 21.83 * 3.14159;//PI mal d (2rPi)
            double länge = 60 * 30.48;//Umrechnen Ft in cm
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
        }
        static void Aufgabe3b()
        {
            double umfang = 17.52 * 3.14159;//neuer Durchmesser
            double länge = 60 * 30.48;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
        }
        static void Aufgabe3c()
        {
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            double durchmesser = Convert.ToDouble(Console.ReadLine());
            double umfang = durchmesser * 3.14159;//neuer Durchmesser
            double länge = 60 * 30.48;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
        }
        static void Aufgabe3d()
        {
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            double durchmesser = Convert.ToDouble(Console.ReadLine());
            double umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            double rutsch = Convert.ToDouble(Console.ReadLine());

            double länge = 60 * 30.48 - rutsch;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
        }
        static void Aufgabe3e()
        {
            double gesamt = 0;
            //Erster
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            double durchmesser = Convert.ToDouble(Console.ReadLine());
            double umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            double rutsch = Convert.ToDouble(Console.ReadLine());

            double länge = 60 * 30.48 - rutsch;
            gesamt = länge / umfang;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
            //Zweiter Durchlauf
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            durchmesser = Convert.ToDouble(Console.ReadLine());
            umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            rutsch = Convert.ToDouble(Console.ReadLine());

            länge = 60 * 30.48 - rutsch;
            gesamt = gesamt + länge / umfang;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
            //dritter Durchlauf
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            durchmesser = Convert.ToDouble(Console.ReadLine());
            umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            rutsch = Convert.ToDouble(Console.ReadLine());

            länge = 60 * 30.48 - rutsch;
            gesamt = gesamt + länge / umfang;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
            //vierter Durchlauf
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            durchmesser = Convert.ToDouble(Console.ReadLine());
            umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            rutsch = Convert.ToDouble(Console.ReadLine());

            länge = 60 * 30.48 - rutsch;
            gesamt = gesamt + länge / umfang;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");
            //fünfter Durchlauf
            Console.WriteLine("Bitte gib den Durchmesser ein: ");
            durchmesser = Convert.ToDouble(Console.ReadLine());
            umfang = durchmesser * 3.14159;//neuer Durchmesser

            Console.WriteLine("Wie weit rutscht die Kugel in cm");
            rutsch = Convert.ToDouble(Console.ReadLine());

            länge = 60 * 30.48 - rutsch;
            gesamt = gesamt + länge / umfang;
            Console.WriteLine($"Die Kugel dreht sich {länge / umfang} mal.");

            Console.WriteLine($"Im durchschnitt haben wir {gesamt / 5} umdrehungen der Kugel");
        }
        static void Main(string[] args)
        {
            //Aufgabe1a();
            //Aufgabe1b();
            //Aufgabe1c();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe3b();
            //Aufgabe3c();
            //Aufgabe3d();
            Aufgabe3e();
        }
    }
}
