using System;
namespace Lessons
{
    public class Triceratops :Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats");
        }
        public override void Fly()
        {
           Console.WriteLine("The Triceratops flies very high!") ;  
        }
    }
}