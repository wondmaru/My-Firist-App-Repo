using System;
namespace Quiz
{
    public class QuizClass1
    {
        public string GreadeAndDesciption(string grade)
        {



            switch (grade)
            {
                case "A":
                    return " Average";

                case "G":
                    return " Good";

                case "V":
                    return " Very Good ";

                case "E":
                    return " Execllent";

                case "F":
                    return " Fail";


                default:
                    return " That it is not a valid grade";

            }

        }

        public void DivisibleByThree()
        {
            for (int i = 0; i <= 50; i++)

            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}