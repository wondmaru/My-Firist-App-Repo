using System;
namespace Quiz
{
    public class HDTv : Television
    {
        public override void GetInput(double size1 = 75, double price1 = 1000, int numofports1 = 6)
        {
        

            this.size = size1;
            this.price = price1;
            this.numofports = numofports1;
  
            Console.WriteLine("Is your Television Mountable? (Y/N)");
           mountable = Console.ReadLine();
            mountable.ToUpper();
        }
        public virtual void HD()
        {

            Console.WriteLine("Your TV model is HD");

        }
        
    }
}