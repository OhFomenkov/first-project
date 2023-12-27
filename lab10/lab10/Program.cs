using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using lab10;

namespace lab10_file
{
    class Project
    {
        private static void PrintQueue(Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                string word = queue.Dequeue();
                Console.Write($"{word} ");
            }
        }

        private static void PrintQueue(Queue<int> queue)
        {
            while (queue.Count > 0)
            {
                int word = queue.Dequeue();
                Console.Write($"{word} ");
            }
        }

        private static void PrintQueue(Queue<Employee> queue)
        {
            while (queue.Count > 0)
            {
                Employee employee = queue.Dequeue();
                Console.WriteLine("=============================================================");
                Console.WriteLine($"ФИО: {employee.Name} {employee.Surname} {employee.lastname}");
                Console.WriteLine($"Пол: {employee.sex}");
                Console.WriteLine($"Возраст: {employee.age}");
                Console.WriteLine($"Заработная плата: {employee.zp}");
            }
        }


        public static void CalculateFormula(string formula)
        {
            Stack<char> stack = new Stack<char>();
            Stack<int> values = new Stack<int>();

            for (int i = 0; i < formula.Length; i++)
            {
                char c = formula[i];

                if (c == ' ')
                {
                    continue;
                }
                else if (c == 'M' || c == 'm')
                {
                    stack.Push(c);
                }
                else if (Char.IsDigit(c))
                {
                    int value = c - '0';
                    values.Push(value);
                }
                else if (c == ')' && values.Count > 1)
                {
                    EvaluateExpression(stack, values);
                }
            }

            Console.WriteLine(values.Pop());
        }

        private static void EvaluateExpression(Stack<char> stack, Stack<int> values)
        {
            char operation = stack.Pop();

            if (operation == 'M')
            {
                int operand2 = values.Pop();
                int operand1 = values.Pop();
                int result = Math.Max(operand1, operand2);
                values.Push(result);
            }
            else if (operation == 'm')
            {
                int operand2 = values.Pop();
                int operand1 = values.Pop();
                int result = Math.Min(operand1, operand2);
                values.Push(result);
            }
        }

