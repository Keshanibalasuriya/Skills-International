namespace SkillTrack
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unametext = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pwdtext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.unametext);
            this.groupBox1.Location = new System.Drawing.Point(86, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(6, 197);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 45);
            this.Clear.TabIndex = 7;
            this.Clear.Text = " Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(233, 197);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(90, 45);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = " Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pwdtext
            // 
            this.pwdtext.Location = new System.Drawing.Point(113, 110);
            this.pwdtext.Name = "pwdtext";
            this.pwdtext.Size = new System.Drawing.Size(195, 22);
            this.pwdtext.TabIndex = 2;
            this.pwdtext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // unametext
            // 
            this.unametext.Location = new System.Drawing.Point(113, 54);
            this.unametext.Name = "unametext";
            this.unametext.Size = new System.Drawing.Size(195, 22);
            this.unametext.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 429);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 45);
            this.Exit.TabIndex = 6;
            this.Exit.Text = " Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(215)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(502, 486);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login- Skills International";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwdtext;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
    }
}

