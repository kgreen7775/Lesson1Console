// See https://aka.ms/new-console-template for more information
class Cube : Shape, IShape
{
    public Cube()//default conmstructor 
    {
            
    }
    public Cube(int width, int height, int length) //constructor
    {
        Width = width;
        Height = height;
        Length = length;
            
    }

    public double Width { get; set; }

    public double getArea()
    {
        throw new NotImplementedException();
    }
}
