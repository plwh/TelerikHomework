// Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Text;

class CorrectBrackets
{
    static string isCorrect(string input)
    { 
        int openedBrackets = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int nextChar = input[i];
            char ch = (char)nextChar;
            if (ch == '(')
            {
                openedBrackets++;
            }
            else if (ch == ')')
            {
                openedBrackets--;
            }
        }
        if(openedBrackets == 0)
        {
            return "brackets are put correctly";
        }
        return "brackets are not put correctly";
    }
    static void Main()
    {      
        string firstExpression = "((a+b)/5-d)";
        string secondExpression = ")(a+b))";
        Console.WriteLine("In expression {0} {1}", firstExpression , isCorrect(firstExpression));
        Console.WriteLine("In expression {0} {1}", secondExpression, isCorrect(secondExpression));
    }
}

