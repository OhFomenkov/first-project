using System;
using System.Reflection.PortableExecutable;
using System.Text;

namespace labfile
{
    class Class1
    {
        static void InputDouble()
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream("C:\\Users\\user\\Desktop\\lab5.dat", FileMode.OpenOrCreate)))
            {
                writer.Write("2,3 4 5 6 7 8");
            }
        }

        static void Equa()
        {
            using (BinaryReader reader = new BinaryReader(new FileStream("C:\\Users\\user\\Desktop\\lab5.dat", FileMode.Open)))
            {
                Console.WriteLine("Введите числа для сравнения");
                double c = Convert.ToInt32(Console.ReadLine());
                double d;

                reader.Read();
                Console.Write("Числа меньше {0}: ", c);
                while (reader.PeekChar() != -1)
                {
                    d = ReadDouble(reader);
                    if (d < c)
                    {
                        Console.Write("{0} ", d);
                    }
                }
            }
        }
        static void polozh()
        {
            using (BinaryReader reader = new BinaryReader(new FileStream("C:\\Users\\user\\Desktop\\lab5.dat", FileMode.Open)))
            {
                double d;
                reader.Read();
                Console.Write("Положительные числа: ");
                while (reader.PeekChar() != -1)
                {
                    d = ReadDouble(reader);
                    if (d > 0)
                    {
                        Console.Write("{0} ", d);
                    }
                }
            }
        }

        static void Arifm()
        {
            using (BinaryReader reader = new BinaryReader(new FileStream("C:\\Users\\user\\Desktop\\lab5.dat", FileMode.Open)))
            {
                double d;
                int count = 0;
                int kolvo = 0;
                double buf = 0;
                reader.Read();
                while (reader.PeekChar() != -1)
                {
                    d = ReadDouble(reader);
                    count++;
                    if (count % 2 == 0)
                    {
                        kolvo++;
                        buf += d;
                    }                    
                }
                Console.WriteLine("Среднее арифметичское чисел стоящил на четных позициях: {0}", buf / kolvo);
            }
        }


        public static double ReadDouble(BinaryReader br)
        {
            StringBuilder sb = new StringBuilder("");
            char cur;
            
            while (br.PeekChar() != ' ' && br.PeekChar() != -1)
            {
                sb.Append((char)br.Read());
            }

            br.Read();
            return Convert.ToDouble(sb.ToString());
        }




        public static void InputChars()
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream("C:\\Users\\user\\Desktop\\lab5.2.dat", FileMode.Create)))
            {
                Console.WriteLine("Введите текст");
                string str = Console.ReadLine();
                string digit = "1234567890";
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        continue;
                    }
                    else
                    {
                        writer.Write(str[i]);
                    }
                }
            }
        }

        public static void SumChetn()
        {
            using (StreamReader reader = new StreamReader(new FileStream("C:\\Users\\user\\Desktop\\lab5.2.txt", FileMode.Open)))
            {
                string str = reader.ReadLine();
                string[] arr = str.Split(' ');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0 && Convert.ToInt32(arr[i]) % 2 == 0)
                    {
                        Console.Write("{0} ", arr[i]);
                    }
                }

            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    InputDouble();
                    Console.WriteLine();
                    Equa();
                    Console.WriteLine();
                    polozh();
                    Console.WriteLine();
                    Arifm();
                    break;

                case 2:
                    InputChars();
                    break;

                case 3:
                    SumChetn();
                    break;
            }
                
        }
    }
}

