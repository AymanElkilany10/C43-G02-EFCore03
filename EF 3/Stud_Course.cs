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
    internal class Stud_Course
    {
        [Key, Column(Order = 1)]
        public int Stud_ID { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }

        public int Grade { get; set; }

        [ForeignKey("Stud_ID")]
        public Student Student { get; set; }

        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}