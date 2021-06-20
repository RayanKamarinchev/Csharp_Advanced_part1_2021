using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] properties = Console.ReadLine().Split();
                Person person = new Person(int.Parse(properties[1]),properties[0]);
                family.AddPerson(person);
            }
            //Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
            foreach (var person in family.GetAllPeopleAbove30())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
