public class Car
{
    // 申明委托
    public delegate void CarEngineHandler(string msg);
    // 创建委托实例Exploded和AboutToBlow事件
    public event CarEngineHandler Exploded;
    public event CarEngineHandler AboutToBlow;
    //设置属性
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string PetName { get; set; }
    public bool CarIsDead;//用于判断是否超速

    public Car()//构造函数
    {
        MaxSpeed = 100;
    }

    public Car(string name, int maxSp, int currSp)//构造函数重载

    {
        CurrentSpeed = currSp;
        MaxSpeed = maxSp;
        PetName = name;
    }

    public void Accelerate(int delta)//用于触发Exploded和AboutToBlow事件
    {
        CurrentSpeed += delta;//"踩油门"加速
        if (CurrentSpeed >= MaxSpeed)//判断时速  
            CarIsDead = true;
        else
            CarIsDead = false;
        if (CarIsDead)// 如果Car超速了，触发Exploded事件
        {
            if (Exploded != null)//判断是否被委托联系起来
            {
                Exploded("sorry,this car is dead");//调用CarDead事件
            }
        }
        else
        {    //如果没有超速，则提示快要超速并显示实时车速
            if ((MaxSpeed - CurrentSpeed) > 0 && (MaxSpeed - CurrentSpeed) <= 10 && AboutToBlow != null)//判断是否被委托联系起来且速度是否接近临界值
            {
                AboutToBlow("careful buddy ! gonna blow !");//调用NearDead事件 
                Console.WriteLine("CurrentSpeed={0}", CurrentSpeed);//显示实时车速
            }
        }
    }
}

//订阅类书写举例
public class Answer
{
    public void CarDead(string msg)//汽车已爆缸事件
    {
        Console.WriteLine("sorry,this car is dead");
    }

    public void NearDead(string msg)//汽车快要爆缸事件
    {
        Console.WriteLine("careful buddy ! gonna blow !");
    }
}

//主函数书写
public class test
{
    static void Main(string[] args)
    {
        Car c = new Car("奔驰", 100, 93);//创建实例并初始化，初始速度为93
        Answer an = new Answer();
        c.Exploded += new Car.CarEngineHandler(an.CarDead);//Exploded"绑定"CarDead
        c.AboutToBlow += new Car.CarEngineHandler(an.NearDead);//AboutToBlow"绑定"NearDead
        c.Accelerate(6);//第一次加速，时速小于100，引发的事件为"快要爆缸"并显示实时车速为99
        Console.ReadLine();//等待回车键已启动第二次加速
        c.Accelerate(2);//第二次加速，时速超过100，引发的事件为"已爆缸"，不显示车速
        Console.ReadKey();
    }
}
