using System;
using Lessons;
using Quiz;
using System.Drawing;
using Advanced;

/* this Name space represents the file folder 
where the class is in */
namespace Classwork
{
    // class is a blue print of an oject.
    class Program

    {
        public delegate void TryOn(string type);
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // House myHouse = new House();

            //myHouse.PaintDoor = "Red";
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
            // Lesson11();
            // ConvertTemp();
            // AbstractDemo();
            //DeconstructSample();
            //FinalizerExaple();
            // IndexerExample();
            // PartialSample();
            //RectangleDemo();
            // MyhouseDemo();
            //GenericSample();
            // CollectionExample();
            //ElMeterconverter();
            // MyTvs();
            // MyLeapYear();
            // HumanYar();
            // DeligateSample();
            MultiDelegateSample();
        }

        private static void DeligateSample()
        {
            Hat myHat = new Hat("cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I tryon a" + myHat.HatType + " hat that was size" + myHat.HatSize);
            Hat mySecondHat = new Hat();
        }
        private static void MultiDelegateSample()
        {
            Hat moreHat = new Hat(7);
            TryOn someHat, niceHat, sadHat;
            niceHat = moreHat.FindLuckuHat;
            niceHat("Top");
            sadHat = moreHat.FindLuckuHat;
            sadHat("Dunce");
            someHat = niceHat + sadHat;
            someHat("Cowboy");




        }
        static void HumanYar()
        {
            DogeYear myDog = new DogeYear();
            myDog.CalculateDogeYear();
        }
        static void MyLeapYear()
        {
            QuizLab myleap = new QuizLab();
            myleap.IsLeapYear();
        }
        static void MyTvs()
        {
            HDTv mytv = new HDTv();
            FourKTV mytv1 = new FourKTV();
            /* if (mytv.Model() == "HD")
             {
                 mytv.GetInput();
                 Console.Clear();
                 mytv.HD();
                 mytv.Display();

             }
             else
             {
                 mytv1.GetInput();
                 Console.Clear();
                 mytv1.FourKs();
                 mytv1.Display();
             }*/

        }
        static void CollectionExample()
        {
            ColectionExamples myColecctionExample = new ColectionExamples();
            myColecctionExample.MyArrayListExample();
            myColecctionExample.MyListExample();
        }
        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);
            GenericList<string> mySecodlist = new GenericList<string>();
            mySecodlist.Add("Happy");
            GenericList<TRex> myTrexList = new GenericList<TRex>();
            myTrexList.Add(new TRex());

        }
        static void MyhouseDemo()
        {
            House myhouse = new House();
            myhouse.Roof = "shingles";
            House myhouse2 = new House("conceret", "Double Pane");
            House myhouse3 = new House()
            {
                Roof = "Shingles",
                Window = "double Pane",
                PaintDoor = "red",
                Foundation = "Conceret"

            };
            Console.WriteLine("My windows choiceis {0}", myhouse3.Window);

        }
        static void RectangleDemo()
        {
            Point myPoint = new Point(6, 10);
            MyRectangle myRectangle = new MyRectangle(40, 10, myPoint, ConsoleColor.Red);
            myRectangle.Draw();
            myRectangle.PrintString();
        }


        static void PartialSample()
        {
            Pear pear = new Pear("Yellow");

        }
        static void IndexerExample()
        {
            IndexerExample myIndexer = new IndexerExample();

            myIndexer[2] = 250;
            //Console.Write("Value: ");
            for (int i = 0; i < myIndexer.Length; i++)
            {
                Console.Write("value  {0} = {1}", i, myIndexer[i]);
            }

        }
        static void FinalizerExaple()
        {
            string first = "John", last = "Carry";
            FinalizerExample finalizerExample = new FinalizerExample(first, last);
            Console.WriteLine("Frist Name: {0} \n Last Name: {1}", first, last);

        }

        static void DeconstructSample()
        {
            string first = "John", last = "Doe";
            Lesson13 lesson13 = new Lesson13(first, last);
            Console.WriteLine("Frist Name: {0} \n Last Name: {1}", first, last);
            lesson13.Deconstruct(out first, out last);
            Console.WriteLine("Frist Name: {0} \n Last Name: {1}", first, last);
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
            Console.WriteLine(myTestName + ", " + myTestSecondName);
            Console.WriteLine(middle);

            // Output - myTestName = John & mySecondName = Doe

            // mylesson11.OutSample("John Doe", out string first, out string second);
            //Console.WriteLine(first);
            //  Console.WriteLine(second);
        }
        public static void ElMeterconverter()
        {
            LabResults myelectricconv = new LabResults();
            myelectricconv.ElMeterconverter();
        }
        public static void ConvertTemp()
        {
            Console.WriteLine("Please select the convertor");
            Console.WriteLine("1. Degree Celsius to Fahrenheit.");
            Console.WriteLine("2. Degree Fahrenheit to Celsius.");
            Console.Write(":");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the temperature in Celsius : ");
                    F = Utilities.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Please enter the temperature in Fahrenheit : ");
                    C = Utilities.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();
            triceratops.EatFood();
            triceratops.Move();
            trex.Fly();
            trex.Fight();
            triceratops.Fight();
            triceratops.Fly();
            trex.Teeth();
            trex.SkinType();
            triceratops.Teeth();
            triceratops.SkinType();

        }

    }

}

