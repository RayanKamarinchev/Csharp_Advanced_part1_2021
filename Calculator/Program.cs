using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> charInput = new Stack<char>();
            Stack<char> calculateText = Reverse(charInput);
            while (calculateText.Count>0)
            {
                bool isItPlus = true;
                bool operationPassed = false;
                string firstDigit = "";
                string secondDigit = "";
                char symbol = calculateText.Pop();
                if (symbol==' ')
                {
                    continue;
                }
                else if (symbol == '+' || symbol=='-')
                {
                    if (operationPassed)
                    {
                        if (isItPlus)
                        {
                            firstDigit = Convert.ToString(int.Parse(firstDigit) + int.Parse(secondDigit));
                        }
                        else
                        {
                            firstDigit = Convert.ToString(int.Parse(firstDigit) - int.Parse(secondDigit));
                        }
                        operationPassed = true;
                    }
                    if (symbol == '+') 
                    {
                        isItPlus = true;
                    }
                    else
                    {
                        isItPlus = false;
                    }
                    
                }
                else
                {
                    if (operationPassed)
                    {
                        secondDigit += symbol;
                    }
                    else
                    {
                        firstDigit += symbol;
                    }
                }
            }
        }
        
        static Stack<char> Reverse(Stack<char> str)
        {
            Stack<char> original = new Stack<char>();
            for (int i = 0; i < str.Count; i++)
            {
                original.Push(str.Pop());
            }
            return original;
        }
    }
}
