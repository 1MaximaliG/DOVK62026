namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchleifenBeispiel();
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
        }//Ende Methode
    }
}
