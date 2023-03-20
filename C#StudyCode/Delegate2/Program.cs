class PrintString
{
    static FileStream fs;
    static StreamWriter sw;
    public delegate void printString(string s);

    public static void WriteToScreen(string str)//输出至控制台
    {
        Console.WriteLine($"The String is:{str}");
    }
    public static void WriteToFile(string s)//输出至C盘下txt文件内
    {
        fs = new FileStream("c:\\messgae.txt", FileMode.Append, FileAccess.Write);
        sw = new StreamWriter(fs);
        sw.WriteLine(s);
        sw.Flush();
        sw.Close();
        fs.Close();
    }
    public static void SendString(printString ps)
    {
        ps("Hello,World...");
    }
    static void Main(string[] args)
    {
        printString ps1 = new(WriteToScreen);
        SendString(ps1);
        printString ps2 = new(WriteToFile);
        SendString(ps2);
        Console.ReadKey();
    }
}
