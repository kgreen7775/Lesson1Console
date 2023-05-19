// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");


//Prototype - Defines the function (type, name and parameters) 


//Definition - has the code. It contains the code block



//Void Functions - completes a task and moves along

void printname()
{
    Console.WriteLine("Kadeem Green");
}

void addition(int num1, int num2)
{
    Console.WriteLine($"Sum of {num1} and {num2} is {num1+num2}");    
}

//ValueTask returning function - completes a task and returns a result

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest > num3)
    {
        largest = num3;

    } 
     else if (largest > num2) 
    {
        largest = num2;    
    }
    else if(largest > num1) 
    {
        largest = num1;
    }

    return largest;
}

// Function call - makes the function 

printname();


Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());

addition(number1, number2);

Console.WriteLine("Enter number3");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"Largst number is {result}");
// Another way of doing it would be to:
//Console.WriteLine($"{LargestNumber(number1, number2, number3)}");