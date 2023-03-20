using System.Reflection;

[AttributeUsage(AttributeTargets.Class|AttributeTargets.Constructor|
    AttributeTargets.Field|AttributeTargets.Method|AttributeTargets.Property,AllowMultiple =true)]
public class DeBugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DeBugInfo(int bg, string dev,string d)
    {
        bugNo= bg;
        developer= dev;
        lastReview= d;
    }
    public int BugNo
    {
        get { return bugNo; }
    }
    public string Developer
    {
        get { return developer; }
    }
    public string LastReview
    {
        get { return lastReview; }
    }
    public string Message
    {
        get { return message; }
        set { message = value; }
    }
}
[DeBugInfo(45,"Zara Ali","12/8/2012",Message ="Return type mismatch")]
[DeBugInfo(49,"Nuha Ali","10/10/2012",Message ="Unused variable")]
class Rectangle
{
    protected double length;
    protected double width;
    public Rectangle(double l,double w)
    {
        length = l;
        width = w;
    }
    [DeBugInfo(55,"Zara Ali","19/10/2012",Message ="Return type mismatch")]
    public double GetArea()
    {
        return length * width;
    }
    [DeBugInfo(56,"Zara Ali","19/10/2012")]
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
        Rectangle r = new(4.5, 7.5);
        r.Display();
        Type type = typeof(Rectangle);
        foreach(Object attributes in type.GetCustomAttributes(false))
        {
            DeBugInfo dbi=(DeBugInfo)attributes;
            if(null!=dbi)
            {
                Console.WriteLine($"BugNo:{dbi.BugNo}");
                Console.WriteLine($"Developer:{dbi.Developer}");
                Console.WriteLine($"Last Review:{dbi.LastReview}");
                Console.WriteLine($"Remarks:{dbi.Message}");
            }
        }
        foreach (MethodInfo m in type.GetMethods())
        {   
            foreach(Attribute a in m.GetCustomAttributes(true))
            {
                DeBugInfo dbi = (DeBugInfo)a;
                if (null != dbi)
                {
                    Console.WriteLine($"Bug no:{dbi.BugNo},for Method:{m.Name}");
                    Console.WriteLine($"Developer:{dbi.Developer}");
                    Console.WriteLine($"Last Reviewed:{dbi.LastReview}");
                    Console.WriteLine($"Remarks:{dbi.Message}");
                }
            }
        }
        Console.ReadLine();
    }
}
