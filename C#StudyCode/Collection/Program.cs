class HelloWorld
{
    static void Main(string[] args)
    {
        var a = new List<int>();
        a.Add(2);
        a.Add(6);
        a.Add(2);
        a.Add(10);
        Console.WriteLine($"第一个数为{a[0]}");
        a.Remove(2);//删去第一个匹配此条件的项
        foreach (var a2 in a)
        {
            Console.WriteLine(a2);
        }
        a.Sort();
        foreach (var a2 in a)
        {
            Console.WriteLine(a2);
        }
        bool a3 = a.Contains(2);
        Console.WriteLine(a3);
        Console.ReadKey();
    }
}