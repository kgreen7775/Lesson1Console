// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Declare fized sized array

int [] grades = new int[5];

// Adding values to arrays

//grades[0] = 56;
//grades[1] = 68;
//grades[2] = 71;

//grades = new int[] { 47, 66, 85 };

//write a program to insert grades

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter all grades ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//print values from an array
Console.WriteLine("Here are the recorded grades ");
for  (int i = 0;i < grades.Length;i++)
{
    Console.WriteLine(grades[i]);
}


//variable sized arrays

string[] stnames = new string[] {"stu1,stu2,stu3"};

for (int i = 0; i <stnames.Length; i++)
{
    Console.WriteLine("Enter all names ");
    stnames[i] = Console.ReadLine();


}

//print values from an array
Console.WriteLine("Here are the recorded names ");
for (int i = 0; i < stnames.Length; i++)
{
    Console.WriteLine(stnames[i]);
}