        static string ReverseStr(string str)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                temp.Append(str[i]);
            }
            return temp.ToString();
        }


        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    ex1();
                    break;
                case 2:
                    ex2();
                    break;
                case 3:
                    ex3();
                    break;
            }
        }

        public static void ex1()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:

                    Console.WriteLine("Введите 2 строки");
                    string s1 = Console.ReadLine();
                    string s2 = Console.ReadLine();

                    StringBuilder sb = new();

                    Stack<char> stack1 = new Stack<char>();
                    if (s1.Length != s2.Length)
                    {
                        Console.WriteLine("false");
                    }

                    for (int i = 0; i < s1.Length; i++)
                    {
                        stack1.Push(s1[i]);
                    }

                    while (stack1.Count > 0)
                    {
                        sb.Append(stack1.Pop());
                    }

                    if (sb.ToString().Equals(s2))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                    break;

                case 2:
                    string expression = Console.ReadLine();
                    Stack<double> stack = new Stack<double>();

                    string[] tokens = expression.Split(' ');

                    for (int i = tokens.Length - 1; i >= 0; i--)
                    {
                        string token = tokens[i];

                        if (IsOperator(token))
                        {
                            double operand1 = stack.Pop();
                            double operand2 = stack.Pop();

                            double result = PerformOperation(token, operand1, operand2);
                            stack.Push(result);
                        }
                        else
                        {
                            double operand = double.Parse(token);
                            stack.Push(operand);
                        }
                    }

                    Console.WriteLine(stack.Pop());
                    break;

                case 3:
                    var sr = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\formula.txt");
                    string formula = sr.ReadLine();

                    CalculateFormula(formula);
                    break;

                case 4:
                    StringBuilder temp = new StringBuilder();
                    int count = 0;
                    Stack<char> st = new Stack<char>();
                    string str = Console.ReadLine();
                    char sym = '#';
                    for (int i = 0; i < str.Length; i++)
                    {
                        st.Push(str[i]);
                    }
                    for (int j = 0; j < str.Length; j++)
                    {
                        char c = st.Pop();
                        if (c != '#' && count == 0)
                        {
                            temp.Append(c);
                        }
                        if (c != '#' && count > 0)
                        {
                            count--;
                        }
                        if (c == '#')
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ReverseStr(temp.ToString()));

                    break;


            }

            static bool IsOperator(string token)
            {
                return token == "+" || token == "-" || token == "*" || token == "/";
            }

            static double PerformOperation(string token, double operand1, double operand2)
            {
                switch (token)
                {
                    case "+":
                        return operand1 + operand2;
                    case "-":
                        return operand1 - operand2;
                    case "*":
                        return operand1 * operand2;
                    case "/":
                        return operand1 / operand2;
                    default:
                        throw new ArgumentException("Неверный оператор: " + token);
                }
            }

        }


        public static void ex2()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\Queue\\Queue1.txt");
                    Console.WriteLine("Введите интервал [a;b]");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    Queue<int> interval = new Queue<int>();
                    Queue<int> before = new Queue<int>();
                    Queue<int> after = new Queue<int>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.Parse(line) <= b && int.Parse(line) >= a)
                        {
                            interval.Enqueue(int.Parse(line));
                        }
                        if (int.Parse(line) < a)
                        {
                            before.Enqueue(int.Parse(line));
                        }
                        if (int.Parse(line) > b)
                        {
                            after.Enqueue(int.Parse(line));
                        }
                    }
                    PrintQueue(interval);
                    PrintQueue(before);
                    PrintQueue(after);
                    sr.Close();
                    break;

                case 2:
                    StreamReader reader = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\Queue\\queue2.txt");
                    string q;
                    Queue<string> vowel = new Queue<string>();
                    Queue<string> consonant = new Queue<string>();
                    while ((q = reader.ReadLine()) != null)
                    {
                        q.ToLower();
                        string[] args = Regex.Split(q, @"\W+");
                        foreach (string item in args)
                        {
                            if ("уеыаоэяию".Contains(item[0]))
                            {
                                vowel.Enqueue(item);
                            }
                            else
                            {
                                consonant.Enqueue(item);
                            }
                        }
                    }
                    reader.Close();
                    PrintQueue(vowel);
                    PrintQueue(consonant);
                    break;


                case 3:
                    StreamReader read = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\Queue\\Queue3.txt");
                    Queue<string> Upper = new Queue<string>();
                    Queue<string> Lower = new Queue<string>();
                    string lines;
                    while ((lines = read.ReadLine()) != null)
                    {
                        string[] words = Regex.Split(lines, @"\W+");
                        char r;
                        foreach (string word in words)
                        {
                            r = word[0];
                            if (r == char.ToUpper(r))
                            {
                                Upper.Enqueue(word);
                            }
                            else
                            {
                                Lower.Enqueue(word);
                            }
                        }
                    }
                    read.Close();
                    PrintQueue(Lower);
                    Console.WriteLine();
                    PrintQueue(Upper);
                    break;

                case 4:
                    StreamReader re = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\Queue\\Queue4.txt");
                    List<Employee> staff = new List<Employee>();
                    string dat;
                    while ((dat = re.ReadLine()) != null)
                    {
                        Employee employe = new Employee();
                        string[] data = dat.Split(',');

                        employe.Name = data[0].Trim();
                        employe.Surname = data[1].Trim();
                        employe.lastname = data[2].Trim();
                        employe.sex = data[3].Trim();
                        employe.age = int.Parse(data[4].Trim());
                        employe.zp = double.Parse(data[5].Trim());

                        staff.Add(employe);
                    }
                    re.Close();

                    Queue<Employee> yanger = new Queue<Employee>();
                    Queue<Employee> older = new Queue<Employee>();

                    foreach (Employee employe in staff)
                    {
                        if (employe.age < 30)
                        {
                            yanger.Enqueue(employe);
                        }
                        else
                        {
                            older.Enqueue(employe);
                        }
                    }
                    PrintQueue(yanger);
                    PrintQueue(older);
                    break;
            }
        }

        private static void ex3()
        {
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\ex3\\ex3.txt");
            StreamReader sr_counter = new StreamReader("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\ex3\\ex3.txt");
            StreamWriter wr = new StreamWriter("C:\\Users\\user\\Desktop\\labC#\\lab10\\lab10\\ex3\\ex3out.txt");
            string line;
            Console.WriteLine("Введите кол-во строк на странице");
            int str = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string a;
            SortedDictionary<string, (int, SortedSet<int>)> dict = new SortedDictionary<string, (int, SortedSet<int>)>();
            sr_counter.Close();
            while ((line = sr.ReadLine()) != null)
            {
                count++;
                line = line.ToLower();
                string[] words = Regex.Split(line, @"\W+");
                foreach (string word in words)
                {
                    if (dict.Count == 0)
                    {
                        dict.Add(word, (1, new SortedSet<int>() { count % str == 0 ? count/str : count/str + 1}));
                    }
                    else
                    {

                        if (dict.Keys.Contains(word))
                        {
                            (int, SortedSet<int>) tp = dict[word];
                            tp.Item1++;
                            tp.Item2.Add(count % str == 0 ? count / str : count / str + 1);
                            dict[word] = tp;
                        }
                        else
                        {
                            dict.Add(word, (1, new SortedSet<int>() { count % str == 0 ? count / str : count / str + 1 }));
                        }
                    }
                }
            }
            List<char> chars = new List<char>();
            dict.Remove("");
            foreach (string keys in dict.Keys)
            {
                if (!chars.Contains(keys[0]))
                {
                    chars.Add(keys[0]);
                    wr.WriteLine(char.ToUpper(keys[0]));
                }

                wr.Write($"{keys}.....................{dict[keys].Item1}:");
                foreach (int item in dict[keys].Item2)
                {
                    wr.Write($"{item} ");
                }
                wr.WriteLine();
            }


            wr.Close();
            sr.Close();

        }
    }
}