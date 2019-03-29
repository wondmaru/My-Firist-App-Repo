using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LambdaExample
    {
        delegate int del(int value);
        public int myLambdaOne(int val)
        {
            //(input-parameters) => expressions or stetment  block
            del myDeligate = x => x * x;
            return myDeligate(val);
        }
    }
}
