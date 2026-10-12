namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars;
            cars = new string[4] { "Volvo", "BMW", "Jaguar", "Ford" };
            
            string[] sportwagen = { "Benz", "Lamborghini", "Porsche", "Opel","Trabant" };//Deklaration+Initialisierung
            //ertser index ist 0
            Console.WriteLine(cars[0]);
            cars[0] = "Honda";
            Console.WriteLine(cars[0]);
            //cars[4] = "Peter";//Index 4 existiert nicht, da 3 der letzte index ist
            for(int i = 0; i < sportwagen.Length; i++)
            {
                Console.WriteLine($"Ein {sportwagen[i]} Fährt um die Ecke");
            }
        }
    }
}
