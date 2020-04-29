using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            // We can implicitly convert a object reference
            // like text, to its base class reference, like Shape.
            // Upcasting is implicit, so you can simply upcast an
            // object reference to its base class reference.
            // Whenever a method requires an object of a given
            // type, you can pass an object of that type, or
            // any types that derive from that type.
            // This is an example of Upcasting.
            Shape shape = text;

            // Text and Shape are both references to the same object
            // in memory, but they have different views.
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            // If you have an argument where you have a limited
            // view to the object, you can use Downcasting to
            // convert the object to a more specific type.
            // For this, you can use an explicit cast,
            // or the "as" keyword.
            // At runtime, shape1 will be of type Text.
            // This is an example of Downcasting.
            Shape shape1 = new Text();
            // We do not have the properties that are
            // available in the Text class, so now we
            // need to Downcast shape1 into Text.
            Text text1 = (Text)shape1;
            // We now have access to every property
            // in the Text class.
        }
    }
}
