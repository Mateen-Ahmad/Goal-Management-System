using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class Goals
    {
        private string goalName;

        private List<Tasks> taskList = new List<Tasks>();

        public string GoalName { get => goalName; set => goalName = value; }
        public List<Tasks> TaskList
        {
            get
            {
                if (TaskList == null)
                {
                    TaskList = new List<Tasks>();
                }
                return TaskList;
            }
            set
            {
                TaskList = value;
            }
        }
    }
}