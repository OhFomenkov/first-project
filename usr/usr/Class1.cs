using System.Collections;

namespace usr;
public class Class1
{
    private int[] IntArray;
    private int n;
    public int N => n;
    public int Mult
    {
        set
        {
            for (int i = 0; i < IntArray.Length; i++)
                IntArray[i] *= value;
        }
    }

    public int Max => IntArray.Max();
    public int Min => IntArray.Min();
    public int Sum => IntArray.Sum();

    public int this[int i]
    {
        get => IntArray[i];
        set => IntArray[i] = value;
    }

    public Class1(int n)
    {
        this.n = n;
        IntArray = new int[n];
        for(int i = 0; i < n; i++)
        {
            IntArray[i] = 0;
        }
    }
    
    public Class1(int a, int b, int n)
    {
        Random rnd = new Random();
        this.n = n;
        IntArray = new int[n];
        for(int j = 0; j < n; j++)
        {
            IntArray[j] = rnd.Next(a, b+1);
        }
    }

    public Class1(Class1 arr, int a, int b)
    {
        this.n = b-a;
        IntArray = new int[n+1];
        for (int j = a; j < b; j++)
        {
            IntArray[j] = j;
        }
    }


    public static Class1 operator ++(Class1 arr)
    {
        for (int i = 0; i < arr.N; i++)
        {
            arr[i]++;
        }

        return arr;
    }
    public static Class1 operator --(Class1 arr)
    {
        for (int i = 0; i < arr.N; i++)
        {
            arr[i]--;
        }

        return arr;
    }

    public static bool operator !(Class1 arr)
    {
        bool isUp = true;
        for (int i = 1; i < arr.N; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                isUp = false;
            }
        }
        return isUp;
    }
    public static Class1 operator *(Class1 arr, int sk)
    {
        for (int i = 0; i < arr.N; i++)
        {
            arr[i] *= sk;
        }

        return arr;
    }

    public static explicit operator int[](Class1 arr)
    {
        return arr.IntArray;
    }
    public static explicit operator Class1(int[] arr)
    {
        var ar = new Class1(arr.Length);
        ar.IntArray = arr;
        return ar;
    }

    public void InputArr()
    {
        for (int i = 0; i < IntArray.Length; i++)
        {
            Console.WriteLine("Введите элемент массива: ");
            this[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void OutArr()
    {
        for (int i = 0; i < IntArray.Length; i++)
        {
            Console.Write("{0} ", IntArray[i]);
        }
    }

    public void BubbleSort()
    {
        int temp = 0;
        for (int i = 0; i < IntArray.Length; i++)
        {
            for (int j = 0; j < IntArray.Length - 1; j++)
            {
                if (IntArray[j] > IntArray[j + 1])
                {
                    temp = IntArray[j + 1];
                    IntArray[j + 1] = IntArray[j];
                    IntArray[j] = temp;
                }
            }
        }
    }


}
    