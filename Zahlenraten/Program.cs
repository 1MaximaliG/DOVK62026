namespace Zahlenraten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i > 0; i--)
            {
                Random randy = new Random();//Zufallsgenerator
                int gesuchteZahl = randy.Next(0, 101);//Zufallszahl
                bool isFound = false;
                int anzahl = 0;
                while (isFound == false)
                {
                    Console.WriteLine("Bitte gib ein Zahl ein");
                    int zahl = Convert.ToInt32(Console.ReadLine());
                    anzahl++;
                    if (gesuchteZahl == zahl)
                    {
                        isFound = true;
                    }
                    else if (zahl > gesuchteZahl)
                    {
                        Console.WriteLine("die gesuchte Zahl ist kleiner");
                    }
                    else
                    {
                        Console.WriteLine("die gesuchte Zahl ist größer");
                    }

                    if (anzahl > 15) { break; }
                }
                if (anzahl <= 15)
                {
                    Console.WriteLine("Richtig!");
                    if (anzahl <= 5)
                    {
                        Console.WriteLine("super");
                    }
                    else if (anzahl < 10)
                    {
                        Console.WriteLine("gut geraten");
                    }
                    else
                    {
                        Console.WriteLine("könnte besser sein");
                    }
                }
                else
                {
                    Console.WriteLine("du hast mehr als 15 versuche gebraucht");
                }
            }
        }
    }
}
