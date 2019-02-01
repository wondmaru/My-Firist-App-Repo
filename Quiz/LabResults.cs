using System;
namespace Quiz
{
    public class LabResults
    {
        public void ElMeterconverter()
        {
            double current=0;
            double voltage=0;
            double resistance=0;
            Console.WriteLine("Please choose to witch you would like to convert to.");
            Console.WriteLine ("1. Current \n2. Voltage \n3. Resistance");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("Please enter the current ");
               current=double.Parse(Console.ReadLine()); 
               Console.WriteLine("Please enter the Resistance ");
               resistance=double.Parse(Console.ReadLine()); 
                voltage=current*resistance;
                Console.WriteLine("voltage= "+ voltage);
                break;
                case 2:
                Console.WriteLine("Please enter the voltage ");
               voltage=double.Parse(Console.ReadLine()); 
               Console.WriteLine("Please enter the Resistance ");
               resistance=double.Parse(Console.ReadLine()); 
                current=voltage/resistance;
                Console.WriteLine("Current= "+ current);
                break;
                case 3:
                Console.WriteLine("Please enter the current ");
               current=double.Parse(Console.ReadLine()); 
               Console.WriteLine("Please enter the voltage ");
               voltage=double.Parse(Console.ReadLine()); 
                resistance=voltage/current;
                Console.WriteLine("Resistance= "+ resistance);
                break;
                default:
                Console.WriteLine("Your choice is outside of the given range do you like to coninue again? (Y/N)");
                string ans=Console.ReadLine();
                
                if (ans=="Y")
                {
                   ElMeterconverter(); 
                }
                break;
            }
        }
    }
}