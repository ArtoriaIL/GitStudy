namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size+1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }
        public void SetItem(int index, T value)
        {
            array[index] = value;
        }       
    }
    class Tester
    {
        static void Main()
        {
            MyGenericArray<int> intArray = new(5);
            for (int c = 0; c < 5; c++)
            {
                intArray.SetItem(c, c * 5);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.GetItem(c)+" ");
            }
            Console.WriteLine();
            MyGenericArray<char> charArray = new(5);
            for (int c = 0; c < 5; c++)
            {
                charArray.SetItem(c, (char)(c + 97));
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.GetItem(c)+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
