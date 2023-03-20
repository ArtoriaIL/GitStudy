class ThreadCreationProgram
{
    public static void CallToChildThread()
    {
        Console.WriteLine("Child thread starts");
        int sleepfor = 5000;
        Console.WriteLine($"Child Thread Paused for {sleepfor / 1000} seconds");
        Thread.Sleep( sleepfor );//单位为毫秒
        Console.WriteLine("Child thread resumes");       
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