using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    public class Canvas
    {
        // A list of type Shape is created. We can now
        // call any shape from our Shape class.
        // At runtime, this shape might be a circle,
        // a rectangle, or a triangle. So when we call the draw
        // method, the draw method in the specific
        // shape will be called.
        // This, in essence, is what is known as Polymorphism.
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
