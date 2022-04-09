using BBL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ImageLink { get; set; }
        public string Password { get; set; }
        public GenderType Gender { get; set; }
        public string NickName { get; set; }
        public DateTime BirthDate { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public string MailingAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //Navigation properties
        public IEnumerable<StudentCourseModel> StudentCourses { get; set; }
        public IEnumerable<TaskCommentModel> TaskComments { get; set; }
    }
}
