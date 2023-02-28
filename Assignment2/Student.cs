using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Student:Person
    {
        public Student(string name, int age):base(name, age) { 
                    
        
        }

        public string IsCollegeStudent() => IsAdult() ? "CollegeStudent" : "GradeStudent";
       

    }
}
