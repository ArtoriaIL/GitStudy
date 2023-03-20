public class MrZhang
{
    // 买票人是小张
    public static void BuyTicket()
    {
        Console.WriteLine("NND,每次都让我去买票，鸡人呀！");
    }

    public static void BuyMovieTicket()
    {
        Console.WriteLine("我去，自己泡妞，还要让我带电影票！");
    }
}

class MrMing
{
    // 声明委托，其实就是个“命令”
    public delegate void BugTicketEventHandler();

    public static void Main(string[] args)
    {
        // 阐述这个命令是干什么的:MrZhang.BuyTicket“小张买车票”
        BugTicketEventHandler myDelegate = new BugTicketEventHandler(MrZhang.BuyTicket);
        //增加第二个委托
        myDelegate += MrZhang.BuyMovieTicket;
        myDelegate();
        Console.ReadKey();
    }
}
