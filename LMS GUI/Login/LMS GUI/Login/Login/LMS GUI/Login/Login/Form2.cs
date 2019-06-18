using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class studentInterface : Form
    {
        public studentInterface()
        {
            InitializeComponent();
        }

        private void addEditStudent_Click(object sender, EventArgs e)
        {

        }

        private void exitAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginWindow exit = new loginWindow();
            exit.Show();
        }
    }
}
