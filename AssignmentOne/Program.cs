// See https://aka.ms/new-console-template for more information
// Create three students
using AssignmentOne.EnumFolder;
using AssignmentOne;

var newStudent = new Student();

var student1 = newStudent.CreateStudent(001, StudentType.FullTime, "John", "Anderson");
var student2 = newStudent.CreateStudent(002, StudentType.FullTime, "Karen", "Smith");
var student3 = newStudent.CreateStudent(003, StudentType.PartTime, "Kevin", "Peters");

// Output header
Console.WriteLine("Assignment One");

// Output students
student1.OutputStudent(student1);
student2.OutputStudent(student2);
student3.OutputStudent(student3);
