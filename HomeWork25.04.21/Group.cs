using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork25._04._21
{
    class Group
    {
        public string No;

        public byte Limit;

        private Student[] _students;

        public Group(string number, byte limit)
        {
            No = number;
            Limit = limit;
            _students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            if (Limit > _students.Length)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
                Console.WriteLine("Yarandi");
            }
            else
            {
                Console.WriteLine("Yer yoxdur");
            }
        }
        public void GetStudents()
        {
            foreach (var students in _students)
            {
                Console.WriteLine(students.Name + " " + students.Surname);
            }
        }

    }
}
