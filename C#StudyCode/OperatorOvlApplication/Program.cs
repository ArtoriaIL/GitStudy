using System.Transactions;

class Box
{
    private double length;
    private double breadth;
    private double height;

    public double GetVolume()
    {
        return length * breadth * height;
    }
    public void SetLength(double len)
    {
        length = len;
    }
    public void SetBreadth(double bre)
    {
        breadth = bre;
    }
    public void SetHeight(double hei)
    {
        height = hei;
    }
    public static Box operator+(Box a, Box b)
    {
        Box box = new();
        box.length=a.length+b.length;
        box.breadth=a.breadth+b.breadth;
        box.height=a.height+b.height;
        return box;
    }
}
class Tester
{
    static void Main(string[] args)
    {
        Box box1 = new();
        Box box2 = new();
        Box box3 = new();
        double volume = 0.0;
        box1.SetLength(10);
        box1.SetBreadth(20);
        box1.SetHeight(30);

        box2.SetLength(20);
        box2.SetBreadth(40);
        box2.SetHeight(60);

        volume=box1.GetVolume();
        Console.WriteLine($"Box1的体积为:{volume}");

        volume=box2.GetVolume();
        Console.WriteLine($"Box2的体积为:{volume}");

        box3 = box1 + box2;
        volume=box3.GetVolume();
        Console.WriteLine($"Box3的体积为:{volume}");
        Console.ReadKey();
    }
}
