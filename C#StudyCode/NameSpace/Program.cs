namespace first_space
{
    class Namespace_c1
    {
        public static void Func()
        {
            Console.WriteLine("Inside First_Space");
        }
    }
}
namespace second_space
{
    class Namespace_c1
    {
        public static void Func()
        {
            Console.WriteLine("Inside Second_Space");
        }
    }
}
class TestClass
{
    static void Main(string[] args)
    {
        first_space.Namespace_c1.Func();//命名空间、类、方法
        second_space.Namespace_c1.Func();
        Console.ReadKey();
    }
}
