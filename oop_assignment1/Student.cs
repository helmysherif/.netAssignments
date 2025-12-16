using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace oop_assignment1
{
    internal class Student(int studentId , string name , int age , List<Course> courses = null)
    {
        public int studentId = studentId;
        public string name = name;
        public int age = age;
        public List<Course> courses = courses;
        public bool Enroll(Course course)
        {
            foreach (Course item in courses)
            {
                if (item.courseId == course.courseId)
                {
                    return false;
                }
            }
            courses.Add(course);
            return true;
        }
        public string PrintDetails()
        {
            string courseTitles = "No Courses";
            if(courses.Count > 0)
            {
                foreach (Course item in courses)
                {
                    courseTitles = string.Join(" , ", item.title);
                }
            }
            return $"ID: {studentId}, Name: {name}, Age: {age}, Courses: {courseTitles}";
        }
    }
}
