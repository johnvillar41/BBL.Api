using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class TaskQuestionModel
    {
        [Key]
        public int TaskQuestionId { get; set; }
        public string Question { get; set; }

        //Navigation properties
        public IEnumerable<TaskChoiceModel> TaskChoices { get; set; }
        public TaskModel Task { get; set; }
        public int TaskId { get; set; }
    }
}
