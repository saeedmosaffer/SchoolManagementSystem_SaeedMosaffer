using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem_SaeedMosaffer
{
    internal class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }

        public Course(int id, string courseName, Teacher teacher)
        {
            Id = id;
            CourseName = courseName;
            Teacher = teacher;
        }

        public string GetCourseDetails()
        {
            return $"Course ID: {Id}, Name: {CourseName}, Teacher: {Teacher.Name}";
        }

        public override bool Equals(object obj)
        {
            return obj is Course course && Id == course.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
