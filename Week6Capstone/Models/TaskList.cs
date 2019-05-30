using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6Capstone.Models
{
    public static class TaskList
    {
        public static List<Task> tasks = new List<Task> { new Task("Get in your car and go to the store", "07/12/19", "Go to the store"),
                                                          new Task("Practice piano for one hour", "07/15/19", "Practice piano"),
                                                          new Task("Take your mother out for her birthday dinner", "07/16/19", "Go out for dinner")};
        
        public static string AddColor(int index)
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