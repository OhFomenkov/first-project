using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace lab10_file
{
    class Project
    {
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
            for(int i = str.Length - 1; i>=0; i--)
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
                    for(int i =0; i< str.Length; i++)
                    {
                        st.Push(str[i]);
                    }
                    for(int j = 0; j<str.Length; j++)
                    {
                        char c  = st.Pop();
                        if (c != '#' && count == 0)
                        {
                            temp.Append(c);
                        }
                        if (c != '#' && count > 0)
                        {
                            count--;
                        }
                        if(c == '#')
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
    }
}