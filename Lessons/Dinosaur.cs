using System;
namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric
    {

        public abstract void Fly();
        public abstract void EatFood();
        public virtual void Move()
        {

            Console.WriteLine("The Dinosuar Moves");
        }
        public virtual void Fight()
        {
            Console.WriteLine("The Dinosuar Fights");
        }
        public abstract void SkinType();
        public  string Teeth(string teeth)
        {
            return "Sharp Teeth";
        }
    }
}