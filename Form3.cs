using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();

        private void button1_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions(textBox1.Text, textBox2.Text);
            handler.RetrieveData(questions);
            MessageBox.Show("Sign_up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();


        }


    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            this.Close();
        }
    }
}
