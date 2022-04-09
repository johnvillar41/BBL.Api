using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Data.Models
{
    public class TaskFileModel
    {
        public int TaskFileId { get; set; }
        public string TaskFileLink { get; set; }

        //Navigation properties
        public TaskModel Task { get; set; }
        public int TaskId { get; set; }
    }
}
