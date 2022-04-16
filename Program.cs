using System;

namespace Student_Data
{
    public class Student
    {
        public void StudentData()
        {
            Console.WriteLine("Student Data:\nName:Roshni\nEducation:BE\nAddress:Test");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello World!");
            Student student = new Student();
            student.StudentData();
        }
    }
}
