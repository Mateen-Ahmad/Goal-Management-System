using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goal_Management_System
{
    public partial class Goals : Form
    {
        int index;
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Goals()
        {
            InitializeComponent();
        }

        private void Goals_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<myserver.getRoleCount(Program.index); ++i)
            {
                cmbRoleName.Items.Add(myserver.getRoleName(Program.index, i));
            }
        }


        void goalDataShow()
        {
            GoalGridView.Rows.Clear();
            for (int i = 0; i < myserver.getGoalCount(Program.index, index); i++)
            {
                GoalGridView.Rows.Add(myserver.getGoalName(Program.index, index, i), lblShowRoleType.Text);
            }
        }

        private void CmbRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var r1 = new ServiceReference1.Roles();
            index = cmbRoleName.SelectedIndex;
            //r1 = myserver.getRoleName(Program.index, index);
            lblShowRoleType.Text = myserver.getRoleType(Program.index, index);
            goalDataShow();
        }

        private void LnklblAddGoal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var g = new ServiceReference1.Goals();
            //g.GoalName = txtGoal.Text;
            index = cmbRoleName.SelectedIndex;
            myserver.addGoal(Program.index, index, txtGoal.Text);
            goalDataShow();
        }

        private void GoalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                myserver.deleteGoal(Program.index, cmbRoleName.SelectedIndex, e.RowIndex);
                goalDataShow();

            }
        }
    }
}
