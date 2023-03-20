class Program
{
    public static void Main()
    {
        unsafe
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Data is: {0} ", p->ToString());
            Console.WriteLine("Address is: {0} ", (int)p);
        }
        Console.ReadKey();
    }
}
