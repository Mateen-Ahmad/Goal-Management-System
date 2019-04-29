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
    public partial class Roles : Form
    {
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Work");
            comboBox1.Items.Add("Self");
            comboBox1.Items.Add("Social");
            dataShow();
        }
        void dataShow()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < myserver.getRoleCount(Program.index); i++)
            {
                dataGridView1.Rows.Add(myserver.getRoleName(Program.index, i ), myserver.getRoleType(Program.index, i));
            }
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            var myRole = new ServiceReference1.Roles();
            myRole.RoleName = txtRoleName.Text;
            myRole.RoleType = comboBox1.SelectedItem.ToString();
            myserver.addRole(Program.index, myRole);
            dataShow();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                myserver.deleteRole(Program.index, e.RowIndex);
                dataShow();
            }
            if (e.ColumnIndex == 3)
            {

                
            }
        }
    }
}
