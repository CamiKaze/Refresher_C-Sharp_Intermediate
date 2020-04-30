using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_and_Unboxing
{
    class Program
    { // Boxing/Unboxing has a performance penalty.
      // It is better to use a generic list implementation
      // of the class.
        static void Main(string[] args)
        {
            // The problem witrh an ArrayList is type safety.
            var list = new ArrayList();
            // Boxing will happen with this value as an
            // ArrayList takes an object of type object.
            list.Add(1);
            // Boxing with not happen with this reference.
            list.Add("Cameron");
            // Boxing will happen with the value below.
            list.Add(DateTime.Today);

            // The best option is to use a genereic list.
            var anotherList = new List<int>();
            var names = new List<string>();
        }
    }
}
