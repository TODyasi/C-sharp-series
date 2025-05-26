
namespace C__series
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string getGreeting = Greeting().ToString();
            Console.WriteLine(getGreeting);
        }

        static string Greeting()
        {
            string greeting = "Wagwan my people in the physical world \nMy name is";
            string name = "AuxDev";
            string from = "\nfrom the bombaclat country of South Africa";

            return greeting + name + from;
        }
    }
}
