using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int oldestMember = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == oldestMember);
        }

        public void PrintMembers()
        {
            foreach (var person in familyMembers.OrderBy(member => member.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
