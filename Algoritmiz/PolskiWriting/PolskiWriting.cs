using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   
        double number1, number2;
        string exmp = "a b + 3 *";
        string[] sumbols = exmp.Split(' ');

        Stack<string> stack = new Stack<string>();

        foreach (string sumbol in sumbols)
        {
            if (sumbol == "*" || sumbol == "-" || sumbol == "+" || sumbol == "/")
            {
                if (stack.Count != 2)
                {
                    Console.WriteLine("неоднозначная запись");
                    return;

                }
                else
                {
                    string operand2 = stack.Pop();
                    string operand1 = stack.Pop();
                    if (double.TryParse(operand1, out number1) && double.TryParse(operand2, out number2))
                    {
                        switch (sumbol)
                        {
                            case "+":
                                stack.Push(Convert.ToString(number1 + number2));
                                break;
                            case "-":
                                stack.Push(Convert.ToString(number1 - number2));
                                break;
                            case "*":
                                stack.Push(Convert.ToString(number1 * number2));
                                break;
                            case "/":
                                if (number2 == 0)
                                {
                                    Console.WriteLine("Деление на ноль!");
                                    return;
                                }
                                stack.Push(Convert.ToString(number1 / number2));
                                break;
                            default:
                                Console.WriteLine("Некорректная операция: " + sumbol);
                                return;
                        }
                    }
                    else
                    {
                        switch (sumbol)
                        {
                            case "+":
                                stack.Push(Convert.ToString("(" + operand1 + " + " + operand2 + ")"));
                                break;
                            case "-":
                                stack.Push(Convert.ToString("(" + operand1 + " - " + operand2 + ")"));
                                break;
                            case "*":
                                stack.Push(Convert.ToString("(" + operand1 + " * " + operand2 + ")"));
                                break;
                            case "/":
                                 if (number2 == "0")
                                {
                                    Console.WriteLine("Деление на ноль!");
                                    return;
                                }
                                stack.Push(Convert.ToString("(" + operand1 + " / " + operand2 + ")"));
                                break;
                            default:
                                Console.WriteLine("Некорректная операция: " + sumbol);
                                return;
                        }
                    }

                }
            }
            else
            {
                stack.Push(sumbol);
            }
        }

        Console.WriteLine("Результат вычисления: " + stack.Pop());

    }
}
