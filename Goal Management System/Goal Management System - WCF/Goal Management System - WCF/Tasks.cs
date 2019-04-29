using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class Tasks
    {
        private string taskName;
        private DateTime taskTime;

        public string TaskName { get => taskName; set => taskName = value; }
        public DateTime TaskTime { get => taskTime; set => taskTime = value; }
    }
}