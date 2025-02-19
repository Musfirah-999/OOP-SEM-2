using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double FSC_Marks;
        public double Matric_Marks;
        public double aggree;
        public Student(string name , int age , double fsc_marks , double matric_marks)
        {
            Name = name;
            Age = age;
            FSC_Marks = fsc_marks;
            Matric_Marks = matric_marks;
            aggregate();
        }
        public double aggregate()
        {
             aggree = ((FSC_Marks/1100) * 50 ) + ((Matric_Marks/1100) * 50 );
            return aggree;
        }
    }
}
