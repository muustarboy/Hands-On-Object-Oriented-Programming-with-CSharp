using System;

namespace Chapter2
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string emailAddress;

        public string GetFullName(string firstName, string lastName){
            return firstName + lastName;
        }
    }
}


