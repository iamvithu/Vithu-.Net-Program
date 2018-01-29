namespace Bus_Reservation
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.but_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.but_Retry = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.Color.MidnightBlue;
            this.but_login.FlatAppearance.BorderSize = 0;
            this.but_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.but_login.ForeColor = System.Drawing.Color.White;
            this.but_login.Location = new System.Drawing.Point(235, 176);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(208, 32);
            this.but_login.TabIndex = 9;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxError);
            this.panel1.Controls.Add(this.but_Retry);
            this.panel1.Controls.Add(this.but_exit);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_userName);
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Controls.Add(this.but_login);
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 267);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(241, 65);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(202, 143);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 16;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // but_Retry
            // 
            this.but_Retry.BackColor = System.Drawing.Color.MidnightBlue;
            this.but_Retry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_Retry.FlatAppearance.BorderSize = 0;
            this.but_Retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.but_Retry.ForeColor = System.Drawing.Color.White;
            this.but_Retry.Location = new System.Drawing.Point(257, 214);
            this.but_Retry.Name = "but_Retry";
            this.but_Retry.Size = new System.Drawing.Size(160, 32);
            this.but_Retry.TabIndex = 15;
            this.but_Retry.Text = "Retry";
            this.but_Retry.UseVisualStyleBackColor = false;
            this.but_Retry.Visible = false;
            this.but_Retry.Click += new System.EventHandler(this.but_Retry_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.Gray;
            this.but_exit.FlatAppearance.BorderSize = 0;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.but_exit.ForeColor = System.Drawing.Color.White;
            this.but_exit.Location = new System.Drawing.Point(235, 214);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(208, 32);
            this.but_exit.TabIndex = 10;
            this.but_exit.Text = "Exit";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Password.Location = new System.Drawing.Point(235, 145);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(208, 22);
            this.txt_Password.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lbl_title
            // 
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(-6, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(715, 32);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "NCG Bus Seat Reservation System";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(235, 126);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(68, 16);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_userName.ForeColor = System.Drawing.Color.Black;
            this.lbl_userName.Location = new System.Drawing.Point(235, 79);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(77, 16);
            this.lbl_userName.TabIndex = 9;
            this.lbl_userName.Text = "User Name";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_userName.Location = new System.Drawing.Point(235, 99);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(208, 22);
            this.txt_userName.TabIndex = 7;
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Developed by Vithushan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Bus_Reservation.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCG Bus Seat Reservation System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_Retry;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label label1;
    }
}

