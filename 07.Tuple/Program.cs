using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = $"{personInfo[2]}";
            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var Liters = int.Parse(nameAndBeer[1]);
            var numbersInput = Console.ReadLine().Split();
            var intNum = int.Parse(numbersInput[0]);
            var doubleNum = double.Parse(numbersInput[1]);
            Tuple<string, string> firstTupe = new Tuple<string, string>(fullName, city);
            Tuple<string, int> secondTupe = new Tuple<string, int>(name, Liters);
            Tuple<int, double> thirdTupe = new Tuple<int, double>(intNum, doubleNum);
            Console.WriteLine(firstTupe);
            Console.WriteLine(secondTupe);
            Console.WriteLine(thirdTupe);
        }
    }
}
