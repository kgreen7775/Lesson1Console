// See https://aka.ms/new-console-template for more information

class Rectangle : Shape, IShape
{
    public Rectangle()
    {
            
    }

    public Rectangle(int height, int length)
    {
       // Width = width;
        Height = height;
        Length = length;
    }

    public double getArea()
    {
        throw new NotImplementedException();
    }
}