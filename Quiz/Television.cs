using System;
namespace Quiz
{
    public abstract class Television
    {
        protected double size { get; set; }
        protected double price { get; set; }
        protected int numofports { get; set; }
        protected string mountable { get; set; }
        // public string model;
        // public abstract void HD();
        // public abstract void FourK();
        public abstract void GetInput(double size,double price,int numofports);

        public virtual  string Model()
        {
            Console.WriteLine("Please Enter Model.");
             string ans=Console.ReadLine();
           return ans.ToUpper();

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