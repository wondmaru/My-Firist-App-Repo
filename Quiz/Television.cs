using System;
namespace Quiz
{
    public abstract class Television
    {
        double size, price;
        int numofports;
        string mountable; 
        public string model;
        public abstract void HD();
        public abstract void FourK();
        public virtual string GetInput()
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
        }
        public virtual void Display()
        {
            Console.WriteLine("Size: "+ size);
            Console.WriteLine("Number of Ports: "+ numofports);
            Console.WriteLine("Price: "+ price);
            if (mountable=="Y")
            {
                Console.WriteLine("Your Television is Mountable");
            }
            else
            Console.WriteLine("Your Television is not Mountable");
        }
    }
}