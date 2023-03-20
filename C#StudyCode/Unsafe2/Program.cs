class TestPointer
{
    public unsafe static void Main()
    {
        int[] list = { 1, 100, 200 };
        fixed (int* ptr = list)

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Address of list[{i}]={(int)(ptr+i)}");
                Console.WriteLine($"Value of list[{i}]={*(ptr + i)}");
            }
        Console.ReadKey();
    }
}