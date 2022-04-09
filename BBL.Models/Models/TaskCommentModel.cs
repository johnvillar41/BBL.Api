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
        public int TaskId { get; set; }
        public int StudentId { get; set; }
    }
}
