internal class suanfa
{
    static void Main()
    {
        int[] _arrayNa = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1,0 };
        for (int i = 0; i < _arrayNa.Length - 1; i++)
        {
            for (int j = 0; j < _arrayNa.Length - 1; j++)
            {
                if (_arrayNa[j] > _arrayNa[j + 1])
                {
                    int k = _arrayNa[j];
                    _arrayNa[j] = _arrayNa[j + 1];
                    _arrayNa[j + 1] = k;

                }
            }
        }
        foreach (int Num in _arrayNa)
        {
            Console.Write(Num);
        }
        Console.ReadKey();

    }
}
