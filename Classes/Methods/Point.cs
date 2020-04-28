using System;

namespace Methods
{ // Method Overloading, Signature of methods
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Method that accepts two parameters (x, y)
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Method overloading that accepts one parameter (x, y)
        public void Move(Point newLocation)
        { // Defensive programming
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}
