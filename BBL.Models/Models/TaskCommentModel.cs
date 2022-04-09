using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class TaskCommentModel
    {
        [Key]
        public int TaskCommentId { get; set; }
        public string Comment { get; set; }

        //Navigation properties
        public TaskModel Task { get; set; }
        public int TaskId { get; set; }

        public StudentModel Student { get; set; }
        public int StudentId { get; set; }
    }
}
