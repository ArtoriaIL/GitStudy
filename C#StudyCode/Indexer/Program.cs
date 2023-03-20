class IndexedNames
{
    private string[] namelist = new string[size];
    static public int size = 10;
    public IndexedNames()
    {
        for (int i = 0; i < size; i++)
            namelist[i] = "N.A";        
    }
    public string this[int index]
    {
        get
        {
            string tmp;
            if(index>=0&&index<=size-1)
            {
                tmp = namelist[index];
            }
            else
            {
                tmp = "";
            }
            return tmp;
        }
        set
        {
            if (index >= 0 && index <= size - 1)
            {
                namelist[index] = value;
            }

        }
    }
    public int this[string name]
    {
        get
        {
            int index = 0;
            while(index < size)
            {
                if (namelist[index] == name)//在index++的循环中找到与name对应的namelist对象
                    return index;
                index++;
            }
            return index; //当例遍后，找不到对象时返回
        }
    }
    static void Main(string[] args)
    {
        string name;
        IndexedNames names = new();
        names[0] = "Zara";
        names[1] = "Riz";
        names[2] = "Nuha";
        names[3] = "Asif";
        names[4] = "Davinder";
        names[5] = "Sunil";
        names[6] = "Rubic";
        for(int i=0;i<IndexedNames.size;i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine("请输入你要查找编号的学生名:");
        name = Convert.ToString(Console.ReadLine());
        Console.WriteLine($"名为{name}的学生的编号为:{names[name]}（编号从0开始）");
        Console.ReadKey();
        
    }
    

}
