using System;

namespace _05.DataMod
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime lastDate = DateTime.Parse(Console.ReadLine());
            var n = new DateModifier();
            Console.WriteLine(n.DifferenceInDates(firstDate, lastDate));
        }
    }
}
