using System;
namespace Lessons
{
    public class TRex : Dinosaur 
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }
        public override void Move()
        {
            Console.WriteLine("TRex runs");
        }
        public override void Fly()
        {
            Console.WriteLine("The TRex flies very high! ");
        }
        public override void Fight()
        {
            Console.WriteLine("The TRex is fighting for servival.");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathery");
        }
        public override void Teeth()
        {
           Console.WriteLine("Razor Sharp") ;
        }

    }

}