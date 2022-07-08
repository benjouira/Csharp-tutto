using System;

namespace helloWorld
{

    class Person
    {
        public string name;

        public static Person CreatePersonInstence(string name)
        {
            var person = new Person();
            person.name = name;
            return person;
        }
        public void showName()
        {
            Console.WriteLine(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.name = "name 1";
            p1.showName();

            var p2 = Person.CreatePersonInstence("3ebsi");
            p2.showName();
        }
    }
}
