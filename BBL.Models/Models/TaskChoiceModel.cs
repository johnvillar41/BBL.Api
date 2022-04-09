using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class TaskChoiceModel
    {
        public int TaskChoiceId { get; set; }
        public string Choice { get; set; }
        public bool IsCorrect { get; set; }

        //Navigation properties
        public TaskQuestionModel TaskQuestion { get; set; }
        public int TaskQuestionId { get; set; }
    }
}
