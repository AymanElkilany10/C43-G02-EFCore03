using Microsoft.EntityFrameworkCore;
namespace EF_3
{
    internal class Program
    {
        public static void Main()
        {
            using (var context = new ITIDbContext())
            {
                Console.WriteLine("📌 Applying CRUD operations...\n");

                //  insert data
                var student = new Student { FName = "Ayman", LName = "Elkilany", Address = "Cairo", Age = 21, Dep_Id = 1 };
                var course = new Course { Name = "Algorithms", Description = "Learn Algorithm Design", Duration = 3, Top_ID = 1 };

                context.Students.Add(student);
                context.Courses.Add(course);
                context.SaveChanges();


                // retreive data
                var students = context.Students.ToList();
                Console.WriteLine("Students List:");
                foreach (var s in students)
                {
                    Console.WriteLine($"- {s.FName} {s.LName}");
                }
                Console.WriteLine();

                // update data
                var firstStudent = context.Students.FirstOrDefault();
                if (firstStudent != null)
                {
                    firstStudent.Address = "Alexandria";
                    context.SaveChanges();
                }

                // delete data
                var studentToDelete = context.Students.FirstOrDefault();
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                   
                }

                // eager and lazy loading
                var studentsWithDept = context.Students.Include(s => s.Department).ToList();
                foreach (var stud in studentsWithDept)
                {
                    Console.WriteLine($"- {stud.FName} {stud.LName}, Dept: {stud.Department?.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
