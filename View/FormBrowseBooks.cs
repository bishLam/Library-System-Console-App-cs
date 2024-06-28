using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

//Presentation Layer
namespace View
{
    public partial class FormBrowseBooks : Form
    {
        public FormBrowseBooks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) { 
        
            //call the controller class which is relevant to books i.e BookController
            BookController bookController = new BookController();
            BrowseBooksListGrid.DataSource = bookController.BrowseBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
