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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
       
        {
            // Clear textboxes
            
            firstName.Text = "";
            lastName.Text = "";
            address.Text = "";
            email.Text = "";
            mobilePhone.Text = "";
            homePhone.Text = "";
            parentName.Text = "";
            nic.Text = "";
            contactNo.Text = "";

            // Reset DateTimePicker
            dateOfBirth.Value = DateTime.Now;

            // Reset RadioButtons
            male.Checked = false;
            female.Checked = false;

            // Reset ComboBox
            regNo.SelectedIndex = -1; // clears selection

            // Optionally show a message
            MessageBox.Show("Form cleared!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                regNo = Convert.ToInt32(regNo.Text),
                firstName = firstName.Text.Trim(),
                lastName = lastName.Text.Trim(),
                dateOfBirth = dateOfBirth.Value,
                gender = male.Checked ? "Male" : "Female",
                address = address.Text.Trim(),
                email = email.Text.Trim(),
                mobilePhone = int.Parse(mobilePhone.Text),
                homePhone = int.Parse(homePhone.Text),
                parentName = parentName.Text.Trim(),
                nic = nic.Text.Trim(),
                contactNo = int.Parse(contactNo.Text)
            };

            Services ser = new Services();
            if (ser.AddStudent(student))
                MessageBox.Show("Record Added Successfully",
                 "Success",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            else
                MessageBox.Show("❌ Registration Failed");
        }


        //Exit linklabel
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        //Home btn
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void LogOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();  
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {   this.Hide();
            Delete delete = new Delete();
            delete.Show();
        }
    }
}
