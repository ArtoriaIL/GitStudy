delegate int NumberChanger(int n);
namespace DelegateApp1
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new(AddNum);
            NumberChanger nc2 = new(MultNum);
            nc1(25);
            Console.WriteLine($"Value of Num:{GetNum()}");
            nc2(5);
            Console.WriteLine($"Value of Num:{GetNum()}");
        }
    }
}
