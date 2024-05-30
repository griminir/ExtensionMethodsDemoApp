using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    public static class ExtensionPerson
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 32;
            return person;
        }

        public static PersonModel SetDefaultName(this PersonModel person, string name)
        {
            person.Name = name;
            return person;
        }

        public static PersonModel PrintInfo(this PersonModel person)
        {
            Console.WriteLine(person.FullInfo);
            return person;
        }
    }
}
