// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public Triangle()
    {
        
    }

    public Triangle(int height, int length)
    {
        //Width = width;
        Height = height;
        Length = length;
    }

    public double Hypothenuse { get; set; }

    public double getArea()
    {
        throw new NotImplementedException();
    }
}