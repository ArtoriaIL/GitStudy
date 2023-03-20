public class EventTest//发布器类
{
    private int value;
    public delegate void NumManipulationHandler();
    public event NumManipulationHandler ChangeNum;
    protected virtual void OnNumChanged()
    {
        if (ChangeNum != null)
        {
            ChangeNum();
        }
        else
        {
            Console.WriteLine("Event not fire");
            Console.ReadKey();
        }
    }
    public EventTest()
    {
        int n = 5;
        SetValue(n);
    }
    public void SetValue(int n)
    {
        if (value != n)
        {
            value= n;
            OnNumChanged();
        }
    }
}
public class SubscribEvent//订阅器类
{
    public void Printf()
    {
        Console.WriteLine("Event fire");
        Console.ReadKey();
    }
}

public class MainClass
{   
    public static void Main()
    {
        EventTest e = new();
        SubscribEvent v = new();
        e.ChangeNum += new EventTest.NumManipulationHandler(v.Printf);
        e.SetValue(7);
        e.SetValue(11);
    }
}
