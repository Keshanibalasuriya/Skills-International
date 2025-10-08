using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        //Add button click event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        // LogOut button click event handler -> redirect to login form after confirmation
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                // Stay on the current form
                // Optional: you can add a message or simply do nothing
                // MessageBox.Show("Logout canceled.");
            }
        }



        // View btn 
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

        // update btn 
        private void button2_Click(object sender, EventArgs e)
        
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

                        // Pass data to Update form
                        this.Hide();
                        Update updateForm = new Update();
                        updateForm.LoadData(dt);
                        updateForm.Show();

                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            



        }

        // Delete button click event handlers
        private void button5_Click(object sender, EventArgs e)
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

                    // Pass data to Update form
                    this.Hide();
                    Delete deleteForm = new Delete();
                   // deleteForm.LoadData(dt);
                    deleteForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }


}

