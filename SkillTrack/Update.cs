using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillTrack
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent(); //  Always first
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            //Just load data — don’t create another Update form
            RefreshGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                regNo.Text = row.Cells["regNo"].Value.ToString();
                firstName.Text = row.Cells["firstName"].Value.ToString();
                lastName.Text = row.Cells["lastName"].Value.ToString();

                if (row.Cells["dateOfBirth"].Value != DBNull.Value)
                    dateOfBirth.Value = Convert.ToDateTime(row.Cells["dateOfBirth"].Value);

                string selectedGender = row.Cells["gender"].Value.ToString();

                if (selectedGender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                {
                    male.Checked = true;
                    female.Checked = false;
                }
                else if (selectedGender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    male.Checked = false;
                    female.Checked = true;
                }
                else
                {
                    male.Checked = false;
                    female.Checked = false;
                }

                address.Text = row.Cells["address"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                mobilePhone.Text = row.Cells["mobilePhone"].Value.ToString();
                homePhone.Text = row.Cells["homePhone"].Value.ToString();
                parentName.Text = row.Cells["parentName"].Value.ToString();
                nic.Text = row.Cells["nic"].Value.ToString();
                contactNo.Text = row.Cells["contactNo"].Value.ToString();
            }
        }

        public void LoadData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        // Update button click event handler -> update the DB
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection db = new Connection();
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = @"UPDATE Registration 
                                     SET firstName = @firstName,
                                         lastName = @lastName,
                                         dateOfBirth = @dateOfBirth,
                                         gender = @gender,
                                         address = @address,
                                         email = @email,
                                         mobilePhone = @mobilePhone,
                                         homePhone = @homePhone,
                                         parentName = @parentName,
                                         nic = @nic,
                                         contactNo = @contactNo
                                     WHERE regNo = @regNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNo.Text);
                        cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.Value);

                        string selectedGender = male.Checked ? "Male" : female.Checked ? "Female" : "";
                        cmd.Parameters.AddWithValue("@gender", selectedGender);

                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone.Text);
                        cmd.Parameters.AddWithValue("@homePhone", homePhone.Text);
                        cmd.Parameters.AddWithValue("@parentName", parentName.Text);
                        cmd.Parameters.AddWithValue("@nic", nic.Text);
                        cmd.Parameters.AddWithValue("@contactNo", contactNo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshGrid();
                        }
                        else
                        {
                            MessageBox.Show("No record updated. Please check the Reg No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                Connection db = new Connection();
                using (SqlConnection con = db.GetConnection())
                {
                    string query = "SELECT * FROM Registration";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        // Home button click event handler -> redirect to Home form

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        // Home button click event handler -> redirect to Home form

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                Connection db = new Connection();
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = @"UPDATE Registration 
                                     SET firstName = @firstName,
                                         lastName = @lastName,
                                         dateOfBirth = @dateOfBirth,
                                         gender = @gender,
                                         address = @address,
                                         email = @email,
                                         mobilePhone = @mobilePhone,
                                         homePhone = @homePhone,
                                         parentName = @parentName,
                                         nic = @nic,
                                         contactNo = @contactNo
                                     WHERE regNo = @regNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNo.Text);
                        cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.Value);

                        string selectedGender = male.Checked ? "Male" : female.Checked ? "Female" : "";
                        cmd.Parameters.AddWithValue("@gender", selectedGender);

                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone.Text);
                        cmd.Parameters.AddWithValue("@homePhone", homePhone.Text);
                        cmd.Parameters.AddWithValue("@parentName", parentName.Text);
                        cmd.Parameters.AddWithValue("@nic", nic.Text);
                        cmd.Parameters.AddWithValue("@contactNo", contactNo.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshGrid();
                        }
                        else
                        {
                            MessageBox.Show("No record updated. Please check the Reg No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

