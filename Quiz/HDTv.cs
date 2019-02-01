using System;
namespace Quiz
{
    public class HDTv : Television
    {
        public void  MyMethods()
        {

        }
        public override void HD()
        {

            Console.WriteLine("Your TV model is HD");

        }
        public override void FourK()
        {
          Console.WriteLine("Your TV model is 4K");  
        }
    }
}