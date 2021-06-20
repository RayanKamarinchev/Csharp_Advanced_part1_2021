﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AgeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<(string, int), int, bool> younger = (person, age) => person.Item2 <= age;
            Func<(string, int), int, bool> older = (person, age) => person.Item2 > age;
            int n = int.Parse(Console.ReadLine());
            List<(string name, int age)> people = new List<(string name, int age)>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add((person[0], int.Parse(person[1])));
            }

            string condition = Console.ReadLine();
            int filter = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split();

            switch (condition)
            {
                case "younger":
                    people = people.Where(p => younger(p,filter)).ToList();
                    break;
                case "older":
                    people = people.Where(p => older(p, filter)).ToList();
                    break;
                default:
                    break;
            }

            foreach (var person in people)
            {
                List<string> output = new List<string>();
                if (format.Contains("name"))
                {
                    output.Add(person.name);
                }
                if (format.Contains("age"))
                {
                    output.Add(person.age.ToString());
                }
                Console.WriteLine(string.Join(" - ",output));
            }
        }
    }
}
