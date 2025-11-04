// See https://aka.ms/new-console-template for more information

class Circle
{
    public const double PI = 3.14;

    public static double Area(double radius)
    {
        return PI * radius * radius;
    }
    public static double Perimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Value of PI: {Circle.PI}");

        double radius = 5;
        Console.WriteLine($"Area of circle: {Circle.Area(radius)}");
        Console.WriteLine($"Perimeter of circle: {Circle.Perimeter(radius)}");
    }
}
