namespace Bus_Reservation
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.but_Logout = new System.Windows.Forms.Button();
            this.combo_From = new MetroFramework.Controls.MetroComboBox();
            this.lbl_From = new MetroFramework.Controls.MetroLabel();
            this.lbl_To = new MetroFramework.Controls.MetroLabel();
            this.combo_To = new MetroFramework.Controls.MetroComboBox();
            this.combo_busType = new MetroFramework.Controls.MetroComboBox();
            this.lbl_busType = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewForBus = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Reserve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxForMessage = new System.Windows.Forms.PictureBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pictureBoxforFromToCheck = new System.Windows.Forms.PictureBox();
            this.txt_IdForReserve = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxForError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForBus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforFromToCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForError)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Logout
            // 
            this.but_Logout.BackColor = System.Drawing.Color.Transparent;
            this.but_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Logout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.but_Logout.Location = new System.Drawing.Point(647, 6);
            this.but_Logout.Name = "but_Logout";
            this.but_Logout.Size = new System.Drawing.Size(75, 25);
            this.but_Logout.TabIndex = 1;
            this.but_Logout.Text = "Sign Out";
            this.but_Logout.UseVisualStyleBackColor = false;
            this.but_Logout.Click += new System.EventHandler(this.but_Logout_Click);
            // 
            // combo_From
            // 
            this.combo_From.FormattingEnabled = true;
            this.combo_From.ItemHeight = 23;
            this.combo_From.Location = new System.Drawing.Point(76, 43);
            this.combo_From.Name = "combo_From";
            this.combo_From.Size = new System.Drawing.Size(125, 29);
            this.combo_From.TabIndex = 2;
            this.combo_From.SelectedIndexChanged += new System.EventHandler(this.combo_From_SelectedIndexChanged);
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.BackColor = System.Drawing.Color.Transparent;
            this.lbl_From.Location = new System.Drawing.Point(33, 48);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(41, 19);
            this.lbl_From.TabIndex = 3;
            this.lbl_From.Text = "From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(203, 48);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(22, 19);
            this.lbl_To.TabIndex = 4;
            this.lbl_To.Text = "To";
            // 
            // combo_To
            // 
            this.combo_To.FormattingEnabled = true;
            this.combo_To.ItemHeight = 23;
            this.combo_To.Location = new System.Drawing.Point(229, 43);
            this.combo_To.Name = "combo_To";
            this.combo_To.Size = new System.Drawing.Size(121, 29);
            this.combo_To.TabIndex = 5;
            this.combo_To.SelectedIndexChanged += new System.EventHandler(this.combo_To_SelectedIndexChanged);
            // 
            // combo_busType
            // 
            this.combo_busType.FormattingEnabled = true;
            this.combo_busType.ItemHeight = 23;
            this.combo_busType.Location = new System.Drawing.Point(449, 43);
            this.combo_busType.Name = "combo_busType";
            this.combo_busType.Size = new System.Drawing.Size(251, 29);
            this.combo_busType.TabIndex = 6;
            this.combo_busType.SelectedIndexChanged += new System.EventHandler(this.combo_busType_SelectedIndexChanged);
            // 
            // lbl_busType
            // 
            this.lbl_busType.AutoSize = true;
            this.lbl_busType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_busType.Location = new System.Drawing.Point(383, 48);
            this.lbl_busType.Name = "lbl_busType";
            this.lbl_busType.Size = new System.Drawing.Size(60, 19);
            this.lbl_busType.TabIndex = 7;
            this.lbl_busType.Text = "Bus Type";
            // 
            // dataGridViewForBus
            // 
            this.dataGridViewForBus.AllowUserToAddRows = false;
            this.dataGridViewForBus.AllowUserToDeleteRows = false;
            this.dataGridViewForBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.BusName,
            this.BusType,
            this.From,
            this.To,
            this.Time});
            this.dataGridViewForBus.Location = new System.Drawing.Point(33, 97);
            this.dataGridViewForBus.Name = "dataGridViewForBus";
            this.dataGridViewForBus.ReadOnly = true;
            this.dataGridViewForBus.Size = new System.Drawing.Size(667, 261);
            this.dataGridViewForBus.TabIndex = 13;
            // 
            // Number
            // 
            this.Number.HeaderText = "ID";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // BusName
            // 
            this.BusName.HeaderText = "Bus Name";
            this.BusName.Name = "BusName";
            this.BusName.ReadOnly = true;
            // 
            // BusType
            // 
            this.BusType.HeaderText = "Type";
            this.BusType.Name = "BusType";
            this.BusType.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // but_Reserve
            // 
            this.but_Reserve.BackColor = System.Drawing.Color.MidnightBlue;
            this.but_Reserve.FlatAppearance.BorderSize = 0;
            this.but_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.but_Reserve.ForeColor = System.Drawing.Color.White;
            this.but_Reserve.Location = new System.Drawing.Point(582, 377);
            this.but_Reserve.Name = "but_Reserve";
            this.but_Reserve.Size = new System.Drawing.Size(118, 31);
            this.but_Reserve.TabIndex = 15;
            this.but_Reserve.Text = "Reserve";
            this.but_Reserve.UseVisualStyleBackColor = false;
            this.but_Reserve.Click += new System.EventHandler(this.but_Reserve_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBoxForMessage);
            this.panel1.Controls.Add(this.lbl_Message);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-1, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 36);
            this.panel1.TabIndex = 17;
            // 
            // pictureBoxForMessage
            // 
            this.pictureBoxForMessage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForMessage.Image")));
            this.pictureBoxForMessage.Location = new System.Drawing.Point(34, 7);
            this.pictureBoxForMessage.Name = "pictureBoxForMessage";
            this.pictureBoxForMessage.Size = new System.Drawing.Size(18, 23);
            this.pictureBoxForMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForMessage.TabIndex = 1;
            this.pictureBoxForMessage.TabStop = false;
            this.pictureBoxForMessage.Visible = false;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_Message.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Message.Location = new System.Drawing.Point(55, 9);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(65, 16);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "Message";
            // 
            // pictureBoxforFromToCheck
            // 
            this.pictureBoxforFromToCheck.ErrorImage = global::Bus_Reservation.Properties.Resources.sign_red_error_icon_1;
            this.pictureBoxforFromToCheck.Image = global::Bus_Reservation.Properties.Resources.sign_red_error_icon_1;
            this.pictureBoxforFromToCheck.Location = new System.Drawing.Point(352, 45);
            this.pictureBoxforFromToCheck.Name = "pictureBoxforFromToCheck";
            this.pictureBoxforFromToCheck.Size = new System.Drawing.Size(18, 23);
            this.pictureBoxforFromToCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxforFromToCheck.TabIndex = 2;
            this.pictureBoxforFromToCheck.TabStop = false;
            this.pictureBoxforFromToCheck.Visible = false;
            // 
            // txt_IdForReserve
            // 
            this.txt_IdForReserve.Location = new System.Drawing.Point(440, 381);
            this.txt_IdForReserve.Name = "txt_IdForReserve";
            this.txt_IdForReserve.Size = new System.Drawing.Size(117, 23);
            this.txt_IdForReserve.TabIndex = 18;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(338, 383);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Bus ID Number";
            // 
            // pictureBoxForError
            // 
            this.pictureBoxForError.ErrorImage = global::Bus_Reservation.Properties.Resources.sign_red_error_icon_1;
            this.pictureBoxForError.Image = global::Bus_Reservation.Properties.Resources.sign_red_error_icon_1;
            this.pictureBoxForError.Location = new System.Drawing.Point(558, 383);
            this.pictureBoxForError.Name = "pictureBoxForError";
            this.pictureBoxForError.Size = new System.Drawing.Size(18, 23);
            this.pictureBoxForError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForError.TabIndex = 20;
            this.pictureBoxForError.TabStop = false;
            this.pictureBoxForError.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 449);
            this.Controls.Add(this.pictureBoxForError);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_IdForReserve);
            this.Controls.Add(this.pictureBoxforFromToCheck);
            this.Controls.Add(this.but_Reserve);
            this.Controls.Add(this.dataGridViewForBus);
            this.Controls.Add(this.lbl_busType);
            this.Controls.Add(this.combo_busType);
            this.Controls.Add(this.combo_To);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.combo_From);
            this.Controls.Add(this.but_Logout);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCG Bus Seat Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForBus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforFromToCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Logout;
        private MetroFramework.Controls.MetroComboBox combo_From;
        private MetroFramework.Controls.MetroLabel lbl_From;
        private MetroFramework.Controls.MetroLabel lbl_To;
        private MetroFramework.Controls.MetroComboBox combo_To;
        private MetroFramework.Controls.MetroComboBox combo_busType;
        private MetroFramework.Controls.MetroLabel lbl_busType;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewForBus;
        private System.Windows.Forms.Button but_Reserve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.PictureBox pictureBoxForMessage;
        private System.Windows.Forms.PictureBox pictureBoxforFromToCheck;
        private MetroFramework.Controls.MetroTextBox txt_IdForReserve;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.PictureBox pictureBoxForError;
    }
}