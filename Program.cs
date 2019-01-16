using System;
using Lessons;
using Quiz;

/* this Name space represents the file folder 
where the class is in */
namespace Classwork
{
    // class is a blue print of an oject.
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // House myHouse = new House();

            // myHouse.PaintDoor = "Red";
            //myHouse.CloseDoor();

            // Console.WriteLine(myHouse.PaintDoor);

            // House mySecondHouse = new House();
            //  mySecondHouse.PaintDoor = "green";
            //  Console.WriteLine(mySecondHouse.PaintDoor);
            // Console.WriteLine(myHouse.PaintDoor);

            /*  CellPhone mycellphone = new CellPhone();
           //  mycellphone.Screen = "Full HD";
           //  mycellphone.Battrey = "Lithium ion";
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
             }*/
            //  mycellphone.PowerOn ();
            //mycellphone.Poweroff ();
            //  Console.WriteLine(mycellphone.Screen);
            // Console.WriteLine(mycellphone.Battrey);
            // MyNumbericExamples();
            //   OtherNumbericExamples();
            //  MyStringExamples();
            //  StatmentExamples();
            //   BottlesSong();
            //   HouseSample();
            //  structSample();
            // QuizClass1();
            // FruitSample();
            Lesson11();
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

        static void structSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Zombi Fallout", "Mark Tufo");
            Console.WriteLine("The book " + bookSample.title + "by" + bookSample.author + "is $" + bookSample.price);
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
        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple Pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);
            myHouse.OpenDoor(true);
        }
        /*  static void BottelsOfBeerSample()
         {
             BottleOfBeer beer = new BottleOfBeer();
             beer.BottleOfBeerSong(99, "bottle");
         }*/
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
            myStatmentExample.SampleDays(DaysOfWeek.Wed);


        }
        static void BottlesSong()
        {
            BottleOfBeer beer = new BottleOfBeer();
            string song = beer.BottleOfBeerSong();
            Console.WriteLine(song);
            //beer.BottleOfBeerSong(99, "bottle");
        }
        static void QuizClass1()
        {
            QuizClass1 myQuizClass1 = new QuizClass1();
            Console.WriteLine("Please Enter Grade.");

            string grade = myQuizClass1.GreadeAndDesciption(Console.ReadLine().ToUpper());
            Console.WriteLine(grade);
            myQuizClass1.DivisibleByThree();


        }
        static void FruitSample()
        {
            Fruit myFruit = new Fruit();
            myFruit.EatFruit();
            Apple myApple = new Apple();
            myApple.EatFruit();
            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
            Console.WriteLine(ranch.PaintDoor);
        }

        static void Lesson11()
        {
            Lesson11 mylesson11 = new Lesson11();
            mylesson11.SampleLesson11();
            mylesson11.UseParams2(10, 3, 36, 45, 120);
            int[] intArray = { 2, 3, 4, 5, 6 };
            mylesson11.UseParams(intArray);
            mylesson11.UseParams2(1, "Happy", false, 34.5F);
            mylesson11.OptionalParam("Alex");
            mylesson11.OptionalParam("Alex", 19);
            int test = 14;
            mylesson11.RefSample(ref test);
            //String myTestName, myTestSecondName;

            mylesson11.OutSample("John Doe Riley", out string myTestName, out string myTestSecondName, out string middle);

          // Console.WriteLine(myTestName);
            Console.WriteLine(myTestName + ", " + myTestSecondName  );
           Console.WriteLine (middle);

            // Output - myTestName = John & mySecondName = Doe

           // mylesson11.OutSample("John Doe", out string first, out string second);
            //Console.WriteLine(first);
          //  Console.WriteLine(second);
        }

    }

}

