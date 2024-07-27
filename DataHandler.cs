using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace WindowsFormsApp1
{
    public class DataHandler
    {
        public void Insert(Questions questions)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\monza\\OneDrive\\Documents\\Register_db.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            string query = $"INSERT INTO UserInfo VALUES ('{questions.Username}', '{questions.Password}')";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();

                    }
                }


            }
            catch (Exception) { 
                
                throw;

            }

            try
            {
                


                var addr = new MailAddress(questions.email);
                // Email is valid; proceed with registration logic
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void RetrieveData(Questions questions)
        {

            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\monza\\OneDrive\\Documents\\Register_db.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("spRetrieveInfo", connect))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", questions.Username);
                        cmd.Parameters.AddWithValue("@password", questions.Password);

                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();

                    }
                }

                

            }
            catch (Exception) {

                throw;
            }

        }


    }
}
