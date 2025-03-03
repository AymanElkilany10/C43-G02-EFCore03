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
    internal class Course_Inst
    {
        [Key, Column(Order = 1)]
        public int Inst_ID { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }

        public string Evaluate { get; set; }

        [ForeignKey("Inst_ID")]
        public Instructor Instructor { get; set; }

        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}