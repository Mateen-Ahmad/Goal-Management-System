using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goal_Management_System
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            (new Roles()).Show();
        }

        private void BtnGoals_Click(object sender, EventArgs e)
        {
            (new Goals()).Show();
        }

        private void BtnToDos_Click(object sender, EventArgs e)
        {
            (new Tasks()).Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
