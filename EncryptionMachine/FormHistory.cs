using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace kyrsovaiy
{
    public partial class FormHistory : Form
    {
        DataSet ds = new DataSet();
        public FormHistory()
        {
            InitializeComponent();

            if (File.Exists("..\\..\\Data\\" + DataBank.NickName + ".txt"))
            {
                StreamReader rd = new StreamReader("..\\..\\Data\\" + DataBank.NickName + ".txt", false);

                ds.Tables.Add("Score");

                //Making colum
                ds.Tables[0].Columns.Add("Key");
                ds.Tables[0].Columns.Add("Action");
                ds.Tables[0].Columns.Add("Input");
                ds.Tables[0].Columns.Add("Output");

                //////////////////////////////
                
                ////Data
                string row = rd.ReadLine();
                while (row != null)
                {
                    string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, "///");
                    ds.Tables[0].Rows.Add(rvalue);
                    row = rd.ReadLine();
                }
                rd.Close();
                dataGridView1.Font = new Font("Comic Sans MS", 15);
                dataGridView1.DataSource = ds.Tables[0]; //show in DataGrid

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            else
            { 
               MessageBox.Show(
              "Your encryption history is empty",
              "Warning",
              MessageBoxButtons.OK);
            }   
        }    
    }
}
