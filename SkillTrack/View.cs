using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillTrack
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
