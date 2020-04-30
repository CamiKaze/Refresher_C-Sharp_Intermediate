using System;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // "base" is a reference to the parent class.
            // We can write any code specific to the Circle
            // class, and then we can pass it to the Draw
            // method defined in the parent class.
            //base.Draw();

            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    // If you ever wanted to add another shape, then
    // all you need to do is create it, like the class below.
    // All the shapes are now neatly tucked into one file.
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // Declare the method as "virtual" so that
        // we can override the implementation in a
        // derived class.
        public virtual void Draw()
        {
        }
    }
}
