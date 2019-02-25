using System;
namespace Quiz
{
    public class HDTv : Television
    {
        /* public override string GetInput()
         {
             Console.WriteLine("Please Enter Model.");
            model=Console.ReadLine();
            Console.WriteLine("Please Enter Price.");
            price=double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Size");
            size=double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number of Ports");
            numofports=int.Parse(Console.ReadLine());
            Console.WriteLine("Is your Television Mountable? (Y/N)");
            mountable=Console.ReadLine();
            return model;
         }*/

        public override void GetInput(double size, double price, int numofports)
        {
            throw new NotImplementedException();
        }

        /* public override void HD()
         {

             Console.WriteLine("Your TV model is HD");

         }*/

    }
}