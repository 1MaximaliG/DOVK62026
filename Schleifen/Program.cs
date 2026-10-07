namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SchleifenBeispiel();
            BowlingMitSchleife();
        }
        static void SchleifenBeispiel()
        {
            int zähler = 10;
            //Kopfgesteuert
            while (zähler < 10)
            {
                Console.WriteLine(zähler);
                zähler = zähler + 1;
            }

            //Fußgesteuert
            zähler = 0;
            do
            {
                Console.WriteLine(zähler);
                zähler = zähler + 1;
            } while (zähler < 10);
        }
        static void BowlingMitSchleife()
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
        }
    }
}
