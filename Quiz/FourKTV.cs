using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz 
{
    class FourKTV:Television
    {
        public override void GetInput(double size2 = 85, double price2 = 1500, int numofports2 = 9)
        {
            this.size = size2;
            this.price = price2;
            this.numofports = numofports2;

            Console.WriteLine("Is your Television Mountable? (Y/N)");
            mountable = Console.ReadLine();
            mountable.ToUpper();
        }

        public virtual void FourKs()
        {
            Console.WriteLine("Your TV model is 4K");
        }
    }
}
