namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
 Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
 Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
 Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
 Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
 Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
 Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	 Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};


 TotalCredits(customer_list);
 AmarilloAverageAge(customer_list);
 CanyonAge(customer_list);
    }

    public static void TotalCredits(Customer[] customer_list)
    {
        double sumCredit = 0;
        for(int i = 0; i < customer_list.Length; i++){
            sumCredit += customer_list[i].customerCredit;
        }
        Console.WriteLine("Q1: The total credits: " + sumCredit);
    }


    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int numAge = 0;
        int ageCheck = 0;
        for(int i = 0; i < customer_list.Length; i++){
            if(customer_list[i].customerCity == "Amarillo"){
                numAge += customer_list[i].customerAge;
                ageCheck++;
            }
        }
        double averageAge = (double)numAge / ageCheck;
        Console.WriteLine("Q2: The average age of customers in Amarillo: " + averageAge);
    }
public static void CanyonAge(Customer[] customer_list)
{
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        for (int i = 0; i < customer_list.Length; i++)
    {
        if (customer_list[i].customerCity == "Canyon" && customer_list[i].customerAge > 30)
        {
        Console.Write(customer_list[i].customerName + ", ");
        }
    }
        Console.WriteLine(); 
}
}
class Customer{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

}

