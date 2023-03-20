class NumberMainpulator
{
    public int factorial(int num)
    {
        int result;
        if(num==1)
        {
            return 1;
        }
        else
        {
            result = factorial(num - 1) * num;
            return result;
        }
    }
    static void Main(string[] args)
    {
        NumberMainpulator n = new();
        int a;
        Console.WriteLine("请输入数值:");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{a}的阶乘是:{n.factorial(a)}");
        Console.ReadLine();
    }
}
