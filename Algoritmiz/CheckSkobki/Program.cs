using System;
using System.Collections.Generic;
class Program
{
    static bool CheckSkobki(string input)
    {
        Dictionary<char, char> Pairs = new Dictionary<char, char>
{
{ '(', ')' },
{ '[', ']' },
{ '{', '}' }
};
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (Pairs.ContainsValue(c))
            {
                if (stack.Count == 0 || Pairs[stack.Peek()] != c)
                {
                    return false;
                }
                stack.Pop();
            }
            else if (Pairs.ContainsKey(c))
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(CheckSkobki(input));
    }
}