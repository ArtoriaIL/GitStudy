class SampleClass
{
    public int x;
    public int y;
    public const int c1 = 5;
    public const int c2 = c1 + 5;
    public SampleClass(int p1,int p2)
    {
        x = p1;
        y = p2;
    }
    static void Main()
    {
        SampleClass mC = new(11, 22);
        Console.WriteLine($"x={mC.x},y={mC.y}");
        Console.WriteLine($"c1={c1},c2={c2}");
        Console.ReadKey();
    }
}
