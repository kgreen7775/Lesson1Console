// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Variable Declarations and types
string fullname = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool employed = false;

//prompt user for input
Console.Write("Please enter your name ");
fullname = Console.ReadLine();

Console.Write("Please enter your age ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your gender ");
Console.Write("Enter 'M' for Male and 'F' for Female:  ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you employed? ");
Console.Write("Enter True for 'Yes' and False for 'No':" );
employed = Convert.ToBoolean(Console.ReadLine());


//Print Info
Console.WriteLine("\n\nYour name is " + fullname); //concatination 

Console.WriteLine("Your age is {0}",age); //concatination also {0}{1}{2}... corresponds to the addtional variables that can be stated in the printed statement

Console.WriteLine($"Your Salary is {salary}"); //Interpolation can have several variables within the string quoted by a {} 

Console.WriteLine($"Your employment status is {employed}"); //Interpolation  
