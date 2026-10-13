namespace ArrayStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gibt einen Text ein!");
            string text = Console.ReadLine();

            //Großbuchstaben
            Console.WriteLine(text.ToUpper());
            //Kleinbuchstaben
            Console.WriteLine(text.ToLower());
            //RückwärtsVarinate 1
            char[] textChar = text.ToCharArray();
            Array.Reverse(textChar);
            Console.WriteLine(textChar);
            //Varinate 2
            string question = "hOw dOeS mIcRoSofT wOrD DeAl WiTh tHe CaPs LoCk Key?";
            for (int i = 0; i < question.Length; i++)
            {
                Console.Write(question[question.Length - i - 1]);//neu
            }
            //Varinate 3
            Console.WriteLine("gib mir einen text");
            string ausgaben = Console.ReadLine();
            string umgedreht = string.Concat(ausgaben.Reverse());
            Console.WriteLine(umgedreht);
            //Erstes Zeichen
            Console.WriteLine(text[0]);
            //Die ersten 5
            for (int i = 0; i < 5; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            //Variante 2
            Console.WriteLine(text.Substring(0, 5));
            //Letztes Zeichen
            Console.WriteLine(text[text.Length - 1]);
            //Varinate2
            Console.WriteLine(text[^1]);
            //Variante 3
            for (int i = text.Length - 1; i < text.Length; i++)
                Console.WriteLine(text[i]);
            //Varinate 4
            if (text.Length <= 0)
            {
                Console.WriteLine(text[text.Length - 1]);
            }
            //Symbol 2-5
            Console.WriteLine(text.Substring(1, 4));
            //Varinate2
            for (int i = 1; i < 5; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
            //Varinate 3
            Console.WriteLine(text[1] + text[2] + text[3] + text[4]);
            //die Anzahl der Zeichen im String
            Console.WriteLine(text.Length);
            //Kommt x im String vor?
            Console.WriteLine(text.Contains('x'));
            //Variante 2
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'x' || text[i] == 'X')
                {
                    count = count + 1;
                }
            }
            if (count > 0)
                Console.WriteLine("enhält x");
            else
                Console.WriteLine("enthält kein x");
            //umwandeln in Array of Char
            char[] textChar2 = text.ToCharArray();

            //AUFGABE 2
            string verschlüsseln = "test 123";
            char[] verschlüsselnChar = verschlüsseln.ToCharArray();
            for (int i = 0; i < verschlüsselnChar.Length - 1; i += 2)
            {
                char temp = verschlüsselnChar[i];
                verschlüsselnChar[i] = verschlüsselnChar[i + 1];
                verschlüsselnChar[i + 1] = temp;
            }
            Console.WriteLine(verschlüsselnChar);
        }
    }
}
