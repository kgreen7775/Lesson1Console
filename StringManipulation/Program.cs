// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstname = "Kadeem";
string lastname = "Green";

//Print to screen

Console.WriteLine("String being printed");
Console.WriteLine(firstname);

//Concatenation

Console.WriteLine(firstname +""+lastname);
Console.WriteLine("My full name is" + lastname + "," + firstname);
Console.WriteLine($"My full name is {firstname} {lastname}");
Console.WriteLine("my name is {0}, {1}", lastname, firstname);


// String Length
int length = firstname.Length;
Console.WriteLine($"Your name is {length} letters long");


//Replace string parts
string newName = firstname.Replace('K', 'H');
Console.WriteLine($"Your newname is {newName}");


// Append to the other string variable
string fullname = firstname + lastname;
Console.WriteLine($"My full name is {fullname}");


// Split string 
string[] splitname = fullname.Split( 'e' );
for ( int i = 0;i<splitname.Length;i++)
{
    Console.WriteLine(splitname[i]);
}

// Compare string
// 
string nullstring=null;
string emptystring = "";
string whitespace = " ";

if(string.IsNullOrEmpty(nullstring))
{
    Console.WriteLine("string is null");
}

if (firstname != lastname)
{
    Console.WriteLine("names are not equal");
}

int comparisonresult = string.Compare(firstname,lastname);
if(comparisonresult == 0)    
{
    Console.WriteLine("Name are equal");
}
else
{
    Console.WriteLine("Name are not equal");

}

// convert to string

string convertedstring = string.Empty;
int num1 = 1234567;

convertedstring = num1.ToString();
convertedstring = 13263849.ToString();