using System;
namespace Lessons
{
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
              Peel();
           // color();
        }
        partial void Peel();
        partial void color();
    }
}