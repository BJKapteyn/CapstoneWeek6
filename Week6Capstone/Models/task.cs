using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Capstone.Models
{
    public class task
    {
        public bool IsComplete { get; set; } = false;
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Name { get; set; }
        public int index { get; set; }
    }
}