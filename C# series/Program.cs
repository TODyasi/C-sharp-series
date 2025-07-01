
using C__series.Shapes._2DShapes.Rectangle;
using C__series.Shapes.Circle;

namespace C__series
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Area and Perimeter of Rectangle ";
            Console.BackgroundColor = ConsoleColor.Green;

            //Ask the user for input and calculate the area and perimeter
            Console.WriteLine("Enter the length of the rectangle: ");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of the rectangle: ");
            float breadth = float.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, breadth);

            float perimeter = rectangle.CalculatePerimeter();
            float area = rectangle.CalculateArea();

            Console.WriteLine($"perimeter: {perimeter}");
            Console.WriteLine($"area: {area}");
        }
            
    }
}


