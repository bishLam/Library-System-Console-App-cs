using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormLoginScreen : Form
    {
        public FormLoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = username_TextBox.Text;
            String password = userpwd_TextBox.Text;

            username_TextBox.Focus();
            UserController userController = new UserController();
            User user = userController.UserLogin(username, password);

            if(user == null)
            {
                //invalid login
               
                MessageBox.Show("Invalid Username or Password! \n Try Again");
                
            }

            else
            {
                //valid login
                if (user.UserLevel == 1)
                {
                    FormDashboardUser formDashboard = new FormDashboardUser();
                    formDashboard.ShowDialog();
                }

                else if(user.UserLevel == 2)
                {
                    FormDashboardStaff userDashboardStaff = new FormDashboardStaff();
                    userDashboardStaff.ShowDialog();
                }

                else if(user.UserLevel == 3)
                {
                    FormDashboardAdmin userDashboardAdmin = new FormDashboardAdmin();
                    userDashboardAdmin.ShowDialog();
                }

                else
                {
                    MessageBox.Show("invalid user level found!");
                }

            }
        }

        private void LoginScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void username_TextBox_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void userpwd_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
