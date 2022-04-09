using BBL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class ProfessorModel
    {
        [Key]
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }
        public string ImageLink { get; set; }
        public GenderType Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string MailingAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Navigation properties
        public IEnumerable<TaskModel> Tasks { get; set; }
        public IEnumerable<StudentCourseModel> StudentCourses { get; set; }
    }
}
