using BBL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        public TaskType TaskType { get; set; }
        public string TaskName { get; set; }
        public string TaskContent { get; set; }
        public int Attempts { get; set; }
        public string Submission { get; set; }
        public int TaskGrade { get; set; }
        public TaskStatus TaskStatus { get; set; }

        //Navigation properties
        public IEnumerable<TaskQuestionModel> TaskQuestions { get; set; }
        public IEnumerable<TaskFileModel> TaskFiles { get; set; }

        public ProfessorModel Professor { get; set; }
        public int ProfessorId { get; set; }        
    }
}
