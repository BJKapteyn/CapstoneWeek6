using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Capstone.Models
{
    public static class TaskList
    {
        public static List<task> tasks = new List<task>();

        public static string AddColor(string taskClass, int index)
        {
            if(tasks[index].IsComplete)
            {
                return "green";

            }
            else
            {
                return "red";
            }
        }
    }
}