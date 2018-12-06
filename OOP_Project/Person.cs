using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNine
{
    public class Person 
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string BirthDate;
        public string Address;
        
        public Person(string firstName, string lastName, string birthDate, string address, string middleName = "")
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;

        }

        public string GetFullName()
        {
            string firstName = char.ToUpper(FirstName[0]) + FirstName.Substring(1).ToLower();
            string middleInitial = char.ToUpper(MiddleName[0]) + ".";
            string lastName = char.ToUpper(LastName[0]) + LastName.Substring(1).ToLower();

            string fullName = firstName + " " + middleInitial + " " + lastName;
            return fullName;
        }

        public int GetAge()
        {
            DateTime dateToday = DateTime.Today;
            Calculations calculations = new Calculations();
            return calculations.CalculateAge(BirthDate);
        }
    }
}
