using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class QuizLab
    {
        public void IsLeapYear()
        {
            Console.WriteLine("Please enter year in yyyy format");
            string year = Console.ReadLine();
            while (year.Length!=4)
            {
                Console.WriteLine("Please enter year in the correct  yyyy format\nlike 1920");
                year = Console.ReadLine();
            }
            if (int.Parse(year) % 4==1)
            {
                Console.WriteLine("the year " + year + " is leap year");
            }
            else
            Console.WriteLine("the year " + year + " is not a leap year");




        }
    }
}
