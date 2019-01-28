using System.Collections;
using System.Collections.Generic;
using System;
namespace Lessons
{
    public class ColectionExamples
    {
        public void MyArrayListExample()
        {
            ArrayList myArraylist = new ArrayList();
            myArraylist.Add("Hello");
            myArraylist.Add("World");
            myArraylist.Add(42);
            myArraylist.Add(84);

            Console.WriteLine("Count= {0}", myArraylist.Count);
            myArraylist.Remove(42);
            myArraylist.RemoveAt(0);
            Console.WriteLine("Count= {0}", myArraylist.Count);

             myArraylist.Add("Other");
              myArraylist.Add("Stuff");
            foreach(object item in myArraylist)
            {
                Console.WriteLine("Type = {0}", item);
            }
        }
        public void MyListExample()
        {
            List<Dinosaur> myDinos = new List<Dinosaur>();
            myDinos.Add( new TRex());
            myDinos.Add(new TRex() {Travel = "Stomp" });
            myDinos.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDinos)
            {
                Console.WriteLine("This dinos travel by {0}", dino.Travel);
                Console.WriteLine(dino);
            }
        }

    }
}