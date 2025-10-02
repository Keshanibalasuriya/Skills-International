using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // db connection
            Connection db = new Connection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                   // MessageBox.Show("Connected to Student database!");

                    // login validation
                    string username = unametext.Text.Trim();
                    string password = pwdtext.Text.Trim();

                    string query = "SELECT COUNT(*) FROM Logins WHERE username=@username AND password=@password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            //MessageBox.Show("Login Successful!");
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login credentials, please check Username and Password.",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear both textboxes
            unametext.Text = "";
            pwdtext.Text = "";

            // Set focus back to username
            unametext.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
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
    } // <-- closes class
} // <-- closes namespace
