using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem_SaeedMosaffer
{
    internal class School
    {
        private Dictionary<int, Student> students;
        private Dictionary<int, Teacher> teachers;
        private Dictionary<int, Course> courses;

        public School()
        {
            students = new Dictionary<int, Student>();
            teachers = new Dictionary<int, Teacher>();
            courses = new Dictionary<int, Course>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student.Id, student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher.Id, teacher);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course.Id, course);
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("Students:");
            foreach (var student in students.Values)
            {
                Console.WriteLine(student.GetStudentDetails());
            }
        }

        public void DisplayAllTeachers()
        {
            Console.WriteLine("Teachers:");
            foreach (var teacher in teachers.Values)
            {
                Console.WriteLine(teacher.GetTeacherDetails());
            }
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("Courses:");
            foreach (var course in courses.Values)
            {
                Console.WriteLine(course.GetCourseDetails());
                Console.WriteLine($"Hash Code: {course.GetHashCode()}");
            }
        }

        public void DisplaySchoolDetails()
        {
            Console.WriteLine("School Details:");
            Console.WriteLine($"School Name: {Affiliate.SCHOOL_NAME}");
            Console.WriteLine($"Total Students: {students.Count}");
            Console.WriteLine($"Total Teachers: {teachers.Count}");
            Console.WriteLine($"Total Courses: {courses.Count}");
        }
    }
}
