using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment1
{
    class School
    {
        public List<Student> students = [];
        public List<Course> courses = [];
        public List<Instructor> instructors = [];
    }
    internal class StudentManager
    {
        public School school = new School();
        public bool AddStudent(Student student)
        {
            foreach (Student std in school.students)
            {
                if (student.studentId == std.studentId)
                {
                    return false;
                }
            }
            school.students.Add(student);
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            foreach (Instructor inst in school.instructors)
            {
                if (instructor.instructorId == inst.instructorId)
                {
                    return false;
                }
            }
            school.instructors.Add(instructor);
            return true;
        }
        public bool AddCourses(Course course)
        {
            foreach (Course cors in school.courses)
            {
                if (course.courseId == cors.courseId)
                {
                    return false;
                }
            }
            school.courses.Add(course);
            return true;
        }
        public Student FindStudent(int studentId)
        {
            foreach (Student student in school.students)
            {
                if (student.studentId == studentId)
                {
                    return student;
                }
            }
            return null;
        }
        public Instructor FindInstructor(int instructorId)
        {
            foreach (Instructor instructor in school.instructors)
            {
                if (instructor.instructorId == instructorId)
                {
                    return instructor;
                }
            }
            return null;
        }
        public Course FindCourse(int courseId)
        {
            foreach (Course course in school.courses)
            {
                if (course.courseId == courseId)
                {
                    return course;
                }
            }
            return null;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);

            if (student == null || course == null)
                return false;

            return student.Enroll(course);
        }
        public bool IsStudentEnrolledInCourse(int studentId, string courseName)
        {
            Student student = FindStudent(studentId);
            if (student == null)
                return false;
            foreach (Course course in student.courses)
            {
                if (course.title.ToLower() == courseName.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
        public string GetInstructorNameByCourseName(string courseName)
        {
            foreach (Course course in school.courses)
            {
                if (course.title.ToLower() == courseName.ToLower())
                {
                    if (course.instructor != null)
                    {
                        return course.instructor.name;
                    }
                }
            }

            return null;
        }
    }
}
