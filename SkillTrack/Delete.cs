using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillTrack
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();

            // Set DataGridView to select full row when clicking any cell
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Only allow one row to be selected
            dataGridView1.CellClick += DataGridView1_CellClick; // Optional visual selection

            RefreshGrid();
        }

        // Optional: ensure clicking any cell selects the whole row
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header clicks
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRegNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["regNo"].Value);

                DialogResult dialog = MessageBox.Show(
                    $"Are you sure you want to delete registration number {selectedRegNo}?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        Connection db = new Connection();
                        using (SqlConnection con = db.GetConnection())
                        {
                            con.Open();
                            string query = "DELETE FROM Registration WHERE regNo = @regNo";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@regNo", selectedRegNo);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    RefreshGrid();
                                }
                                else
                                {
                                    MessageBox.Show("No record deleted. Please check the Reg No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.Show();
        }
    }
}
