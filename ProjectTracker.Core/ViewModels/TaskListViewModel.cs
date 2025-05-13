using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.ViewModels
{
    public class TaskListViewModel
    {
        public int Id { get; set; }
        public int ProjectName { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

    }
}
