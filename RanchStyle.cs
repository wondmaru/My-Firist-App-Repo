using System;
namespace Classwork
{
    public class RanchStyle:House
    {
        public RanchStyle(string Foundation, string Window, string roof, string doorPaint)
        : base  (Foundation,Window,roof,doorPaint )
        {
            Console.WriteLine("Ranch Style Constructor");
        }
    }
}