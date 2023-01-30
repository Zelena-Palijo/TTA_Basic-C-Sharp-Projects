using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Student
    {
        //chaining 2 constructors together
        public Student (string name) : this (name, 00000)
        {

        }
        //constructor 
        public Student (string name, int Id)
        {
        }
    }
}
