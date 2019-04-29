using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goal_Management_System___WCF
{
    public class Users
    {
        private string userName;
        private string password;

        private List<Roles> roleList = new List<Roles>();



        public string Password { get => password; set => password = value; }
        public List<Roles> RoleList
        {
            get
            {
                if(roleList == null)
                {
                    roleList = new List<Roles>();
                }
                return roleList;
            }
            set
            {
                roleList = value;
            }
        }

        public string UserName {  get => userName; set => userName = value; }
    }
}