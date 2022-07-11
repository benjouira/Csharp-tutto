using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Person
    {
        public int Id;
        public string Name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(int id , string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static Person CreatePersonInstence(string name)
        {
            var person = new Person();
            person.Name = name;
            return person;
        }
        public void showName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
