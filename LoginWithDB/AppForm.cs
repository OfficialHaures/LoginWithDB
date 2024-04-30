using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWithDB
{
    public partial class AppForm : Form
    { 
        public AppForm()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void update_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database UPDATED");
        }
    }
}
