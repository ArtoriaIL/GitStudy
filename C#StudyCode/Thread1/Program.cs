class ThreadCreationProgram
{
    public static void CallToChildThread()
    {
        Console.WriteLine("Child thread starts'");
    }
    static void Main()
    {
        ThreadStart childref = new(CallToChildThread);
        Console.WriteLine("In Main:Creating the Child thread");
        Thread childThread = new(childref);
        childThread.Start();
        Console.ReadKey();
    }
}
