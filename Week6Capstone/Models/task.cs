using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Capstone.Models
{
    public class Task
    {
        public Task()
        {

        }

        public Task(string description, string dueDate, string name)
        {
            Description = description;
            DueDate = dueDate;
            Name = name;
        }
        public bool IsComplete { get; set; } = false;
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Name { get; set; }
    }
}