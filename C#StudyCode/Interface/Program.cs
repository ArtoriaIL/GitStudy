class Program
{
    static void Main(string[] args)
    {
        IWorker james1 = new James1();
        IWorker james2 = new James2();
        james1.work("设计");
        james2.work("编程");
        //可以想象如果又来了新的员工
        //不采用接口，每个员工都有一个单独的类，就会容易出错。
        //如果有接口约束，那么只要实现了接口就肯定有接口里声明的方法，我们只需拿来调用。
    }
}
public interface IWorker { void work(string s); }
class James1 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("我的名字是James1，我的工作是" + s);
    }
}
class James2 : IWorker
{
    public void work(string s)
    {
        Console.WriteLine("我的名字是James2，我的工作是" + s);
    }
}
