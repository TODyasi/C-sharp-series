
namespace C__series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
        }

        static void Greeting()
        {
<<<<<<< Updated upstream
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("What would you like to say to the people");
            string greeting = Console.ReadLine();
            Console.WriteLine(name + " " + greeting);

=======
            Console.WriteLine("Enter your name:");  
            string name = Console.ReadLine();
            Console.WriteLine("What do you want to tell the people");
            string greeting = Console.ReadLine();   
            Console.WriteLine(name + " " + greeting);
>>>>>>> Stashed changes
        }
    }
}
