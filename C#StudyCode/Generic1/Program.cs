class Program
{
static void Swap<T>(ref T lhs,ref T rhs)
{
    T temp;
    temp = lhs;
    lhs = rhs;
    rhs = temp;
}
static void Main(string[] args)
{
    int a, b;
    char c, d;
    a = 10;b = 20;
    c = 'I';d = 'V';
    Console.WriteLine("Int values before calling swap:");
    Console.WriteLine($"A={a},B={b}");
    Console.WriteLine("Char values before calling swap:");
    Console.WriteLine($"C={c},D={d}");

    Swap<int>(ref a, ref b);
    Swap<char>(ref c, ref d);
    Console.WriteLine("Int values before calling swap:");
    Console.WriteLine($"A={a},B={b}");
    Console.WriteLine("Char values before calling swap:");
    Console.WriteLine($"C={c},D={d}");
    Console.ReadKey();
}
}