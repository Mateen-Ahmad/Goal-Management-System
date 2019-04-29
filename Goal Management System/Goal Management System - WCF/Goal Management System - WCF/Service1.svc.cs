using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Goal_Management_System___WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }








        public void addUsers(Users u)
        {
            DataList.userList.Add(u);
        }
        public int getCount()
        {
            return DataList.userList.Count;
        }
        public string getUserName(int i)
        {
            return DataList.userList[i].UserName;
        }

        public string getPassword(int i)
        {
            return DataList.userList[i].Password;
        }


        //----------------------------------------??



        public void addRole(int index, Roles r)
        {   
            DataList.userList[index].RoleList.Add(r);
            //DataList.userList[index].RoleList.Add(new Roles() { RoleName = name, RoleType = type });
        }
        public void deleteRole(int ui, int ri)
        {
            DataList.userList[ui].RoleList.RemoveAt(ri);
        }
        public string getRoleName(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].RoleName;
        }
        public string getRoleType(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].RoleType;
        }

        public int getRoleCount(int ui)
        {
             return DataList.userList[ui].RoleList.Count;
        }


        //----------------------//--------------------//>>>>>>>>>>>>>>>>>>>>

        public void addGoal(int ui, int ri, string goalName)
        {
            Goals g = new Goals();
            g.GoalName = goalName;
            DataList.userList[ui].RoleList[ri].GoalList.Add(g);
        }
        public void deleteGoal(int ui, int ri, int gi)
        {
            DataList.userList[ui].RoleList[ri].GoalList.RemoveAt(gi);
        }
        public string getGoalName(int ui, int ri, int gi)
        {
            return DataList.userList[ui].RoleList[ri].GoalList[gi].GoalName;
        }
        public int getGoalCount(int ui, int ri)
        {
            return DataList.userList[ui].RoleList[ri].GoalList.Count;
        }



        //--------------------------------//

        public void addTask(int ui, int ri, int gi, Tasks t)
        {
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.Add(t);
        }

        public void deleteTask(int ui, int ri, int gi, int ti)
        {
            DataList.userList[ui].RoleList[ri].GoalList[gi].TaskList.RemoveAt(ti);
        }

        public int getTasksCount(int ui, int ri, int gi)
        {
            return DataList.userList[ui].RoleList[gi].GoalList[gi].TaskList.Count;
        }

        public string getTaskName(int ui, int ri, int gi, int ti)
        {
            return DataList.userList[ui].RoleList[gi].GoalList[gi].TaskList[ti].TaskName;
        }

        public DateTime getTaskDate(int ui, int ri, int gi, int ti)
        {
            return DataList.userList[ui].RoleList[gi].GoalList[gi].TaskList[ti].TaskTime;
        }




    }
}
