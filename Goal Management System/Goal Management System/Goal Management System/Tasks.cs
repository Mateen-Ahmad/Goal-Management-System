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
    public partial class Tasks : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        int index;
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myserver.getRoleCount(Program.index); ++i)
            {
                for (int j = 0; j<myserver.getGoalCount(Program.index, i); ++j)
                {
                    cmbGoalName.Items.Add(myserver.getGoalName(Program.index, i, j));

                }
            }

        }

        private void CmbGoalName_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cmbGoalName.SelectedIndex;
            //lblRoleName = myserver.getRoleName(Program.index, index)

        }
    }
}
