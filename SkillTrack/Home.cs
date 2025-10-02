using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillTrack
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                                  "Are you sure you want to exit?",
                                  "Exit Confirmation",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question
                              );

            if (dialog == DialogResult.Yes)
            {
                Application.Exit(); // Close the whole application
            }
            else
            {
                // Do nothing, message box will automatically close
            }
        }

        private void button3_Click(object sender, EventArgs e)


        {
            Connection db = new Connection();   // use your Connection class
            using (SqlConnection con = db.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Registration";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Pass data to View form
                    View viewForm = new View();
                    viewForm.LoadData(dt);
                    viewForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }


}

