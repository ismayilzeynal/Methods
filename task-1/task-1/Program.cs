using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 80, 45, 102, -6, -10, 7, 60, 0, 0, 7, 1, 9 };
            Console.WriteLine(ArrayMin(arr));
        }

        static int ArrayMin(int[] arr)
        {
            int min = arr[0];
            foreach (int item in arr)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }
    }
}
