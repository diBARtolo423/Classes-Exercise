namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wrangler = new Car();
            wrangler.Make = "Jeep";
            wrangler.Model = "Wrangler";
            wrangler.Year = 2023;

            wrangler.MyCar();
        }
    }
}
