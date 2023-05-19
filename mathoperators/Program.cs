// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

// Basic Assignment opators
int num;

num = 5;


// Arithmatic Operators

int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtration: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 4; 
//num1 +=4 // accumilator 

Console.WriteLine($"\n\nAddition: {num1 + num2}");
Console.WriteLine($"Subtration: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");



//Compound Assigment opator

num1 += 4; //SAME AS  num1 + num2
Console.WriteLine(num1);
num1 -= 4; //Same as num1 - num2
Console.WriteLine(num1);
num1 *= 4; //Same as num1 * num2
Console.WriteLine(num1);
num1 /= 4; // Same as num1 / num2
Console.WriteLine(num1);
num1 %= 4; // Same as num1 % num2
Console.WriteLine(num1);
