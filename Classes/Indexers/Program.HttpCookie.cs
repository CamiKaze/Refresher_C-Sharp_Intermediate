using System.Collections.Generic;

namespace Indexers
{
    partial class Program
    {
        public class HttpCookie
        {
            // A Dictionary is a data type that uses a hash table to
            // store data. It uses a key to find an item.
            private readonly Dictionary<string, string> _dictionary;

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            // This is an indexer.
            public string this[string key]
            {   // Return a value from the specified key.
                get { return _dictionary[key]; }
                // Set a value at the specified key.
                set { _dictionary[key] = value; }
            }
        }
    }
}
