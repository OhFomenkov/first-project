using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace labfile
{
    class Project
    {
        static void find_x()
        {
            Console.WriteLine("Введите строку");
            
           // StringBuilder temp = new StringBuilder(str);
            int first = 1000;
            int last = 1000;
            string temp = Console.ReadLine(); ;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 'x' && first == 1000)
                {
                    first = i + 1;
                }
                if (temp[i] == 'x' && first != 1000)
                {
                    last = i + 1;
                }
            }
            if (first == 1000)
            {
                Console.WriteLine("В строке нету символа 'x'");
            }
            else {
                Console.WriteLine("Первое вхождение: {0}\nПоследнее вхождение: {1}", first, last);
            }
        }

        static void Find_words()
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            str = RemoveSpecialCharacters(str);
            string[] arr = str.Split(' ');
            int len = 20;
            
            foreach(string s in arr)
            {
                if(s.Length < len)
                {
                    len = s.Length;
                }
            }
        
            Console.Write("Самые короткие слова: ");
            foreach(string s in arr)
            {
                if(s.Length == len)
                {
                    Console.Write(s + ' ');
                }
            }
        }

        static string RemoveSpecialCharacters(string str)
        {
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ' || (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я')) 
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        static void gettin_kod()
        {
            Console.WriteLine("Введите ФИО личности");
            string str = Console.ReadLine();
            str = str.ToLower();
            int kod = 0;
            string[] arr = str.Split(' ');
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if(Convert.ToInt32(arr[i][j]) - 1071 > 6)
                    {
                        kod++;
                    }
                    kod += Convert.ToInt32(arr[i][j]) - 1071;
                }
            }
            Console.WriteLine(kod);
            Preobr_kod(kod);
        }


        static void Preobr_kod(int kod)
        {
            int new_kod = 0;
            StringBuilder temp = new StringBuilder(kod.ToString());
            if (temp.Length > 1)
            {
                for(int i = 0; i<temp.Length; i++)
                {
                    new_kod += Convert.ToInt32(temp[i]) - 48;
                }
                Preobr_kod(new_kod);
            }
            else
            {
                Console.WriteLine(kod);
            }
        }

        static void Preobr_str()
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            Console.WriteLine("Введите ключ");
            int k = Convert.ToInt32(Console.ReadLine());
            str = str.ToLower();
            string[]arr = str.Split(' ');
            Cesar_shifr(arr, k);
        }


        static void Cesar_shifr(string[]arr, int k)
        {
            StringBuilder str = new StringBuilder();
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    int index = Findindex(alf, arr[i][j]);
                    if(index + k > 32)
                    {
                        str.Append(alf[index + k - 33]);
                    }
                    else
                    {
                        str.Append(alf[index + k]);
                    }
                }
                str.Append(' ');
            }
            Console.WriteLine(str);
        }
            
        static int Findindex(string alf, char a)
        {
            int index = -1;
            for(int i = 0; i < alf.Length; i++)
            {
                if (Convert.ToChar(alf[i]) == a)
                {
                    index = i;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    find_x();
                    break;


                case 2:
                    Find_words();
                    break;

                case 3:
                    gettin_kod();      // a - 1071
                    break;

                case 4:
                    Preobr_str();
                    break;

                case 5:
                    Console.WriteLine(Convert.ToChar(49));
                    break;
            }
            
        }
    }
}