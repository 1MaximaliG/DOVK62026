namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GANZZAHLEN
            int a = 5;
            Console.WriteLine(a);
            a = 7;
            Console.WriteLine(a + 10);

            //KOMMAZAHLEN
            float b = 5.2346f;//f signalisiert dem Compiler,
                              //dass die Zahl als float interpretiert wird
            double c = 5.2346;//= 5.5464d geht auch
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            //BUCHSTABEN
            char d = '#';
            Console.WriteLine(d);
            Console.WriteLine((int)d);
            d = (char)3000;// ausserhalb des Wertebereiches
            Console.WriteLine(d);

            //BUCHSTABENKETTEN
            string e = "Hallo, Max!!!11";
            Console.WriteLine(e);
            e = e + " aljhfkjahhag";
            Console.WriteLine(e);

            //WAHRHEITSWERTE
            bool f = true; //definition
            f = false;
            Console.WriteLine(f);
            
            Console.WriteLine("Hello, World!");
            Console.Write("Hello, ...!");
            Console.Write("..., World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine(2450 + 50);
            Console.WriteLine("2450" +"50");

            Console.WriteLine("Bitte gib einen Namen ein");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Du heißt also : " + name);//Verkettung von strings
            Console.WriteLine($"Hallo {name}, wie geht es dir?");//Interpretierter string
            Console.WriteLine("Hallo {0}, wie geht es dir?",name);//string mit Parametern

            Console.WriteLine("Bitte gib eine Zahl ein");
            int alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ahhh du bis also schon {alter} Jahre alt.");
            
        }
    }
}
