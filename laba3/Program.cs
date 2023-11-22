using System.Text;
using System.Text.RegularExpressions;

namespace labfile
{
    class Class1
    {
        static void Writing(StreamWriter writer, string a1, string a2, StringBuilder temp, int digit)
        {
            string strdigit = digit.ToString("D4");
            
            writer.WriteLine("{0} {1} --> {2} {3}", a1, a2, temp, strdigit);
        }
        
        
        
        
        static void Reading()
        {
            StreamWriter writer = new("C:\\Users\\user\\Downloads\\output_1 (1).txt");
            StreamReader reader = new("C:\\Users\\user\\Downloads\\input_1 (1).txt");
            reader.ReadLine();//plate numbers
            string str = reader.ReadLine();
            (string, int) tuple;
            int count = 0;
            while (str != null)
            {
                if (!Regex.IsMatch(str, "[A-Z]{3}\\s\\d{4}"))
                {
                    writer.WriteLine(str + "--> не соответсвует формату входных данных");
                    count++;
                }
                else
                {
                    count++;
                    tuple = (str.Split()[0], Convert.ToInt32(str.Split()[1]));
                    Preobr(writer, tuple);
                }
                str = reader.ReadLine();
            }
            writer.Close();
            reader.Close();
        }

        static void Preobr(StreamWriter writer, (string, int) tuple)
        {
            string a1 = tuple.Item1;
            string a2 = tuple.Item2.ToString("D4");
            StringBuilder temp = new StringBuilder(tuple.Item1);
            int digit = Convert.ToInt32(tuple.Item2);
            if (digit == 9999 && temp[0] == 'Z' && temp[1] == 'Z' && temp[2] == 'Z')
            {
                writer.WriteLine("{0} {1} --> The last one", a1, a2);
            }
            if (digit != 9999)
            {
                digit++;
                Writing(writer, a1, a2, temp, digit);
            }
            else
            {
                if (temp[2] == 'Z' && temp[1] == 'Z' && temp[0] != 'Z')
                {
                    temp[0] = Convert.ToChar(Convert.ToInt32(temp[0]) + 1);
                    temp[1] = 'A';
                    temp[2] = 'A';
                    Writing(writer, a1, a2, temp, digit);

                }
                else if (temp[2] == 'Z' && temp[1] != 'Z')
                {
                    temp[1] = Convert.ToChar(Convert.ToInt32(temp[1]) + 1);
                    temp[2] = 'A';
                    Writing(writer, a1, a2, temp, digit);
                }
                else if (temp[2] != 'Z')
                {
                    temp[2] = Convert.ToChar(Convert.ToInt32(temp[2]) + 1);
                    Writing(writer, a1, a2, temp, digit);
                }
            }
        }




        static void Main(string[] args)
        {

            Reading();
        }
    }
}