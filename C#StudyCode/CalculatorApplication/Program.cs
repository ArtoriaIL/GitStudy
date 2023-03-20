class NumberMainpulator
{
    public int FindMax(int num1,int num2)
    {
        int result;
        if (num1 > num2)
        {
            result = num1;
        }
        else
        {
            result = num2;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("请输入第一个数值:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("请输入第二个数值:");
        int b = Convert.ToInt32(Console.ReadLine());
        int ret;
        NumberMainpulator n = new();

        ret = n.FindMax(a, b);
        Console.WriteLine($"两个数字中最大的是:{ret}");
        Console.ReadLine();
    }
}
