using BBL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class StudentCourseModel
    {
        [Key]
        public int StudentCourseId { get; set; }
        public StudentCourseStatus CourseStatus { get; set; }
        public string SectionCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //Navigation properties
        public StudentModel Student { get; set; }
        public int StudentId { get; set; }

        public CourseModel Course { get; set; }
        public int CourseId { get; set; }

        public ProfessorModel Professor { get; set; }
        public int ProfessorId { get; set; }

        public TaskModel Task { get; set; }
        public int TaskId { get; set; }
    }
}
