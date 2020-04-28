using System;

namespace Properties
{
    public class Person
    {
        // This is an Auto-Implemented property, meaning
        // that it does not have a backing field.
        // The property has a private set accessor, which
        // means that it is read-only. we set that in the
        // constructor above.
        public DateTime Birthdate { get; private set; }
        
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // This method requires logic to calculate an age
        // and therefore, cannot be an Auto-Implemented
        // property. It makes sense to not set an age.
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
