using System;

namespace HomeWork25._04._21
{
    class Program
    {
        static void Main(string[] args)

        {
            Group group = new Group("P324",2);    

            Student student1 = new Student("Xelilbey","Xelilbeyli");
            Student student2 = new Student("Memmedbagir", "Bagirzade");
            Student student3 = new Student("Siyavus", "Aslan");

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetStudents();


        }
    }
}
