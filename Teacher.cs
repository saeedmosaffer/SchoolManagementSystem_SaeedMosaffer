﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem_SaeedMosaffer
{
    internal class Teacher : Affiliate
    {
        private HashSet<Course> assignedCourses;
        public Teacher(int id, string name, int age, DateTime admissionDate) : base(id, name, age, admissionDate)
        {
            assignedCourses = new HashSet<Course>();
        }

        public void AssignCourse(Course course)
        {
            assignedCourses.Add(course);
        }

        public HashSet<Course> GetAssignedCourses()
        {
            return assignedCourses;
        }

        public override string GetDetails()
        {
            string courses = "";
            foreach (Course course in assignedCourses)
            {
                courses += course.GetCourseDetails() + "\n";
            }
            return $"Student ID: {Id}, Name: {Name}, Age: {Age}, Admission Date: {AdmissionDate.ToShortDateString()}, Courses:\n{courses},  School: {SCHOOL_NAME}";
        }
    }
}
