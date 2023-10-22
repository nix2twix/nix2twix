using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class Student
    {
        private string _firstName;
        public string FirstName { get { return _firstName; } }

        private string _lastName;
        public string LastName { get { return _lastName; } }

        private string _middleName;
        public string MiddleName { get { return _middleName; } }

        private string _birthday;
        public string BirthDay { get { return _birthday; } }

        private string _fullName;
        public string FullName { get { return _fullName; } }

        private float _averageScore;
        public float AverageScore { get { return _averageScore; } }


        public Student(string lastName, string firstName, string middleName, string birthday, float score)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._middleName = middleName;
            this._birthday = birthday;
            this._fullName = _lastName + " " + _firstName + " " + _middleName;
            this._averageScore = score;
        }
    }
}
