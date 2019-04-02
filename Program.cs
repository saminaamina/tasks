using System;

namespace DefClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Гошо";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();

            
        }
    }
}
