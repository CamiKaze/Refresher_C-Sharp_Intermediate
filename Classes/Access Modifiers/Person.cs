using System;

namespace Access_Modifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        { // Setter
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        { // Getter
            return _birthdate;
        }
    }
}
