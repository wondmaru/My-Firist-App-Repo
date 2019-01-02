using System;
using Classwork.lessons;
/* this Name space represents the file folder 
where the class is in */
namespace Classwork
{
    // class is a blue print of an oject.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            House myHouse = new House();
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor();

            Console.WriteLine(myHouse.PaintDoor);

            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor);
            Console.WriteLine(myHouse.PaintDoor);

            CellPhone mycellphone = new CellPhone();
            mycellphone.Screen = "Full HD";
            mycellphone.Battrey = "Lithium ion";
            for (int val = 0; val == 0 || val == 1;val++)
            {
                if (val == 1)
                {
                    mycellphone.Poweroff();
                    //mycellphone.PowerButton++;
                }
                else
                {
                    mycellphone.PowerOn();
                  // mycellphone.PowerButton++; 
                }
            }
            //  mycellphone.PowerOn ();
            //mycellphone.Poweroff ();
            Console.WriteLine(mycellphone.Screen);
            Console.WriteLine(mycellphone.Battrey);
           // MyNumbericExamples();
           OtherNumbericExamples();
        }
        static void MyNumbericExamples()
        {
            NumbericTypes myTypes = new NumbericTypes();
            myTypes.Getsometype();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);
            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();
            myTypes.checkOperators();
            myTypes.IncreamentDecrement();
            myTypes.SpecialValues();
            myTypes.ComparisonOperators();
            myTypes.OtherOperators();
        }

static void OtherNumbericExamples()
{
    NumbericTypes myTypes= new NumbericTypes();
    myTypes.OtherOperators();
}
    }
}
