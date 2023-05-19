// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//If Statements
int numberofapples;
int numberoforanges;

Console.WriteLine("Enter num1");
numberofapples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num2");
numberoforanges = Convert.ToInt32(Console.ReadLine());

if (numberofapples > numberoforanges)
{
    Console.WriteLine("number of apples are greater than the number of oranges");
}
else if (numberofapples < numberoforanges)
    {   
    Console.WriteLine("Number of oranges are greater than the number of apples");

    }
else if (numberofapples == numberoforanges) 
    {
        Console.WriteLine("Number of Apples are Equivalent to the number of oranges");
    }
    else
        {
    Console.WriteLine("Something went wrong");
        
        }



// Swtich Statements

int grade;

Console.WriteLine("What was your final grade");
grade = Convert.ToInt32(Console.ReadLine());

switch (grade)
{
    default:
        Console.WriteLine("Invalid Grade");
    break;
    case int n when (n >= 50 && n <= 100):

        Console.WriteLine("Failing Grade");
    break;

    case int n when (n<=49 && n >= 0):
        Console.WriteLine("Failed");
    break;
        
}



// Ternary Operators
var message = numberofapples > numberoforanges ? "You have more apples than oranges" : "You have more oranges than apples";
Console.WriteLine(message);
