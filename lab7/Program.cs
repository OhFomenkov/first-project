using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;

namespace labfile;

class Project
{
    static string ReadText(StreamReader reader, int size)
    {
        reader.ReadLine();
        StringBuilder stringBuilder = new StringBuilder();
        char k;
        int n = 0;
        for (int i = 0; i < size; i++)
        {
            k = (char)reader.Read();
            stringBuilder.Append(k == '\r' ? "" : k);
            if (k == '\r') size++;
        }
        return stringBuilder.ToString();
    }

    static int[,] readinfo(string path, StreamReader reader)
    {
        int[,] Permutation = new int[2, 20];
        for (int j = 0; j < 17; j++)
        {
            reader.Read();
        }

        string[] nums1 = Regex.Split(reader.ReadLine().TrimStart(' '), "\\s+");
        string[] nums2 = Regex.Split(reader.ReadLine().TrimStart(' '), "\\s+");
        int i = 0;
        for (int j = 0; j < 20; j++)
        {
            Permutation[i, j] = Convert.ToInt32(nums1[j]);
        }
        i = 1;
        for (int j = 0; j < 20; j++)
        {
            Permutation[i, j] = Convert.ToInt32(nums2[j]);
        }

        return Permutation;

    }

    static string EncryptingText(string text, int[,] arr)
    {
        StringBuilder temp = new();
        int buff = 0;
        for (int i = 0; i < text.Length / 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                temp.Append(text[arr[1, j] + buff]);
            }
            buff += 20;
        }
        int n = text.Length % 20;
        for (int i = 0; i < n; i++)
        {
            int line = 1;
            int stolb = i;
            while (arr[line, stolb] > n - 1)
            {
                stolb = arr[line, stolb];
                line ^= 1;
            }
            temp.Append(text[arr[line, stolb] + buff]);
        }
        return temp.ToString();
    }

    static int[] CreateNewKey(int[,] oldkey)
    {
        int[] newkey = new int[20];

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (oldkey[1,j] == i)
                {
                    newkey[i] = j;
                }
            }
        }
        return newkey;
    }

    static string Cryptingtext(string text, int[,] arr)
    {
        StringBuilder temp = new();
        int buff = 0;
        for (int i = 0; i < text.Length / 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                temp.Append(text[arr[0, j] + buff]);
            }
            buff += 20;
        }
        int n = text.Length % 20;
        for (int i = 0; i < n; i++)
        {
            int line = 0;
            int stolb = i;
            while (arr[line, stolb] > n - 1)
            {
                stolb = arr[line, stolb];
                line ^= 1;
            }
            temp.Append(text[arr[line, stolb] + buff]);
        }
        return temp.ToString();
    }


    static void OutInfo(int[]arr, int size, string text)
    {
        StreamWriter wr= new StreamWriter(new FileStream("C:\\Users\\user\\Desktop\\output.txt", FileMode.OpenOrCreate));
        wr.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        wr.WriteLine("\nDecrypting {0} characters", size);
        wr.WriteLine("Using:   0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19");
        wr.Write("\t");
        for (int i = 0; i < 20; i++)
        {
            wr.Write("{0}  ", arr[i]);
        }
        wr.WriteLine("\n");
        wr.Write(text);
        wr.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        wr.Close();
    }



    public static void Main(string[] args)
    {
        string path = "C:\\Users\\user\\Downloads\\1.Scrambled.txt";
        StreamReader rd = new StreamReader(path);
        int[,] arr = readinfo(path, rd);
        rd.ReadLine();
        int size = Convert.ToInt32(rd.ReadLine());
        string text = ReadText(rd, size);
        string result = EncryptingText(text, arr);
        int[] newkey = CreateNewKey(arr);
        Console.WriteLine(result);
        OutInfo(newkey, size, result); 
        rd.Close();
    }
}