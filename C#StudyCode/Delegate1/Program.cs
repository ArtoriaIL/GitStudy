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
            NumberChanger nc;
            NumberChanger nc1 = new(AddNum);
            NumberChanger nc2 = new(MultNum);
            nc=nc1;
            nc += nc2;//合并委托应在方法使用之前
            nc(5);
            Console.WriteLine($"Value of Num:{GetNum()}");
        }
    }
}
