using SchoolManagementSystem_SaeedMosaffer;

class Program
{
    static void Main(string[] args)
    {
        // Create a school object
        School school = new School();

        // Create teachers
        Teacher teacher1 = new Teacher(1, "Saeed Mosaffer", 30, DateTime.Now.AddYears(-5));
        Teacher teacher2 = new Teacher(2, "Yousef Injas", 40, DateTime.Now.AddYears(-10));
        Teacher teacher3 = new Teacher(3, "Adham Arar", 35, DateTime.Now.AddYears(-7));

        // Create students
        Student student1 = new Student(1, "Ahmad Al-Masri", 20, DateTime.Now.AddYears(-2));
        Student student2 = new Student(2, "Mohammad Al-Masri", 21, DateTime.Now.AddYears(-3));
        Student student3 = new Student(3, "Ali Al-Masri", 22, DateTime.Now.AddYears(-4));

        // Create courses
        Course course1 = new Course(1, "Math", teacher1);
        Course course2 = new Course(2, "Physics", teacher2);
        Course course3 = new Course(3, "Chemistry", teacher3);

        // Assign courses to teachers
        teacher1.AssignCourse(course1);
        teacher2.AssignCourse(course2);
        teacher3.AssignCourse(course3);

        // Enroll students in courses
        student1.EnrollCourse(course1);
        student1.EnrollCourse(course1);
        student1.EnrollCourse(course2);
        student2.EnrollCourse(course2);
        student2.EnrollCourse(course3);
        student3.EnrollCourse(course1);
        student3.EnrollCourse(course3);

        // Add teachers, students, and courses to the school
        school.AddTeacher(teacher1);
        school.AddTeacher(teacher2);
        school.AddTeacher(teacher3);

        school.AddStudent(student1);
        school.AddStudent(student2);
        school.AddStudent(student3);

        school.AddCourse(course1);
        school.AddCourse(course2);
        school.AddCourse(course3);

        // Display all students, teachers, and courses
        school.DisplayAllStudents();
        school.DisplayAllTeachers();
        school.DisplayAllCourses();

        // Drop a course from a student
        student1.DropCourse(course2);
        student2.DropCourse(course2);
        student3.DropCourse(course1);

        // Print school name and total number of Affiliates
        school.DisplaySchoolDetails();

        // Print the details of a specific student
        Console.WriteLine(student1.GetStudentDetails());

        // Print the details of a specific teacher
        Console.WriteLine(teacher1.GetTeacherDetails());

        // Print the details of a specific course
        Console.WriteLine(course1.GetCourseDetails());

        Course c1 = new Course(1, "Math", teacher1);
        Course c2 = new Course(1, "Math", teacher1);
        Console.WriteLine(c1.Equals(c2));

        int hashCode1 = c1.GetHashCode();
        int hashCode2 = c2.GetHashCode();
        Console.WriteLine($"Hash code for course1: {hashCode1}");
        Console.WriteLine($"Hash code for course2: {hashCode2}");


    }
}

