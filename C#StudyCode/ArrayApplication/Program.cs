/*class MyArray
{
    static void Main(string[] args)
    {
        int[] n = new int[10];
        int i;

        for (i = 0; i < 10; i++)
        {
            n[i] = i+100;
            Console.WriteLine($"Element[{i}]={n[i]}");
        }
        Console.ReadKey();
    }
}*/

class MyArray
{
    static void Main(string[] args)
    {
        int[] n = new int[10];
        for (int i = 0; i < 10; i++)
        {
            n[i] = i+100;
        }

        foreach(int j in n)
        {
            int i = j - 100;
            Console.WriteLine($"Element[{i}]={j}");
        }
        Console.ReadKey();
    }
}
