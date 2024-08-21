namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var chevy = new Car();

            chevy.Make = "Chevy";
            chevy.Model = "trailblazer";
            chevy.Year = 2024;
            
            Console.WriteLine($"This is a {chevy.Make} {chevy.Model} {chevy.Year}");
        }
        
    }
}
