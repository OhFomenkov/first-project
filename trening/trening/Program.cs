using System;
using System.Net.Http.Headers;

namespace abra
{
    class pr
    {
        private static bool IsOperator(string token)
        {
            // Проверяем, является ли токен оператором (+, -, *, / и т.д.)
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        static void Main(string[] args)
        {
            string expression = "* + 1 1 2";
            Stack<int> stack = new Stack<int>();

            string[] symbols = expression.Split(' ');

            for (int j = symbols.Length - 1; j >= 0; j--)
            {
                string symbol = symbols[j];

                if (IsOperator(symbol))
                {
                    int op1 = stack.Pop();
                    int op2 = stack.Pop();

                    switch (symbol)
                    {
                        case "+":
                            stack.Push(op1 + op2);
                            break;
                        case "-":
                            stack.Push(op1 - op2);
                            break;
                        case "*":
                            stack.Push(op1 * op2);
                            break;
                        case "/":
                            stack.Push(op1 / op2);
                            break;
                    }
                }
                else
                {
                    stack.Push(int.Parse(symbol));
                }

            }
            Console.WriteLine(stack.Pop());
        }
    }
}