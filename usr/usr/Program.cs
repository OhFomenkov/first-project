using System;

namespace usr
{
    class Project
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int n = 5;
            int[] arr = {1,2, 3, 4, 5};
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }
            Class1 user = new(arr.Length);
            user.InputArr();
            user.OutArr();
            user.BubbleSort();
            Console.WriteLine();
            user.OutArr();

        }
    }
}