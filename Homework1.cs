namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        // homework 1 code
        double X = 2.5;
        double Y = 3.3;
        double Z = 4 * X * X + 3 * Y;
        Console.WriteLine($"X = {X}, Y = {Y}");
        Console.WriteLine($"The value of Z is {Z:F2}");
    }
}

