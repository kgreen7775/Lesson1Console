// See https://aka.ms/new-console-template for more information
using ClassAndObjects;

internal class Program
{
    //private static readonly double salary;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person person = new();
        //Person person = new person();
        string middleName = string.Empty;

        Console.Write("Enter firstname ");
        person.FirstName = Console.ReadLine();


        Console.Write("Enter middlename ");
        middleName = Console.ReadLine();

        Console.Write("Enter lastname ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter age ");
        person.Age = Convert.ToInt32(Console.ReadLine());


        Console.Write("How much are you paid monthly");
        int salary = Convert.ToInt32(Console.ReadLine());
        person.setSalary(salary);//had to initialize private class for this to work

        Console.WriteLine($"\n\nSalary is " + " " + person.getSalary());

        //Console.WriteLine("Firstname is" + " "+ person.FirstName);
        // Console.WriteLine("Lastname is" + " "+ person.LastName);
        if (string.IsNullOrEmpty(middleName))
        {
            Console.WriteLine("Fullname is" + " " + person.getFullName());
        }
        else
        {
            Console.WriteLine("Fullname is" + " " + person.getFullName(middleName));
        }
        //Console.WriteLine("Fullname is" + " " +person.getFullName);
        Console.WriteLine("Age is" + " " + person.Age);

        //Static Class - Date Util 
        Console.WriteLine("Year of Birth is " + " " + DateUtil.YearofBirth(person.Age));



    }

    
   

}