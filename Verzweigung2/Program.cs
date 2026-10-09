namespace Verzweigung2
{
    internal class Program
    {
        static void Aufgabe1()
        {
            Console.WriteLine("Gib eine Zahl ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());
            if (zahl % 2 == 0)
                Console.WriteLine("Die Zahl ist grade");
            else
                Console.WriteLine("Die Zahl ist ungrade");
        }
        static void Aufgabe3()
        {
            while (true)
            {
                Console.WriteLine("Gib eine Zahl Nummer 1 ein!");
                int zahl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gib eine Zahl Nummer 2 ein!");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gib eine Zahl Nummer 3 ein!");
                int zahl3 = Convert.ToInt32(Console.ReadLine());

                if (zahl > zahl2 && zahl > zahl3)
                {
                    Console.WriteLine($"{zahl} ist die gößte Zahl");
                }
                else if (zahl2 > zahl && zahl2 > zahl3)
                {
                    Console.WriteLine($"{zahl2} ist die gößte Zahl");
                }
                else
                {
                    Console.WriteLine($"{zahl3} ist die gößte Zahl");
                }
            }
        }
        static void Aufgabe4()
        {
            Console.WriteLine("Gib eine Prozentzahl ein!");
            int prozent = Convert.ToInt32(Console.ReadLine());
            if (prozent >= 92)
            {
                Console.WriteLine("Note 1");
            }
            else if (prozent >= 81)
            {
                Console.WriteLine("Note 2");
            }
            else if (prozent >= 67)
            {
                Console.WriteLine("Note 3");
            }
            else if (prozent >= 50)
            {
                Console.WriteLine("Note 4");
            }
            else if (prozent >= 30)
            {
                Console.WriteLine("Note 5");
            }
            else
            {
                Console.WriteLine("Note 6");
            }
        }
        static void Aufgabe5()
        {
            Console.WriteLine("Gib die länge einer Graden ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die länge der zweiten Graden ein!");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die länge der dritten Graden ein!");
            int zahl3 = Convert.ToInt32(Console.ReadLine());
            if ((zahl + zahl2 > zahl3) && (zahl3 + zahl > zahl2) && (zahl2 + zahl3 > zahl))
            {
                Console.WriteLine("ist ein Dreieck");
            }
            else
            {
                Console.WriteLine("ist kein Dreieck");
            }
        }
        static void Aufgabe6()
        {
            Console.WriteLine("Gib mal ne Zahl ein!");
            int zahl = Convert.ToInt32(Console.ReadLine());
            if (zahl < 0)
            {
                Console.WriteLine("Die Zahl ist Negativ");
            }
            else if (zahl > 0)
            {
                Console.WriteLine("Die Zahl ist Positiv");
            }
            else
            {
                Console.WriteLine("Die Zahl ist Null");
            }
        }
        static void Aufgabe7()
        {
            Console.WriteLine("Gib eine Temperatur ein!");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp > 30)
            {
                Console.WriteLine("heiß");
            }
            else if (temp > 20)
            {
                Console.WriteLine("warm");
            }
            else if (temp > 10)
            {
                Console.WriteLine("mild");
            }
            else if (temp > 0)
            {
                Console.WriteLine("kalt");
            }
            else
            {
                Console.WriteLine("Eiszapfen");
            }
        }
        static void Aufgabe8()
        {
            Console.WriteLine("Benutzername:");
            string user = Console.ReadLine();
            Console.WriteLine("Passwort:");
            string pw = Console.ReadLine();

            if(user == "Admin" && pw == "pass123")
            {
                Console.WriteLine("Erfolgreich");
            }
            else
            {
                Console.WriteLine("Falsche Anmeldedaten");
            }
        }
        static void Aufgabe10()
        {
            Console.WriteLine("Gib die Zahl des Wochentages ein");
            int z = Convert.ToInt32(Console.ReadLine());
            if (z == 1) { Console.WriteLine("Montag"); }
            if (z == 2) { Console.WriteLine("Diensteak"); }
            if (z == 3) { Console.WriteLine("Mettwoch"); }
            if (z == 4) { Console.WriteLine("Dönerstag"); }
            if (z == 5) { Console.WriteLine("Hightag"); }
            if (z == 6) { Console.WriteLine("Pyjamatag"); }
            if (z == 7) { Console.WriteLine("Sonntag"); }
            if (z < 1 || z > 7) { Console.WriteLine("Du Doof"); }
        }
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe5();
            //Aufgabe6();
            //Aufgabe7();
            //Aufgabe8();
            Aufgabe10();
        }
    }
}
