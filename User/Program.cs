namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            User user = new User("someLogin", "Maksym", "Lytvynov", 20);

            Console.WriteLine(user.ToString());
        }
    }
}