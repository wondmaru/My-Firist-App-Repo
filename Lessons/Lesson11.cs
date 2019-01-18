using System;
namespace Lessons
{
    public class Lesson11
    {
        public const int My_Value = 25;
        public void SampleLesson11()
        {
            //My_Value =35; //can not change the value
            // can use it with other variables
            int total = My_Value * 2;
            Console.WriteLine(total);
        }
        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old.");
        }
        public void RefSample(ref int value)
        {
            value = value + 5;

            Console.WriteLine(value);
        }


        public void OutSample(string name, out string firstName, out string lastName, out string middle)
        {
            int myIndex = name.IndexOf(' ');
            firstName = name.Substring(0, myIndex);
            string othername = name.Substring(myIndex + 1);
            int myother = name.LastIndexOf(' ');
            middle = othername.Substring(0, myother);
            lastName = name.Substring(myIndex + 1);
        }

    }
}