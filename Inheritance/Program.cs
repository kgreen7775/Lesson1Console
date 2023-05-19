// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Cube cube = new Cube();


Console.WriteLine("Enter length of the shape");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height of the shape");
int Height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width of the shape");
int Width = Convert.ToInt32(Console.ReadLine());

var triangle = new Triangle() {Length =length, Height = Height };
var rectangle = new Rectangle() { Length = length, Height = Height};
var cube = new Cube() { Length = length, Height = Height, Width = Width};


//cube.Length = length;
//cube.Width = Width; 
//cube.Height = Height;

//triangle.Length = length;
//triangle.Height = Height;

//rectangle.Length = length;
//rectangle.Height = Height;

Console.WriteLine("Cube area is " + " " + cube.getArea());
Console.WriteLine("Triangle area is " + " " + triangle.getArea());
Console.WriteLine("Rectagnle area is " + " " + rectangle.getArea());