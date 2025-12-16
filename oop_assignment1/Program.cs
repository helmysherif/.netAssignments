namespace oop_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n===== Student Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID");
                Console.WriteLine("9. Find Course by ID");
                Console.WriteLine("10. Check student enrollment (Bonus)");
                Console.WriteLine("11. Get instructor by course name (Bonus)");
                Console.WriteLine("12. Exit");
                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Student ID: ");
                        int sid = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string sname = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Student student = new Student(studentId:sid , name:sname , age:age);
                        manager.AddStudent(student);
                        break;
                    case 2:
                        Console.Write("Instructor ID: ");
                        int iid = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string iname = Console.ReadLine();
                        Console.Write("Specialization: ");
                        string spec = Console.ReadLine();
                        Instructor instructor = new Instructor(instructorId:iid , name:iname , specialization:spec);
                        manager.AddInstructor(instructor);
                        break;
                    case 3:
                        Console.Write("Course ID: ");
                        int cid = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Instructor ID: ");
                        int instId = int.Parse(Console.ReadLine());
                        Instructor instruct = manager.FindInstructor(instId);
                        if (instruct != null)
                        {
                            Course cours = new Course(courseId:cid , title:title , instructor:instruct);
                            manager.AddCourses(cours);
                        }
                        else
                        {
                            Console.WriteLine("Instructor not found.");
                        }
                        break;
                    case 4:
                        Console.Write("Student ID: ");
                        int esid = int.Parse(Console.ReadLine());
                        Console.Write("Course ID: ");
                        int ecid = int.Parse(Console.ReadLine());
                        manager.EnrollStudentInCourse(esid, ecid);
                        break;
                    case 5:
                        manager.school.students.ForEach(s => Console.WriteLine(s.PrintDetails()));
                        break;
                    case 6:
                        manager.school.courses.ForEach(c => Console.WriteLine(c.PrintDetails()));
                        break;
                    case 7:
                        manager.school.instructors.ForEach(i => Console.WriteLine(i.PrintDetails()));
                        break;
                    case 8:
                        Console.Write("Student ID: ");
                        int studId = int.Parse(Console.ReadLine());
                        Student stud = manager.FindStudent(studId);
                        Console.WriteLine(stud?.PrintDetails() ?? "Student not found");
                        break;
                    case 9:
                        Console.Write("Course ID: ");
                        int fcid = int.Parse(Console.ReadLine());
                        Course course = manager.FindCourse(fcid);
                        Console.WriteLine(course?.PrintDetails() ?? "Course not found");
                        break;
                    case 10:
                        Console.Write("Student ID: ");
                        int csid = int.Parse(Console.ReadLine());
                        Console.Write("Course Name: ");
                        string cname = Console.ReadLine();
                        if(manager.IsStudentEnrolledInCourse(csid, cname))
                        {
                            Console.WriteLine("Student is enrolled in the course.");
                        }
                        else
                        {
                            Console.WriteLine("Student is not enrolled in the course.");
                        }
                        break;
                    case 11:
                        Console.Write("Course Name: ");
                        string courseName = Console.ReadLine();
                        Console.WriteLine(manager.GetInstructorNameByCourseName(courseName) ?? "Course not found");
                        break;
                    case 12:
                        running = false;
                        break;
                }
            }
        }
    }
}
