using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What`s your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("What is your age");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You were born in " + Age);




        }

    }
}
