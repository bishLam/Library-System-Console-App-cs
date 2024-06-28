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
    public partial class FormDashboardUser : Form
    {
        public FormDashboardUser()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormLoginScreen loginScreenForm = new FormLoginScreen();
            loginScreenForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //browse books button
        {
            FormBrowseBooks formBrowseBooks = new FormBrowseBooks();
            formBrowseBooks.ShowDialog();
        }

        private void searchBooksBtn_Click(object sender, EventArgs e)
        {
            FormSearchScreen searchScreenForm = new FormSearchScreen();
            searchScreenForm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboardUser_Load(object sender, EventArgs e)
        {

        }
    }
}
