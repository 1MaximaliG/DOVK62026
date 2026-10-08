namespace FußgesteuerteSchleifen
{
    internal class Program
    {
        static void Aufgabe1()
        {
            int e = 1;
            do
            {
                Console.WriteLine(e);
                //e++;
                //e += 1;
                e = e + 1;
            } while (e <= 10);
        }
        static void Aufgabe2()
        {
            int summe = 0;
            int e = 2;
            do
            {
                summe += e;
                e += 2;
            } while (e <= 20);
            Console.WriteLine(summe);
        }
        static void Aufgabe2b()
        {
            int summe = 0;
            int e = 1;
            do
            {
                if ((e / 2) == (e / 2f))
                {
                    summe += e;
                }
                e++;
            } while (e <= 20);
            Console.WriteLine(summe);
        }
        static void Aufgabe2c()
        {
            int summe = 0;
            int e = 1;
            do
            {
                if (e % 2 == 0)
                {
                    summe += e;
                }
                e++;
            } while (e <= 20);
            Console.WriteLine(summe);
        }
        static void Aufgabe3()
        {
            int zähler = 0;
            int zahl = 10;
            do
            {
                Console.WriteLine(zahl);
                zähler++;
                zahl = zahl - 1;
            } while (zähler < 10);
        }
        static void Aufgabe4()
        {
            int zähler = 4;
            int erg = 1;
            do
            {
                //erg *= zähler;
                erg = erg * zähler;
                zähler--;
            } while (zähler >= 1);
            Console.WriteLine(erg);
        }
        static void Aufgabe7()
        {
            int ende = 4;
            int a = 1;
            do
            {
                int b = 1;
                do
                {
                    Console.Write(b + " ");
                    b++;
                } while (b <= a);
                Console.WriteLine();
                a++;//increment
            } while (a <= ende);
        }
        static void Aufgabe7b()
        {
            int ende = 40;
            int a = 1;
            do
            {//zeilenumbruch
                int b = 1;
                int c = ende - a;
                do//leerzeichen vor den zahlen
                {
                    Console.Write(" ");
                    c--;
                } while (c >= 0);
                do//alle symbole in einer zeile
                {
                    Console.Write(b + " ");
                    b++;
                } while (b <= a);
                Console.WriteLine();
                a++;//increment
            } while (a <= ende);
        }
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            Aufgabe2b();
            Aufgabe2c();
            //Aufgabe3();
            //Aufgabe4();
            //Aufgabe7();
            //Aufgabe7b();
        }
    }
}
