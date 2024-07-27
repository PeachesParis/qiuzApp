using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        DataHandler handler = new DataHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have a form named "RegistrationForm" with appropriate controls

            // Remember to hash the password before saving it!

            Questions questions = new Questions(textBox1.Text, textBox3.Text, textBox2.Text);
            handler.Insert(questions);
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 first= new Form3();
            first.Show();
          
        }
    }   
}
