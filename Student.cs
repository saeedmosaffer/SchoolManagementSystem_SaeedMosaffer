using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem_SaeedMosaffer
{
    internal class Student : Affiliate
    {
        private HashSet<Course> enrolledCourses;
        public Student(int id, string name, int age, DateTime admissionDate) : base(id, name, age, admissionDate)
        {
            enrolledCourses = new HashSet<Course>();
        }

        public void EnrollCourse(Course course)
        {
            enrolledCourses.Add(course);
        }

        public void DropCourse(Course course)
        {
            enrolledCourses.Remove(course);
        }

        public HashSet<Course> GetEnrolledCourses()
        {
            return enrolledCourses;
        }

        public override string GetDetails()
        {
            string courses = "";
            foreach (Course course in enrolledCourses)
            {
                courses += course.GetCourseDetails() + "\n";
            }
            return $"Student ID: {Id}, Name: {Name}, Age: {Age}, Admission Date: {AdmissionDate.ToShortDateString()}, Courses:\n{courses},  School: {SCHOOL_NAME}";
        }

    }
}
