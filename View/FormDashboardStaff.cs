using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormDashboardStaff : Form
    {
        public FormDashboardStaff()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormLoginScreen loginScreenForm = new FormLoginScreen();
            loginScreenForm.ShowDialog();
        }

        private void FormDashboardStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
