using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced

{
    public delegate string Mycoat(string message);
    public class Coats
    {
        public event Mycoat MyEventCoat;
        public string MyResult { get; private set; }
        public Coats()
        {
            this.MyEventCoat += new Mycoat(this.MyFavoriteCoat);
            MyResult = MyEventCoat("Trench");
        }
        public string MyFavoriteCoat(string message)
        {
            return "My favorite Coat is " + message;
        }
    }
}
