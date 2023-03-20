public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Heigth { get; set; }
    public int Width { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("执行画图任务...");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("画一个圆形...");
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("画一个矩形...");
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("画一个三角形...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Circle(),
            new Triangle()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
        Console.ReadKey();

    }

}