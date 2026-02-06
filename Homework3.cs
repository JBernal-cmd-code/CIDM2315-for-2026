namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Question 1
    Console.WriteLine("Input an integer:");
    int N = Convert.ToInt32(Console.ReadLine());
    bool checkPrime = true;
    if (N <= 1)
    {
        checkPrime = false;
    }
    else
    {
        for (int i = 2; i <=N-1; i++)
        {
            if (N % i == 0)
            {
                checkPrime = false;
                break;
            }
        }
    }
    if (checkPrime)
    {
        Console.WriteLine("N is prime");
    }
    else
    {
        Console.WriteLine("N is non-prime");
    }

        //Code for Question 2
    Console.WriteLine("Assign an int value to N:");
    int N2 = Convert.ToInt32(Console.ReadLine());
    for (int row=1; row <= N2; row++)
        {
            for (int col=1; col <= N2; col++)
            {                
            Console.Write("*");   
            }
            Console.WriteLine();
        }

        //Code for Question 3
    Console.WriteLine("Assign an int value to N:");
    int N3 = Convert.ToInt32(Console.ReadLine());
    for (int row = 1; row <= N3; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

    }
}
}