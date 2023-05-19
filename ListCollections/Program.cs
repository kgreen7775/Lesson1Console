// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//declaring lists

List<string> names = new List<string>();

string name = string.Empty;

//Add values to lists

//names[0] = "Tname";
names.Add(name);
names.Remove(name);

Console.WriteLine("Enter names of your class");
while (names.Equals("-1"))
//while (names.Count > 0)
{
    Console.WriteLine("Enter name ");
    name = Console.ReadLine();
    if(string.IsNullOrEmpty(name) && !name.Equals(-1))
    {
        names.Add(name);
        Console.WriteLine($"{name} added successfully");
    }
}

// printing names via For loop
Console.WriteLine("Printing names via for loop");
for  (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("ForeachLoop Results");

foreach (string item in names)
{
    Console.WriteLine(item);
}
