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
    public partial class Form1 : Form
    {
        
        ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference1.Users u = new ServiceReference1.Users();
            u.UserName = textBox1.Text;
            u.Password = textBox2.Text;
            myserver.addUsers(u);
            label3.Text = "Signed up Successfully!";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
            ServiceReference1.Users u = new ServiceReference1.Users();
            u.UserName = textBox1.Text;
            u.Password = textBox2.Text;
            bool flag = false;
            int i;
            for (i = 0; i < myserver.getCount(); ++i)
            {
                if (textBox1.Text == myserver.getUserName(i) && textBox2.Text == myserver.getPassword(i))
                {
                    flag = true;
                    break;
                }
            }
            Program.index = i;
            MessageBox.Show(""+i);
            if (flag == true)
            {
                this.Hide();
                (new Roles()).Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
