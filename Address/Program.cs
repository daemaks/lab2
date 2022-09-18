namespace Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Address address = new Address();
            address.Index = 353;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Lobachevskogo";
            address.House = "23";
            address.Apartment = "513";

            Console.WriteLine(address.ToString());
        }
    }
}