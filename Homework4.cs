namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_Method
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int largestNumber = largeNumberQ1(num1, num2);
            Console.WriteLine("The largest number is: " + largestNumber);

        //Call Q2_Method
            Console.WriteLine("Enter a number for N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What way do you want the triangle to be: left or right?");
            string shapeWay = Console.ReadLine();
            triangleStairQ2(N, shapeWay);
    }
        //Q1_Method
    static int largeNumberQ1(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    
        //Q2_Method
    static void triangleStairQ2(int N, string typeWay)
    {
        Console.WriteLine("N is: " + N + " and the shape is: " + typeWay);
        if (typeWay == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (typeWay == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int star = 1; star <= N - i; star++)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter an actual way: left or right");
        }
    }

}