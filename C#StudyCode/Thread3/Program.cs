class ThreadCreationProgram
{
    public static void CallToChildThread()
    {
        try
        {
            Console.WriteLine("Child thread starts");
            for (int counter = 0; counter <= 10; counter++)
            {
                Thread.Sleep(500);
                Console.WriteLine(counter);
            }
            Console.WriteLine("Child Thread Completed");
        }
        catch(ThreadAbortException e)
        {
            Console.WriteLine("Thread Abort Exception");
        }
        finally { Console.WriteLine("Couldn't catch the Thread Exception"); }
    }
    static void Main()
    {
        //ThreadStart childref = new(CallToChildThread);
        Console.WriteLine("In Main:Creating the Child thread");
        Thread childThread = new(CallToChildThread);
        childThread.Start();
        Thread.Sleep(2000);
        Console.WriteLine("In Main:Aborting the Child thread");
        Console.ReadKey();
    }
}