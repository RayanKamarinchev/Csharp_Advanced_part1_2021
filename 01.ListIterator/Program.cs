using System;
using System.Linq;

namespace _01.ListIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] command = Console.ReadLine().Split().Skip(1).ToArray();
            
            MyList<string> list = new MyList<string>(command);
            command = Console.ReadLine().Split();
            while (command[0]!="END")
            {
                switch (command[0])
                {                    
                    case "Move":
                        Console.WriteLine(list.Move()); 
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "PrintAll":
                        list.PrintAll();
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
