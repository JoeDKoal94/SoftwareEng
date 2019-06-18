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
    public partial class addEditInfoForm : Form
    {
        public addEditInfoForm()
        {
            InitializeComponent();
        }

        private void backButtonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard interFace = new Dashboard();
            interFace.Show();
        }
    }
}
