namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            // We now hgave access to the properties
            // and methods in the parent class.
            text.Width = 100;
            text.Copy();
        }
    }
}
