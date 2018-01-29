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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            GetRouteData();
            GetBusTypeData();
            GetBusTravelData(0,null,null);
        }

        private void but_Logout_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            LoginForm frm1 = new LoginForm();
            frm1.Show();
        }

        private void combo_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_To_SelectedIndexChanged(sender, e);
        }

        private void combo_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_From.Text == combo_To.Text)
            {
                lbl_Message.Text = "Note : Same Locations are selected";
                pictureBoxforFromToCheck.Visible = true;
            }
            else
            {
                lbl_Message.Text = "Connection Successful";
                pictureBoxforFromToCheck.Visible = false;
            }

            if (combo_To.SelectedIndex < combo_From.SelectedIndex)
            {
                dataGridViewForBus.Rows.Clear();
                GetBusTravelData(1, null, null);

            }
            else if (combo_To.SelectedIndex == combo_From.SelectedIndex)
            {
                pictureBoxforFromToCheck.Visible = true;
                dataGridViewForBus.Rows.Clear();
                lbl_Message.Text = "Note : Same Locations are selected";
            }else{
                dataGridViewForBus.Rows.Clear();
                GetBusTravelData(2,null,null);
            }
        }

        private void GetRouteData()
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                string stm = "Select Id,route from route";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        combo_From.Items.Add(rdr["route"].ToString());
                        combo_To.Items.Add(rdr["route"].ToString());
                    }
                    lbl_Message.Text = "Connection Successful";
                    pictureBoxForMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are no values in the Database");
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }
        private void GetBusTypeData()
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                string stm = "Select Type from bustype";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        combo_busType.Items.Add(rdr["Type"].ToString());
                    }
                    lbl_Message.Text = "Connection Successful";
                    pictureBoxForMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are no values in the Database");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }
        private void GetBusTravelData(int Num,String busFrom,String busTo)
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            
            try
            {
                cnn.Open();
                string stm;
                switch (Num) {
                    case 0:  stm = "Select * from travel"; break;
                    case 1:  stm = "Select * from travel where busFrom=\"Jaffna\" and busTo=\"Colombo\""; break;
                    case 2:  stm = "Select * from travel where busFrom=\"Colombo\" and busTo=\"Jaffna\""; break;
                    case 3: stm = "Select * from travel where busType=\"Luxury\" and busFrom=\""+busFrom+"\" and busTo=\""+busTo+"\""; break;
                    case 4: stm = "Select * from travel where busType=\"Semi Luxury\" and busFrom=\""+busFrom+"\" and busTo=\""+busTo+"\""; break;
                    default: stm = "Select * from travel"; break;
                };
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                try
                {
                    int i = 0;
                    while (rdr.Read())
                    {
                        //if (Num == 0)
                        //{
                            dataGridViewForBus.Rows.Add();
                        //}
                        //combo_busType.Items.Add(rdr["Type"].ToString());
                        int x = 0;
                        dataGridViewForBus.Rows[i].Cells[x++].Value = rdr["Id"].ToString();
                        dataGridViewForBus.Rows[i].Cells[x++].Value = rdr["busName"].ToString();
                        dataGridViewForBus.Rows[i].Cells[x++].Value = rdr["busType"].ToString();
                        dataGridViewForBus.Rows[i].Cells[x++].Value = rdr["busFrom"].ToString();
                        dataGridViewForBus.Rows[i].Cells[x++].Value = rdr["busTo"].ToString();
                        dataGridViewForBus.Rows[i].Cells[x].Value = rdr["Time"].ToString();
                        i++;
                        
                    }
                    lbl_Message.Text = "Connection Successful";
                    pictureBoxForMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are no values in the Travel Database");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void but_Reserve_Click(object sender, EventArgs e)
        {
            if((combo_From.Text=="" && combo_To.Text==""))
            {
                lbl_Message.Text = "Please choose your beginning and ending places";
            }
            else if(txt_IdForReserve.Text=="") {
                lbl_Message.Text = "Please Enter the ID Number";
            }
            else{
                try
                {
                    ActiveForm.Hide();
                    new Reserve(Int32.Parse(txt_IdForReserve.Text),Math.Abs(combo_From.SelectedIndex-combo_To.SelectedIndex),combo_From.Text,combo_To.Text).Show();
                }catch(Exception ex)
                {
                    pictureBoxForError.Visible = true;
                    lbl_Message.Text = "Please Enter the ID Number";
                }
            }

        }

        private void combo_busType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_busType.Text == "Luxury")
            {
                dataGridViewForBus.Rows.Clear();
                GetBusTravelData(3, BeginRouteFind(), EndRouteFind());
            }
            else
            {
                dataGridViewForBus.Rows.Clear();
                GetBusTravelData(4, BeginRouteFind(), EndRouteFind());
            }
        }
        private string BeginRouteFind()
        {
            if (combo_To.SelectedIndex < combo_From.SelectedIndex)
            {
                return "Jaffna";
            }
            else
            {
                return "Colombo";
            }
        }
        private string EndRouteFind()
        {
            if (combo_To.SelectedIndex < combo_From.SelectedIndex)
            {
                return "Colombo";
            }
            else
            {
                return "Jaffna";
            }
        }
    }
}
