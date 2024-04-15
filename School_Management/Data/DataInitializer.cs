using School_Management.Models;
namespace School_Management.Data
{
    public class DataInitializer
    {
        public DataInitializer(SchoolContext context) 
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            AddStudents(context);
            AddCourses(context);
            AddEnrollments(context);
        }


        void AddStudents(SchoolContext context)
        {
            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",AdmissionDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",AdmissionDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",AdmissionDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",AdmissionDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",AdmissionDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",AdmissionDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",AdmissionDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",AdmissionDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }

        void AddEnrollments(SchoolContext context) 
        {
            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }

        void AddCourses(SchoolContext context)
        {
            var courses = new Course[]
            {
            new Course{Id=1050,Title="Chemistry",Credits=3},
            new Course{Id=4022,Title="Microeconomics",Credits=3},
            new Course{Id=4041,Title="Macroeconomics",Credits=3},
            new Course{Id=1045,Title="Calculus",Credits=4},
            new Course{Id=3141,Title="Trigonometry",Credits=4},
            new Course{Id=2021,Title="Composition",Credits=3},
            new Course{Id=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
        }
    }
}
