using System;
using Lessons;

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
            for (int val = 0; val == 0 || val == 1; val++)
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
            MyStringExamples();
            StatmentExamples();
            BottlesSong();

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
            NumbericTypes myTypes = new NumbericTypes();
            myTypes.OtherOperators();
        }
        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceHolderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }
        static void StatmentExamples()
        {
            StatmentExamples myStatmentExample = new StatmentExamples();
            myStatmentExample.SampleIf();
            myStatmentExample.SampleIfChain();
            myStatmentExample.SampleIfAnd();
            myStatmentExample.SampleOr();
            myStatmentExample.SampleConditional();
            myStatmentExample.SampleSwitch(10);
            myStatmentExample.SampleWhile();
            myStatmentExample.SampleDoWhile();
            myStatmentExample.SampleFor();
            myStatmentExample.SampleForEach();
           string mystring = myStatmentExample.JumpStatmentExample("Sunday");
           Console.WriteLine(mystring);
           

    }
      static void BottlesSong()
        {
            BottleOfBeer beer = new BottleOfBeer();
            string song = beer.BottleOfBeerSong();
            Console.WriteLine(song);
        }
        }
}
