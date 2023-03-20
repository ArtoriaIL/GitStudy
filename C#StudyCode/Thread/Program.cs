class MainThreadProgram
{
    static void Main()
    {
        Thread th = Thread.CurrentThread;
        th.Name = "MainThread";
        Console.WriteLine($"This is {th.Name}");
        Console.ReadKey();
    }
}