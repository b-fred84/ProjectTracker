using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Core.Models
{
    public class Project
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool Private { get; set; }
        public bool HasTasks { get; set; }


    }
}
