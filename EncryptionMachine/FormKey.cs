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
    public partial class FormKey : Form
    {
        static public string tempKey;

        public FormKey()
        {
            InitializeComponent();

            textboxKey.Text = "Enter key";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textboxKey.Text != "Enter key")
            {
                DataBank.Key = textboxKey.Text;

                this.Close();
                MessageBox.Show("Key saved");
            }
            else
            {
                MessageBox.Show(
                "Введите ключ",
                "Ошибка",
                MessageBoxButtons.OK);
            }
        }

        private void TextboxKey_KeyPress(object sender, KeyPressEventArgs e)
        {        
                char number = e.KeyChar;
                if (e.KeyChar < 91 && e.KeyChar > 64 || e.KeyChar > 96 && e.KeyChar < 123 ||
                    e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                e.Handled = true;
                }
        }
    }
}
