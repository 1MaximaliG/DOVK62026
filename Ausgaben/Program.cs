namespace Ausgaben
{
    internal class Program
    {
        static void Aufgabe1()
        {
            //AUFGABE 1
            Console.WriteLine("Bitte gib deinen Namen ein:");
            string name;//definition eines Strings
            name = "";
            name = Console.ReadLine();//erste zuweisung initialisiert die Variable
            Console.WriteLine("Bitte gib deinen Nachnamen ein");
            string nachname = Console.ReadLine();
            //name = name + " " + Console.ReadLine();
            Console.WriteLine("Bitte gib deine Adresse ein");
            string adresse = Console.ReadLine();

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Nachname: " + nachname);
            Console.WriteLine("Adresse: " + adresse);

        }
        static void Aufgabe2()
        {
            //AUFGABE 2
            Console.WriteLine("----- Meine Freunde ------");
            Console.WriteLine();
            Console.WriteLine("      n: Einen Freund finden");
            Console.WriteLine("      l: Einen Freund verlieren");
            Console.WriteLine("      a: Alle Freunde einladen");
            Console.WriteLine("      k: Alle Freunde verlieren");
            Console.WriteLine("      q: Das Programm verlassen");
            Console.WriteLine("->");
        }
        static void Aufgabe3() {
            //AUFGABE 3
            Console.WriteLine("********");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*******");
            Console.WriteLine("      *");
            Console.WriteLine("      *");
            Console.WriteLine("*******");
        }
        static void Aufgabe4() {
            //AUFGABE 4
            Console.WriteLine("Bill Gates wird folgendes Zitat zugeschrieben:" +
                "\n\t\"640 Kilobyte  Speicher sind genug -" +
                "\n\t\t- und \"kein Mensch\" wird jemals so viel brauchen...\"");
            Console.WriteLine("\"server1:\\\\Typisches\\Layer_8\\Problem\"");
        }
        static void Main(string[] args)
        {
            Aufgabe1();
            Aufgabe2();
            Aufgabe3();
            Aufgabe4();         
        }//Main
    }//Ende Program
}//Ende namespace
