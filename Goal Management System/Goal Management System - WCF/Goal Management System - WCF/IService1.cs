using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Goal_Management_System___WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        void addUsers(Users u);

        [OperationContract]
        int getCount();

        [OperationContract]
        string getUserName(int i);

        [OperationContract]
        string getPassword(int i);


        //-------------------------------------??

        [OperationContract]
        void addRole(int index, Roles r);
        [OperationContract]
        void deleteRole(int ui, int ri);
        [OperationContract]
        string getRoleName(int ui, int ri);
        [OperationContract]
        string getRoleType(int ui, int ri);
        [OperationContract]
        int getRoleCount(int index);

        //-----------??----------//

        [OperationContract]
        void addGoal(int ui, int ri, string goalName);
        [OperationContract]
        void deleteGoal(int ui, int ri, int gi);
        [OperationContract]
        string getGoalName(int ui, int ri, int gi);
        [OperationContract]
        int getGoalCount(int ui, int ri);


        //----------------------------???


        [OperationContract]
        void addTask(int ui, int ri, int gi, Tasks t);
        [OperationContract]
        void deleteTask(int ui, int ri, int gi, int ti);
        [OperationContract]
        int getTasksCount(int ui, int ri, int gi);
        [OperationContract]
        string getTaskName(int ui, int ri, int gi, int ti);
        [OperationContract]
        DateTime getTaskDate(int ui, int ri, int gi, int ti);











    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
