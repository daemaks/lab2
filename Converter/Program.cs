namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.027f, 0.03f, 1.64f);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the mod:");
                Console.WriteLine("1: From Hryvnia");
                Console.WriteLine("2: To Hryvnia");

                int mode;
                if (!int.TryParse(Console.ReadLine(), out mode))
                    continue;

                if (mode == 1 || mode == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter number and currency[20, EUR]");

                    string[] text = Console.ReadLine().Split(",");
                    float value;
                    if (!float.TryParse(text[0], out value))
                        continue;

                    Currency currency;
                    if (!Enum.TryParse(text[1], true, out currency))
                        continue;

                    float result = mode == 1 ? converter.FromHryvnia(value, currency) : converter.ToHryvnia(value, currency);

                    Console.WriteLine($"{value} {(mode == 1 ? "UAH" : currency)} = {result} {(mode == 1 ? currency : "UAH")}");
                    Console.WriteLine("...");
                    Console.Read();
                }
            }
        }
    }
}