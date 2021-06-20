using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split();
                if (grades.ContainsKey(token[0]))
                {
                    grades[token[0]].Add(decimal.Parse(token[1]));
                }
                else
                {
                    grades.Add(token[0], new List<decimal> { decimal.Parse(token[1]) });
                }
            }
            foreach (var grade in grades)
            {
                Console.WriteLine($"{grade.Key} -> {string.Join(" ",grade.Value.Select(v => v.ToString("F2")))} (avg: {grade.Value.Average():F2})");
            }
        }
    }
}
