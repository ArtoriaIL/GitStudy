class Boiler
{
    private int temp;
    private int pressure;
    public Boiler(int t,int p)
    {
        temp = t;
        pressure = p;
    }
    public int GetTemp()
    {
        return temp;
    }
    public int Getpressure()
    {
        return pressure;
    }
}
class DelegateBoilerEvent//发布器
{
    public delegate void BoilerLogHandler(string status);
    //根据delegate定义Event
    public event BoilerLogHandler BoilerEventLog;
    public void LogProcess()
    {
        string remarks = "O.K";
        Boiler b = new(100, 12);
        int t = b.GetTemp();
        int p = b.Getpressure();
        if (t > 150 || t < 80 || p < 12 || p > 15)
        {
            remarks = "Need Maintenance";
        }
        OnBoilerEventLog("Logging Info:\n");
        OnBoilerEventLog("Temparature " + t + "\nPressure:" + p);
        OnBoilerEventLog("\nMessage:" + remarks);
    }
    protected void OnBoilerEventLog(string message)
    {
        if (BoilerEventLog != null)
        {
            BoilerEventLog(message);
        }
    }
}
class BoilerInfoLogger//写入文件
{
    FileStream fs;
    StreamWriter sw;
    public BoilerInfoLogger(string filename)
    {
        fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
        sw = new StreamWriter(fs);
    }
    public void Logger(string info)
    {
        sw.WriteLine(info);
    }
    public void Close()
    {
        sw.Close();
        fs.Close();
    }
}
public class RecordBoilerInfo//订阅器
{
    static void Logger(string info)
    {
        Console.WriteLine(info);
    }
    static void Main()
    {
        BoilerInfoLogger filelog = new("c:\\boiler.txt");//生成Txt文件
        DelegateBoilerEvent boilerEvent = new();
        boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);//控制台
        boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);//Txt文件内
        boilerEvent.LogProcess();
        Console.ReadLine();
        filelog.Close();
    }
}

