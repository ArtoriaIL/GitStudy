class Shape
{
    protected int width,height;
    public Shape(int a=0,int b=0)
    {
        width= a;
        height= b;
    }
    public virtual int Area()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    public Rectangle(int a=0,int b = 0) : base(a, b)
    {

    }
    public override int Area()
    {
        Console.WriteLine("Rectangle类的面积为:");
        return (width * height);
    }
}
class Triangle : Shape
{
    public Triangle(int a=0,int b=0): base(a, b)
    {

    }
    public override int Area()
    {
        Console.WriteLine("Triangle类的面积为:");
        return (width * height / 2);
    }
}
class Caller
{
    public void CallArea(Shape sh)
    {
        int a;
        a=sh.Area();
        Console.WriteLine($"面积为:{a}");
    }
}
class Tester
{
    static void Main(string[] args)
    {
        Caller c=new();
        Rectangle r = new(10,7);
        Triangle t = new(10, 5);
        c.CallArea(r);
        c.CallArea(t);
        Console.ReadKey();
    }
}
