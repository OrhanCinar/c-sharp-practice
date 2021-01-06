using System;
using System.Collections.Generic;
using System.Text;

public class ExpressionEvaluation
{
    public int Evaluate(string expression)
    {
        char[] tokens = expression.ToCharArray();

        var values = new Stack<int>();

        var ops = new Stack<char>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == ' ')
                continue;

            if (tokens[i] >= '0' && tokens[i] <= '9')
            {
                StringBuilder sbuf = new StringBuilder();
                while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    sbuf.Append(tokens[i++]);
                i = i - 1;
                values.Push(int.Parse(sbuf.ToString()));
            }
            else if (tokens[i] == '(')
                ops.Push(tokens[i]);
            else if (tokens[i] == ')')
            {
                while (ops.Peek() != '(')
                    values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                ops.Pop();
            }
            else if (tokens[i] == '+' || tokens[i] == '-' ||
                    tokens[i] == '*' || tokens[i] == '/')
            {
                while (ops.Count > 0 && HasPrecedence(tokens[i], ops.Peek()))
                    values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));

                ops.Push(tokens[i]);
            }
        }

        while (ops.Count > 0)
            values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));

        return values.Pop();
    }

    private bool HasPrecedence(char op1, char op2)
    {
        if (op1 == '(' || op2 == ')')
        {
            return false;
        }

        if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
        {
            return false;
        }
        else
            return true;
    }

    private int ApplyOp(char op, int b, int a)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/':
                if (b == 0)
                {
                    throw new NotSupportedException("Cannot divide by zero");
                }
                return a / b;

            default:
                return 0;
        }
    }
}