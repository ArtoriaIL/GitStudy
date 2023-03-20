// See https://aka.ms/new-console-template for more information
class Rectangle
{
    private double length;//double=float*2,即double float
    private double width;
    public void Acceptdetails()
    {
        Console.WriteLine("请输入长度:");
        length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入宽度:");
        width = Convert.ToDouble(Console.ReadLine());
    }
    public double GetArea()
    {
        return length * width;
    }
    public void Display()
    {
        Console.WriteLine($"Length:{length}");
        Console.WriteLine($"Width:{width}");
        Console.WriteLine($"Area:{GetArea()}");
    }
}

class ExecuteRectangle
{
    static void Main(string[] args)
    {
        Rectangle r = new();
        r.Acceptdetails();
        r.Display();
        Console.ReadLine();
    }
}
