using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class Roles
    {
        private string roleName;
        private string roleType;

        private List<Goals> goalList = new List<Goals>();

        public string RoleName { get => roleName; set => roleName = value; }
        public string RoleType { get => roleType; set => roleType = value; }

        public List<Goals> GoalList
        {
            get
            {
                if (goalList == null)
                {
                    goalList = new List<Goals>();
                }
                return goalList;
            }
            set
            {
                goalList = value;
            }
        }
    }
}