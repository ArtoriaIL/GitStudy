using System;


internal class suanfa
    {
    static void Main()
    {
        int[] _arrayNa = new int[] { 1, 4, -2, 3, 5, 6 };
        Console.WriteLine("排序前：");
        foreach (int Num in _arrayNa)
        {
            Console.Write(Num);
        }
        Console.Write("\n");//换行
        for (int i = 0; i < _arrayNa.Length - 1; i++)
        {
            bool isChange=false;
            for (int j = 0; j < _arrayNa.Length - 1-i; j++)
            {
                int n=j;
                if (_arrayNa[j] > _arrayNa[j+1])
                {
                    int k = _arrayNa[j];
                    _arrayNa[j] =  _arrayNa[j+1];
                    _arrayNa[j + 1] = k;
                    isChange=true;

                }
                Console.WriteLine($"第{i + 1}轮排序中：第{n + 1}次比较");
            }
            Console.WriteLine($"第{i+1}轮排序后");
            foreach (int Num in _arrayNa)
            {
                Console.Write(Num);
            }
            Console.Write("\n");//换行
            if(!isChange)
            {
                break;
            }
        }
        Console.WriteLine("最终排序:");
        foreach (int Num in _arrayNa)
        {
            Console.Write(Num);
        }
        Console.Write("\n");
        Console.ReadKey();
    }
}
