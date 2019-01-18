using System;
namespace Lessons
{
    public class Triceratops :Dinosaur , IPrehistoric
    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats");
        }
        public override void Fly()
        {
           Console.WriteLine("The Triceratops flies very high!") ;  
        }
        public  override void SkinType()
        {
            Console.WriteLine("Feathery like Trex");
        }
        public   string Teeth()
        {
             return "Supper Razor Sharp" ;
        }
    }
}