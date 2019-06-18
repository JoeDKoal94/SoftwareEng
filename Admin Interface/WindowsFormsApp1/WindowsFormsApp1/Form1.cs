using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminInterface : Form
    {
        public adminInterface()
        {
            InitializeComponent();
        }

        private void addEditStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            addEditInfoForm admin = new addEditInfoForm();
            admin.Show();
        }
    }
}
