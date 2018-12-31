using System;
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
           int val= mycellphone.PowerButton ;
            if ( val== 1 )
            {
                mycellphone.Poweroff();
            }
            else
            {
                mycellphone.PowerOn();
            }
            //  mycellphone.PowerOn ();
            //mycellphone.Poweroff ();
            Console.WriteLine ( mycellphone.Screen);
            Console.WriteLine ( mycellphone.Battrey);
        }

    }
}
