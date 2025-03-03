using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_3;

namespace EF_3
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }
        [ForeignKey("Dep_Id")]
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}