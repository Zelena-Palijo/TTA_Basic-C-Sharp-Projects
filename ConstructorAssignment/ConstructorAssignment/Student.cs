using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Student
    {
        public string name;
        public int Id;

        //chaining 2 constructors together
        public Student (string studentName) : this (studentName, 11111)
        {

        }
        //constructor 
        public Student (string studentName, int studentId)
        {
            name = studentName;
            Id = studentId;
        }
        
    }
}
