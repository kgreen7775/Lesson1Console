// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// For loops (Counter Controlled loop

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\nThe Count is at {i + 1}");
}
Console.WriteLine("END FOR");


// While Loop Consition Controlled Loop
int n = 0;
int n1 = 0;
while (n > 5)
{
    Console.WriteLine("Insert number");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered number {n1}");
}

// Do While Loop Inverted while Loop


int n2 = 0;

do
{
    Console.WriteLine("Insert number");
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered number {n2}");

} while (n > 5);

//Foreach - Honorable mention

var n3 = 0;
foreach (var i in n3)
{

}
