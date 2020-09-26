using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace kyrsovaiy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Vigener.Tabl(ref DataBank.Vigen_arr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/Information.txt"); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // call the main form of the application that opened the current Form1, the main form always = 0
            DataBank.Shifr = null;
            DataBank.Word = null;
            DataBank.Key = null;
            Application.OpenForms[0].Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/Information.txt");
        }

        private void buttonTabl_Click(object sender, EventArgs e)
        {
            FormShow show = new FormShow();
            show.Show();
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            FormKey keyform = new FormKey();
            keyform.Show();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (DataBank.Key != null)
            {
                if (textBox1.Text != null)
                {
                    StreamWriter writer = new StreamWriter("..\\..\\Data\\" + DataBank.NickName + ".txt", true);
                    writer.Write(DataBank.Key + "///");

                    if (radioButtonDec.Checked)
                    {
                        DataBank.Action = "Decryption";
                        writer.Write(DataBank.Action + "///");

                        textBox2.Clear();

                        DataBank.Shifr = textBox1.Text;
                        Transformations.Decrypt();
                        textBox2.Text = DataBank.Word;

                        writer.Write(DataBank.Shifr + "///");
                        writer.WriteLine(DataBank.Word);
                        buttonStart.Enabled = false;
                    }

                    else if (radioButtonEnc.Checked)
                    {
                        DataBank.Action = "Encryption";
                        writer.Write(DataBank.Action + "///");

                        textBox2.Clear();

                        DataBank.Word = textBox1.Text;
                        Transformations.Encrypt();
                        textBox2.Text = DataBank.Shifr;

                        writer.Write(DataBank.Word + "///");
                        writer.WriteLine(DataBank.Shifr);
                        buttonStart.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("What do you wont to do?");
                    }

                    writer.Close();
                }
                else
                {
                    MessageBox.Show("Please write a Text");
                }

            }
            else
            {
                MessageBox.Show("Please write a kay!");
            }
        }

        private void ButtonRef_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            DataBank.Shifr = null;
            DataBank.Word = null;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistory fhist = new FormHistory();
            fhist.Show();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar < 91 && e.KeyChar > 64 || e.KeyChar > 96 && e.KeyChar < 123||
                e.KeyChar < 58 && e.KeyChar > 47|| e.KeyChar == 8||e.KeyChar==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        
         ////////////////Отображение автора работы
        
        private void LabelDeveloper_Click(object sender, EventArgs e)
        {
            FormDeveloper fd = new FormDeveloper();
            fd.Show();
        }

        //Personalization
        
        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("B:\\Programming\\C#\\kyrsovaiy\\kyrsovaiy\\FontImage.jpg");
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("B:\\Programming\\C#\\kyrsovaiy\\kyrsovaiy\\FontImage(2).jpg");

        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("B:\\Programming\\C#\\kyrsovaiy\\kyrsovaiy\\FontImage(3).jpg");
            groupBox1.ForeColor = Color.White;
            radioButtonDec.ForeColor = Color.White;
            radioButtonEnc.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

       ////////////////////
       
        
    }
}
