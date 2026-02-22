namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 Method: 
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = largeNum(num1, num2);
        Console.WriteLine("a = " + num1 + ", b = " + num2);
        Console.WriteLine("The largest number is: " + result);

        //Call Q2 Method:
        int max = numCompare();
        Console.WriteLine("The largest number is: " + max);

        //Call Q3 Method:
        createAccount();
    }

    //Q1 Method:
    static int largeNum (int a, int b)
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

    //Q2 Method: 
    static int numCompare(){
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int firstMax = largeNum(num1, num2);
        int secondMax = largeNum(num3, num4);
        int finalMax = largeNum(firstMax, secondMax);

        return finalMax;
    }

    //Q3 Method: 
    static bool checkAge(int birth_year)
    {
        int age = DateTime.Now.Year - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void createAccount()
    {
        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();
        Console.WriteLine("Enter your password again: ");
        string passwordConfirm = Console.ReadLine();
        Console.WriteLine("Enter your birth year: ");
        int birth = Convert.ToInt32(Console.ReadLine());
        if (checkAge(birth))
        {
            if (password == passwordConfirm)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
	

}
