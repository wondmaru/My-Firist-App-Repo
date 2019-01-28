using System;
namespace Lessons
{  //file name pear2
    public partial class Pear
    {
        public Pear(string message,string something)
        {
            Console.WriteLine(message+ "is"+ something);
        }

        partial void Peel()
        {
            Console.WriteLine("I Peeled a Pear");
        }
    }
}