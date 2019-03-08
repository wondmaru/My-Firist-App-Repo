using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class Hat
    {
        public delegate void TryHat(string type);
        public string HatType { get; }
        public int HatSize { get; }

        public Hat()
        {
            TryHat myHat = TryOnHat;
            TryALargeHat("fadora", 7, myHat);
        }
        public Hat(int size)
        {
            this.HatSize = size;
        }
        public Hat(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;

        }
        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        public void TryALargeHat(string type, int oldsize, TryHat another)
        {
            another("I tried on a" + type + "Hat at size" + (oldsize + 1).ToString());
        }
        public void FindLuckuHat(string message)
        {
            Console.WriteLine("lucky hat is {0} ", message);
        }
        public void FindUglyHat(string message)
        {
            Console.WriteLine("Ugly the hat is {0} ", message);
        }
    }
}
