using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment1
{
    internal class Course(int courseId , string title , Instructor instructor)
    {
        public int courseId = courseId;
        public string title = title;
        public Instructor instructor = instructor;
        public string PrintDetails()
        {
            return $"courseId is {courseId} and its title is {title} and its instructor is {instructor}";
        }
    }
}
