using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3
{
    internal class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public int Ins_ID { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}