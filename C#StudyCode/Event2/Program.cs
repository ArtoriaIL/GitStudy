public class Car
{
    // 这个委托用来与Car事件协作
    public delegate void CarEngineHandler(string msg);

    // 这种汽车可以发送这些事件
    public event CarEngineHandler Exploded;
    public event CarEngineHandler AboutToBlow;

    public int CurrentSpeed { get; set; }

    public int MaxSpeed { get; set; }

    public string PetName { get; set; }

    private bool CarIsDead;

    public Car()
    {
        MaxSpeed = 100;
    }

    public Car(string name, int maxSp, int currSp)
    {
        CurrentSpeed = currSp;
        MaxSpeed = maxSp;
        PetName = name;
    }

    public void Accelerate(int delta)
    {
        if(CarIsDead==false)
        {
            CurrentSpeed += delta;

            // 确认已无法使用，触发AboutToBlow事件
            if ((MaxSpeed - CurrentSpeed) <= 10 && AboutToBlow != null)
            {
                AboutToBlow("careful buddy ! gonna blow !");
            }
            Console.WriteLine($"CurrentSpeed={CurrentSpeed}");
            if (CurrentSpeed >= MaxSpeed)
            {
                CarIsDead = true;
            }                                                
            if (CarIsDead)
            {
                if (Exploded != null)
                {
                    Exploded("sorry,this car is dead");
                }
            }
        }
    }
}
class program
{
    static void Logger(string info)
    {
        Console.WriteLine(info);
    }
    static void Main()
    {
        Car c = new("法拉利",100,84);
        c.AboutToBlow += new Car.CarEngineHandler(Logger);
        c.Exploded += new Car.CarEngineHandler(Logger);
        c.Accelerate(1);
        Console.ReadLine();

        c.Accelerate(10);
        Console.ReadLine();
        c.Accelerate(10);
        Console.ReadLine();
    }
}