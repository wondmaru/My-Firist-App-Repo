using System;
namespace Classwork
{
    public class House
    {
        // The following are fields
        string _foundation;
        // string _roof;
        string _window;
        string _door;


        public string Foundation
        {
            get
            {
                return _foundation;

            }
            set
            {
                this._foundation = value;
            }
        }

        public string Roof { get; set; }
        public string PaintDoor { get; set; }
        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }

        public House() { }

        public House(string Foundation, string Window)
        :this (Foundation, Window, "shingles" ,"Green")
        {
            
        }

        public House(string Foundation, string Window, string roof, string doorPaint)
        {
            this._foundation = Foundation;
            this._window = Window;
            this.Roof = roof;
            this.PaintDoor = doorPaint;

        }
        //The following are methods 
        public void OpenDoor()
        {
            Console.WriteLine("The Door Opens");
        }
        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open Front Door.");
            }
            else
                Console.WriteLine("Open Bed Room Door.");
        }
        public void CloseDoor()
        {
            Console.WriteLine("The Door Closes");
        }


    }
}