using System;

namespace helloWorld
{

    class Person
    {
        private string name;

        public void showName()
        {
            Console.WriteLine(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string i = "1000";
                byte b = Convert.ToByte(i);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine(":/");
            }
            
        }
    }
}
