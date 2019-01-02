using System;
namespace Classwork
{
    public class CellPhone
    {

        string _screen;
        int _powerButton;
        string _battrey;


        public string Screen
        {
            get
            {
                return _screen;
            }
            set
            {
                this._screen = value;
            }

        }

        public string Battrey
        {
            get
            {
                return _battrey;
            }
            set
            {
                this._battrey = value;
            }
        }


        public int PowerButton
        {
            get
            {
                return _powerButton;
            }
            set
            {
                this._powerButton = value;
            }

        }
        public void PowerOn()
        {
            Console.WriteLine("Wellcome, your cellphone is ON.");
           // PowerButton = 1;
           // return PowerButton;
        }

        public void Poweroff()
        {
            Console.WriteLine(" Your cellphone is Closing Bye.");
           // PowerButton = 0;
            //return PowerButton;
        }
    }

}
