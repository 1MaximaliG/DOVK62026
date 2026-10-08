namespace Verzweigung
{
    internal class Program
    {
        static void Aufgabe1()
        {
            Console.WriteLine("Bitte gibt eine Zahl ein");
            int zahl = Convert.ToInt32(Console.ReadLine());

            if(zahl < 5)
            {
                Console.WriteLine("Die Zahl ist klein als 5");
            }
            
        }
        static void Aufgabe2()
        {
            Console.WriteLine("Bitte gibt eine Gewicht in Pfund ein");
            int zahl = Convert.ToInt32(Console.ReadLine());

            //Variante 1
            if (zahl < 235)
            {
                Console.WriteLine("nicht zugelassen, du Hungerhacken");
            } else if( zahl > 265)
            {
                Console.WriteLine("Nicht zugelassen, du fettes Stück!!");
            }
            else
            {
                Console.WriteLine("Du bist zugelassen, du geile Sau");
            }

            //Varinate 2
            if (zahl < 265)
            {
                if(zahl > 235)
                {
                    Console.WriteLine("Perfekt Brudi");
                }
                else
                {
                    Console.WriteLine("Sind sie zu stark bist du zu schwach, iss mal was!");
                }
            }
            else
            {
                Console.WriteLine("To fett to Fly");
            }

        }
        static void Main(string[] args)
        {
            Aufgabe1();
            Aufgabe2();
        }
    }
}
