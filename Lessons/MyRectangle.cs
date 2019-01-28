using System;
using System.Drawing;
namespace Lessons
{
    public class MyRectangle
    {
        private int width;
        private int height;
        private Point location;
        private ConsoleColor color;

        public MyRectangle(int mywidth, int myheight, Point mylocation, ConsoleColor myColor)
        {
            Width = mywidth;
            height = myheight;
            location = mylocation;
            color = myColor;

        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Width
        {
            get { return width; }
            set {width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public ConsoleColor BorderColor
        {
            get { return color; }
            set { color = value; }
        }

        public void Draw()
        {
            string s = "╔";
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += "═";
            }

            for (int j = 0; j < Location.X; j++)
                temp += " ";

            s += "╗" + "\n";

            for (int i = 0; i < Height; i++)
                s += temp + "║" + space + "║" + "\n";

            s += temp + "╚";
            for (int i = 0; i < Width; i++)
                s += "═";

            s += "╝" + "\n";

            Console.ForegroundColor = BorderColor;
            Console.CursorTop = location.Y;
            Console.CursorLeft = location.X;
            Console.Write(s);
            Console.ResetColor();
        }

        public void PrintString()
        {
            Console.SetCursorPosition(8, 12);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solomon, it's working!");
            Console.ResetColor();
            Console.SetCursorPosition(0, 23);
        }
    }
}