using System;

namespace Indexers
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Cameron";
            Console.WriteLine(cookie["name"]);
        }
    }
}
