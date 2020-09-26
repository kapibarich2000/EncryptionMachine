using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaiy
{
    public partial class FormShow : Form
    {
        string res1 = null;
        static string res2 = "Tabl:\n";

        public FormShow()
        {
            InitializeComponent();

            string PassStr = "\n";

            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    res1 = DataBank.Vigen_arr[i, j].ToString();
                    res2 = res2 + res1;

                    if (j == 0)//To add back space
                    { res2 = res2 + " "; }
                }
                res2 = res2 + PassStr;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            labelTabl.Text = res2;
        }
    }
}
