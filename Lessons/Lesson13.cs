using System;
namespace Lessons
{
    public class Lesson13
    {
        string _firstName, _lastName;
        public Lesson13(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this._firstName;
            lastName = this._lastName;
            Console.WriteLine("Deconstructor Called.");
        }

    }
}


