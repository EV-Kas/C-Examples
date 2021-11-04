using System;

namespace Threads
{
    public class Person
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        
        private readonly object balanceLock = new object();

        public Person(string name, int age)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
        }

        public void SetName(string name)
        {
            /*lock (balanceLock)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
            }*/
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void SetAge(int age)
        {
            /*lock (balanceLock)
            {
                Age = age;
            }*/
            Age = age;
        }
    }
}