using AssignmentOne;
using AssignmentOne.EnumFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class Student
    {
        public int Id;
        public StudentType Type;
        public string FirstName;
        public string LastName;


        public Student CreateStudent(int id, StudentType type, string firstName, string lastName)
        {
            if (id == null) id = 0;
            if (firstName == null) firstName = "Unknown";
            if (lastName == null) lastName = "";

            var newStudent = new Student();

            newStudent.Id = id;
            newStudent.Type = type;
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;

            return newStudent;
        }

        public void OutputStudent(Student student)
        {
            Console.WriteLine($"Student: {student.Id} {student.FirstName} {student.LastName} ({student.Type})");
        }
    }

}
    
