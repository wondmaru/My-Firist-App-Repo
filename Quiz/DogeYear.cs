using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class DogeYear
    {
        public void CalculateDogeYear()
        {
            int[,] dogYeararr = { { 40, 42, 45 }, { 44, 47, 50 }, { 48, 51, 55 }, { 52, 56, 61 }, { 56, 60, 66 },
                { 60, 65, 72 }, { 64, 69, 77 }, { 68, 74, 82 }, { 72, 78, 88 }, { 76, 83, 93 }, { 80, 87, 120 } };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dogYeararr[i, j]);
                }
            }

            Console.WriteLine("Please enter the age of your doge.");
            int dogyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please choose  the size of your doge.\n1. Small\n2. Medium\n3. Large ");

            int dogwWight = int.Parse(Console.ReadLine());
            if (dogyear <= 5)
            {
                switch (dogyear)
                {
                    case 1:
                        Console.WriteLine("Your dog's age in human years is 15 ");
                        break;
                    case 2:
                        Console.WriteLine("Your dog's age in human years is 24 ");
                        break;
                    case 3:
                        Console.WriteLine("Your dog's age in human years is 28 ");
                        break;
                    case 4:
                        Console.WriteLine("Your dog's age in human years is 32 ");
                        break;
                    case 5:
                        Console.WriteLine("Your dog's age in human years is 36 ");
                        break;
                }


            }
            else if (dogyear > 5)
            {
                int index1 = dogyear - 6;
                int index2 = dogwWight - 1;
                Console.WriteLine("Your dog's age in human years is " + dogYeararr[index1, index2]);
            }

        }
    }
}
