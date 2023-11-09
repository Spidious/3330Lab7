using System.Data;

namespace ClassLibrary1
{
    // Date class (can be changed or removed if another solution is found)
    public class Date
    {
        // Set date attributes
        private int month;
        private int year;
        private int day;

        // Create individual getters
        public int getMonth() { return month; }
        public int getYear() { return year; }
        public int getDay() { return day; }
        // Constructor and set Date functions
        public Date(int inMonth, int inDay, int inYear)
        {
            month = inMonth;
            year = inYear;
            day = inDay;
        }
        public Date() { }

        public Date setDate(int m, int d, int y)
        {
            return new Date(m, d, y);
        }

        // Override the toString output
        public override string ToString()
        {
            return string.Format("%d / %d / %d", month, day, year);
        }
    }

    // Student class
    public class Students
    {
        private int StudentID;
        private string StudentFirstName;
        private string StudentLastName;
        private string StudnetPhone;
        private string StudentEmail;
    }

    // Term class
    public class StudyTerms
    {
        private int TermID;
        private string TermName;
        private Date TermStartDate;
        private Date TermEndDate;
        private int TermYear;
        private string TermSeason;
    }

    // Assignment class
    public class TeachingAssignment
    {
        private int TAssignmentID;
        private int InstructorID;
        private int CourseID;
        private int TermID;
        private Date TAssignmentDate;
    }

    // Instructors class
    public class Instructors
    {
        private int InstructorID;
        private string InstructorFirstName;
        private string InstructorLastName;
        private string InstructorEmail;
        private string InstructorPhone;
        private int DepartmentID;
    }

    // Registrations Class
    public class Registrations
    {
        private int RegistrationID;
        private int StudentID;
        private int CourseID;
        private int TermID;
        private Date RegistrationDate;
    }

    // Courses class
    public class Courses
    {
        private int CourseID;
        private string CourseName;
        private int DepartmentID;
    }

    // Department Class
    public class Departments
    {
        private int DepartmentID;
        private string DepartmentName;
    }

    // TA Assignments class
    public class TAAssignments
    {
        private int TAAssignmentID;
        private int TAID;
        private int CourseID;
        private int TermID;
        private Date AssignmentDate;
    }

    // TA Graders class
    public class TAGraders
    {
        private int TAID;
        private string TAFirstName;
        private string TALastName;
        private string TAPhone;
        private string TAEmail;
        private int DepartmentID;
    }
}
