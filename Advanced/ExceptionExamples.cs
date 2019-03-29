using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string _ExampleNull = null;
        public void Myexception()
        {
            try
            {

                Console.WriteLine(_ExampleNull);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Exception thrown " + ex.Message);
            }
        }

        public void MyarrayException()
        {
            string[] names = { "Dave", "Matt", "Judy" };

            try
            {
                byte b = byte.Parse(names[1]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least 1 argument");
            }
            catch (FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
            catch (OverflowException a)
            {
                Console.WriteLine("You have given more than a byte");
            }
        }
    }
}
