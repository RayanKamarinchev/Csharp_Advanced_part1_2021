
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            members = new HashSet<Person>();
        }

        public void AddPerson(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            return members.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public HashSet<Person> GetAllPeopleAbove30()
        => members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToHashSet();
    }
}
