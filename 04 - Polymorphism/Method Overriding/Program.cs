using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    class Program
    {// An example of how to write a loosely coupled application
     // with Polymorphism.
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
