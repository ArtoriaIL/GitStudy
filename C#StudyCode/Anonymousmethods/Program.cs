delegate void NumberChanger(int n);
class TestDelegate
{
    static int num = 10;
    public static void AddNum(int p)
    {
        num += p;
        Console.WriteLine($"Named Method:{num}");
    }
    public static void MultNum(int q)
    {
        num *= q;
        Console.WriteLine($"Named Method:{num}");
    }
    static void Main()
    {
        NumberChanger nc = delegate (int x)
        {
            Console.WriteLine($"Anonymous Method:{x}");
        };
        nc(10);
        nc = new(AddNum);
        nc(5);
        nc=new(MultNum);
        nc(2);
        Console.ReadKey();       
    }
}