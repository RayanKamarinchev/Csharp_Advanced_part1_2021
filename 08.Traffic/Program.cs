using System;
using System.Collections.Generic;

namespace _08.Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int passedCars = 0;

            while (command!="end")
            {
                if (command=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count==0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
