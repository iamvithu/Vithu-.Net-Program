using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bus_Reservation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            but_login.Visible = false;
            but_exit.Visible = false;
            txt_userName.Visible = false;
            txt_Password.Visible = false;
            lbl_userName.Visible = false;
            lbl_password.Visible = false;
            lbl_title.Text = "Please wait...";
            pictureBox1.Visible = true;
            DbConnect();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            //timerLoading.Stop();
            //this.Hide();
            //new Form2().Show();
        }
        private void DbConnect()
        {
            DbConnect connection = new DbConnect();

            MySqlConnection cnn = connection.DatabaseConnect();
            String username = txt_userName.Text;
            String password = txt_Password.Text;
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                string stm = "SELECT * from users where username=\""+username+"\" and password=\""+password+"\"";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    //MessageBox.Show(rdr["username"].ToString()+ rdr["password"].ToString());
                    cnn.Close();
                    ActiveForm.Hide();
                    new Home().Show();
                }
                else
                {
                    lbl_title.Text = "Check your Username and Password";
                    pictureBox1.Visible = false;
                    but_login.Visible = true;
                    but_exit.Visible = true;
                    txt_userName.Visible = true;
                    txt_Password.Visible = true;
                    lbl_userName.Visible = true;
                    lbl_password.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                pictureBox1.Visible = false;
                lbl_title.Text = "Database Connection Failed";
                pictureBoxError.Visible = true;
                but_Retry.Visible = true;
            }

        }

        private void but_Retry_Click(object sender, EventArgs e)
        {
            pictureBoxError.Visible = false;
            but_Retry.Visible = false;
            but_login_Click(sender, e);
        }
    }
}
