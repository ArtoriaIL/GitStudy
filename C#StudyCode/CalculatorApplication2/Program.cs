class NumberManipulator
{
    public void swap(ref int x,ref int y)
    {
        int temp;
        temp = x; x = y;y= temp;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("请输入A值:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("请输入B值:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"交换前A为:{a},交换前B为:{b}");
        NumberManipulator n = new();
        n.swap(ref a,ref b);
        Console.WriteLine($"交换后A为:{a},交换后B为:{b}");
        Console.ReadLine();

    }
}
