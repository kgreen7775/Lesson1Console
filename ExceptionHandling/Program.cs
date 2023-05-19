// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Enter number1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2");
int num2 = Convert.ToInt32(Console.ReadLine());


try
{

    int quotient = num1 / num2;
    Console.WriteLine(quotient.ToString());
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"|Illegal operation{ e.Message}");
}
catch (Exception e)
{
    throw;
}
finally
{
    Console.WriteLine("This is the end of the program");
}


