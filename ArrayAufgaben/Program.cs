namespace ArrayAufgaben
{
    internal class Program
    {
        static void Aufgabe1()
        {
            int[] zahlen = new int[20];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = i; //Befüllen des Arrays
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]); //Ausgabe der Inhalte des Arrays
            }
        }
        static void Aufgabe2()
        {
            int[] zahlen = new int[20];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = i + 1; //Befüllen des Arrays
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]); //Ausgabe der Inhalte des Arrays
            }
        }
        static void Aufgabe3()
        {
            int[] zahlen = new int[20];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = Convert.ToInt32(Math.Pow(2, i)); //Befüllen des Arrays 
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]); //Ausgabe der Inhalte des Arrays
            }
        }
        static void Aufgabe4()
        {
            int[] zahlen = new int[20];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = Convert.ToInt32(Math.Pow(i, 2)); //Befüllen des Arrays 
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]); //Ausgabe der Inhalte des Arrays
            }
        }
        static void Aufgabe5()
        {
            int[] zahlen = new int[20];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                Random rnd = new Random();
                zahlen[i] = rnd.Next(1, 21); //Befüllen des Arrays 
            }
            //Sortieren
            Array.Sort(zahlen);
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i]
                    + " "); //Ausgabe der Inhalte des Arrays
            }
            //Umdrehen
            Array.Reverse(zahlen);
            Console.WriteLine();
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + " "); //Ausgabe der Inhalte des Arrays
            }
        }
        static void Aufgabe6()
        {
            int summe = 0;
            int[] zahlen = new int[200];//Deklaration und initialisierung
            for (int i = 0; i < zahlen.Length; i++)
            {
                Random rnd = new Random();
                zahlen[i] = rnd.Next(1, 21); //Befüllen des Arrays
                summe = summe + zahlen[i];
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + " "); //Ausgabe der Inhalte des Arrays
            }
            Console.WriteLine();
            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Summe: "+ zahlen.Sum());
        }
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe5();
            Aufgabe6();
        }
    }
}
