namespace KopfgesteuerteSchleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe6();
            Aufgabe7();
        }
        static void Aufgabe1()
        {
            //Zweierreihe
            int zähler = 0;
            while (zähler <= 10)
            {
                Console.WriteLine(zähler);
                zähler = zähler + 2;
            }

        }
        static void Aufgabe2()
        {
            int zähler = 0;
            int summe = 0;
            while(zähler <= 10)
            {
                summe = summe + zähler;
                Console.WriteLine(summe);
                zähler++;
            }
        }
        static void Aufgabe3()
        {
            Console.WriteLine("Bitte gib mal Zahl");
            int n = Convert.ToInt32(Console.ReadLine());
            int zähler = 1;
            int summe = 1;
            while(zähler <= n)
            {
                summe = summe * zähler;
                zähler = zähler + 1;
            }
            Console.WriteLine(summe);
        }
        static void Aufgabe6()
        {
            int alt = 0;
            int neu = 1;
            int zähler = 0;

            while (zähler < 10)
            {
                Console.WriteLine(alt);
                int temp = alt + neu;
                alt = neu;
                neu = temp;
                zähler = zähler + 1;
            }
            Console.WriteLine(alt);
            //Console.WriteLine(neu);
        }
        static void Aufgabe7()
        {
            //Quadratzahl bis Schranke
            int zähler = 0;
            int schranke = 500;
            while (zähler * zähler <= schranke)
            {
                Console.WriteLine(zähler * zähler);
                zähler = zähler + 1;
            }
        }
    }
}
