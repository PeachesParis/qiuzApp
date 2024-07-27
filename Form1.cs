using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items) {
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                {
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\monza\\OneDrive\\Documents\\Questionsdb.mdf;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand("Insert Into SavedAns(sQuestions,ischecked)Values(@sQuestions,@ischecked)", conn);
                    cmd.Parameters.AddWithValue("sQuestions", checkedListBox1.Items[i]);
                    cmd.Parameters.AddWithValue("ischecked", checkedListBox1.GetItemCheckState(i));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data saved successfully");

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Not Saved!!!");

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Add(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
            this.Close();
          
        }
    }
}
