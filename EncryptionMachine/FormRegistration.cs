using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaiy
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            ////return Information - instruction in Folder
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            DataBank.NickName = textBoxName.Text;

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

           this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
