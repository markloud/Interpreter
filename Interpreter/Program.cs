using Interpreter;
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string tokenString = "+ - 10 2 3"; // Reverse Polish Notation
        List<string> tokenList = new List<string>(tokenString.Split(' '));

        IExpression expression = new TokenReader().ReadToken(tokenList);
        Console.WriteLine(expression.Interpret());    // (10 - 2) + 3 = 11

        tokenString = "- + 10 5 - 8 2";
        tokenList = new List<string>(tokenString.Split(' '));

        expression = new TokenReader().ReadToken(tokenList);
        Console.WriteLine(expression.Interpret());   // (10 + 5) - (8 - 2) = 9

        Console.ReadKey();
    }
}