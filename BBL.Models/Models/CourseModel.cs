using BBL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime DateCreated { get; set; }
        public CourseStatus CourseStatus { get; set; }

        //Navigation properties
        public IEnumerable<StudentCourseModel> StudentCourses { get; set; }
    }
}
