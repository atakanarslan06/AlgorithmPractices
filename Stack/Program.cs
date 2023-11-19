using System;
using System.Collections.Generic;

class ExpressionEvaluation
{
    // Operatörlerin öncelik seviyeleri
    static int Precedence(char c)
    {
        switch (c)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            case '^':
                return 3;
            default:
                return -1;
        }
    }

    // İfadeyi postfix notasyona dönüştüren metod
    static string InfixToPostfix(string expression)
    {
        string postfix = "";
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < expression.Length; ++i)
        {
            char c = expression[i];

            if (char.IsLetterOrDigit(c))
            {
                postfix += c;
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Count != 0 && stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }

                if (stack.Count != 0 && stack.Peek() != '(')
                {
                    return "Geçersiz İfade";
                }
                else
                {
                    stack.Pop();
                }
            }
            else
            {
                while (stack.Count != 0 && Precedence(c) <= Precedence(stack.Peek()))
                {
                    postfix += stack.Pop();
                }
                stack.Push(c);
            }
        }

        while (stack.Count != 0)
        {
            postfix += stack.Pop();
        }

        return postfix;
    }

    // Postfix ifadeyi değerlendiren metod
    static int EvaluatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            if (char.IsDigit(c))
            {
                stack.Push(c - '0');
            }
            else
            {
                int val1 = stack.Pop();
                int val2 = stack.Pop();

                switch (c)
                {
                    case '+':
                        stack.Push(val2 + val1);
                        break;
                    case '-':
                        stack.Push(val2 - val1);
                        break;
                    case '*':
                        stack.Push(val2 * val1);
                        break;
                    case '/':
                        stack.Push(val2 / val1);
                        break;
                }
            }
        }

        return stack.Pop();
    }

    static void Main()
    {
        string expression = "3+4*5-2/1"; // Değerlendirilecek ifade

        string postfix = InfixToPostfix(expression); // Infix ifadeyi postfix notasyona dönüştür
        Console.WriteLine("Postfix İfade: " + postfix);

        int result = EvaluatePostfix(postfix); // Postfix ifadeyi değerlendir
        Console.WriteLine("İfade Değeri: " + result);
    }
}