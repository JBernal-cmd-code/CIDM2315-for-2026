namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
      //Question 1 code: 
      Console.WriteLine("Please input a letter grade (A, B, C, D, F): ");
        string gradeLetter = Console.ReadLine().ToUpper();
        if
            (gradeLetter == "A")
        {
            Console.WriteLine("GPA Point: 4");
        } 
        else if (gradeLetter == "B")
        {
            Console.WriteLine("GPA Point: 3");
        }
        else if (gradeLetter == "C")
        {
            Console.WriteLine("GPA Point: 2");
        }
        else if (gradeLetter == "D")
        {
            Console.WriteLine("GPA Point: 1");
        }
        else if (gradeLetter == "F")
        {
            Console.WriteLine("GPA Point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        
        //Question 2 code:
        Console.WriteLine("Please input the first number: ");
        int firstNum = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second number: ");
        int secondNum = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third number: ");
        int thirdNum = Convert.ToInt16(Console.ReadLine());
        if (firstNum <= secondNum)
        {
            if (firstNum <= thirdNum)
            {
                Console.WriteLine("The smallest number is: " + firstNum);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + thirdNum);
            }
     }else if (secondNum <= thirdNum)
        {
            Console.WriteLine("The smallest number is: " + secondNum);
        }
        else
        {
            Console.WriteLine("The smallest number is: " + thirdNum);
        }

        //Bonus Question code:
        Console.WriteLine("Please input a year: ");
        int yearCheck = Convert.ToInt16(Console.ReadLine());
        if ((yearCheck % 4 == 0 && yearCheck % 100 != 0) || (yearCheck % 400 == 0))
        {
            Console.WriteLine(yearCheck + " is a leap year.");
        }
        else
        {
            Console.WriteLine(yearCheck + " is not a leap year.");
        }

    }   
}
