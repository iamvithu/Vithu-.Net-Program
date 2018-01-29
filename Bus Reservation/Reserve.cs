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
using System.Text.RegularExpressions;

namespace Bus_Reservation
{

    public partial class Reserve : Form
    {
        public String[] BusReserveData = new String[100];
        /*BusReserveData Array Details
         * BusReserveData[0]=BusName
         * BusReserveData[1]=BusTo
         * BusReserveData[2]=BusFrom
         * BusReserveData[3]=BusPrice
         * BusReserveData[4]=Customer Name
         * BusReserveData[5]=Contact Number
         * BusReserveData[6]=Date
         * BusReserveData[7]=Time
        */
        public int ReserveBusNum;
        public int price;

        public String From;
        public String To;
        public Reserve()
        {
            InitializeComponent();
        }
        public Reserve(int Num, int PriceVal,String From,String To)
        {
            InitializeComponent();
            this.ReserveBusNum = Num;
            this.price = PriceVal * 100;
            this.From = From;
            this.To = To;
            GetTravelBusData();
            GetReserveData();
        }
        private void GetTravelBusData()
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                string stm = "Select * from travel where id=" + ReserveBusNum;
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        BusReserveData[0] = rdr["busName"].ToString();
                        BusReserveData[1] = To;
                        BusReserveData[2] = From;
                        BusReserveData[3] = price.ToString();
                        BusReserveData[7] = rdr["Time"].ToString();

                        lbl_BusDetails.Text = rdr["busName"].ToString() +
                                                "\n" + From+
                                                "\n" + To+
                                                "\n" + rdr["Time"].ToString() +
                                                "\n" + rdr["busType"].ToString() +
                                                "\n" + price + "/=";
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

        private void seat1_Click(object sender, EventArgs e)
        {
            Button lbtn = (Button)sender;
            if (lbtn.BackColor == System.Drawing.Color.LimeGreen)
            {
                String fName = txt_firstName.Text;
                String lName = txt_lName.Text;
                String Gender = combo_Gender.Text;
                String Contact = txt_Contact.Text;

                try
                {
                    if (combo_Gender.Text == "Male")
                    {
                        Gender = "Male";
                    }
                    else if (combo_Gender.Text == "Female")
                    {
                        Gender = "Female";
                    }
                    else
                    {
                        lbl_Message.Text = "Please Select Gender";
                        return;
                    }

                    if (string.IsNullOrEmpty(txt_Contact.Text))
                    {
                        lbl_Message.Text = "Mobile Number required!";
                        return;
                    }
                    else if (!Regex.IsMatch(txt_Contact.Text, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
                    {
                        lbl_Message.Text = "Mobile Number invalid!";
                        return;
                    }
                    else
                    {
                        lbl_Message.Text = "Connection Successful";
                    }
                }

                catch
                {

                }
                //Booking details Insert query
                String query = "INSERT INTO booking (seatId, busId, date, fName, lName, Gender,Contact) VALUES (" + lbtn.Text + ", " + ReserveBusNum + ",\"" + datePicker1.Value.Date.ToString("d") + "\", \"" + fName + "\"" + ",\"" + lName + "\",\"" + Gender + "\"," + Contact + ")";
                BookingDataConnect(query);
                lbtn.BackColor = System.Drawing.Color.OrangeRed;
            }
            else if (lbtn.BackColor == Color.Orange)
            {
                lbl_Message.Text="You Cant Remove the Reserve Seat!!";
            }
            else
            {

                DialogResult result1 = MessageBox.Show("Are you sure to Remove booking", "Critical Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign, false);

                if (result1 == DialogResult.OK)
                {
                    String query = "DELETE FROM booking WHERE SeatId =" + lbtn.Text + " and busId=" + ReserveBusNum + " and date='" + datePicker1.Value.Date.ToString("d") + "'";
                    BookingDataConnect(query);

                }
                lbtn.BackColor = System.Drawing.Color.LimeGreen;
            }
        }
        private void BookingDataConnect(String stm)
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }
        private void GetReserveData()
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();

            try
            {
                cnn.Open();
                string stm = "SELECT seatId FROM booking WHERE busId=" + ReserveBusNum + " and date='" + datePicker1.Value.Date.ToString("d") + "'";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        string buttonName = "seat" + rdr["seatId"].ToString();
                        BookingSeatsData(buttonName);
                        //String[] ButNames =
                        //{
                        //    "seat1","seat2","seat3","seat4","seat5","seat6","seat7","seat8","seat9",
                        //    "seat10","seat11","seat12","seat13","seat14","seat15","seat16","seat17","seat18","seat19",
                        //    "seat20","seat21","seat22","seat23","seat24","seat25","seat26","seat27","seat28","seat29",
                        //    "seat30","seat31","seat32","seat33","seat34","seat35","seat36","seat37","seat38","seat39",
                        //    "seat40"
                        //};
                    }

                }
                catch (Exception ex)
                {

                }
                lbl_Message.Text = "Connection Successful";
                pictureBoxForMessage.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are no values in the Booking Database");
            }
            cnn.Close();
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetReserveData();
        }

        private void but_Done_Click(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "" && txt_lName.Text == "")
            {
                lbl_Message.Text = "Please Enter the Name";
            } else if (txt_Contact.Text=="")
            {
                lbl_Message.Text = "Please Enter the Contact Number";
            }
            else
            {
                BusReserveData[4] = txt_firstName.Text + " " + txt_lName.Text;
                BusReserveData[5] = txt_Contact.Text;
                BusReserveData[6] = datePicker1.Text;
                BusReserveData[8] = combo_Gender.Text;
                new PrintWindow(BusReserveData).Show();
            }
            
        }
        private void BookingSeatsData(String buttonName)
        {
            if (buttonName == "seat1")
            {
                seat1.BackColor = Color.Orange;
            }
            if (buttonName == "seat2")
            {
                seat2.BackColor = Color.Orange;
            }
            if (buttonName == "seat3")
            {
                seat3.BackColor = Color.Orange;
            }
            if (buttonName == "seat4")
            {
                seat4.BackColor = Color.Orange;
            }
            if (buttonName == "seat5")
            {
                seat5.BackColor = Color.Orange;
            }
            if (buttonName == "seat6")
            {
                seat6.BackColor = Color.Orange;
            }
            if (buttonName == "seat7")
            {
                seat7.BackColor = Color.Orange;

                if (buttonName == "seat8")
                {
                    seat8.BackColor = Color.Orange;
                }
                if (buttonName == "seat9")
                {
                    seat9.BackColor = Color.Orange;
                }
                if (buttonName == "seat10")
                {
                    seat10.BackColor = Color.Orange;
                }
                if (buttonName == "seat11")
                {
                    seat11.BackColor = Color.Orange;
                }
                if (buttonName == "seat12")
                {
                    seat12.BackColor = Color.Orange;
                }
                if (buttonName == "seat13")
                {
                    seat13.BackColor = Color.Orange;
                }
                if (buttonName == "seat14")
                {
                    seat14.BackColor = Color.Orange;
                }
                if (buttonName == "seat15")
                {
                    seat15.BackColor = Color.Orange;
                }
                if (buttonName == "seat16")
                {
                    seat16.BackColor = Color.Orange;
                }
                if (buttonName == "seat17")
                {
                    seat17.BackColor = Color.Orange;
                }
                if (buttonName == "seat18")
                {
                    seat18.BackColor = Color.Orange;
                }
                if (buttonName == "seat19")
                {
                    seat19.BackColor = Color.Orange;
                }
                if (buttonName == "seat20")
                {
                    seat20.BackColor = Color.Orange;
                }
                if (buttonName == "seat21")
                {
                    seat21.BackColor = Color.Orange;
                }
                if (buttonName == "seat22")
                {
                    seat22.BackColor = Color.Orange;
                }
                if (buttonName == "seat23")
                {
                    seat23.BackColor = Color.Orange;
                }
                if (buttonName == "seat24")
                {
                    seat24.BackColor = Color.Orange;
                }
                if (buttonName == "seat25")
                {
                    seat25.BackColor = Color.Orange;
                }
                if (buttonName == "seat26")
                {
                    seat26.BackColor = Color.Orange;
                }
                if (buttonName == "seat27")
                {
                    seat27.BackColor = Color.Orange;
                }
                if (buttonName == "seat28")
                {
                    seat28.BackColor = Color.Orange;
                }
                if (buttonName == "seat29")
                {
                    seat29.BackColor = Color.Orange;
                }
                if (buttonName == "seat30")
                {
                    seat30.BackColor = Color.Orange;
                }
                if (buttonName == "seat31")
                {
                    seat31.BackColor = Color.Orange;
                }
                if (buttonName == "seat32")
                {
                    seat32.BackColor = Color.Orange;
                }
                if (buttonName == "seat33")
                {
                    seat33.BackColor = Color.Orange;
                }
                if (buttonName == "seat34")
                {
                    seat34.BackColor = Color.Orange;
                }
                if (buttonName == "seat35")
                {
                    seat35.BackColor = Color.Orange;
                }
                if (buttonName == "seat36")
                {
                    seat36.BackColor = Color.Orange;
                }
                if (buttonName == "seat37")
                {
                    seat37.BackColor = Color.Orange;
                }
                if (buttonName == "seat38")
                {
                    seat38.BackColor = Color.Orange;
                }
                if (buttonName == "seat39")
                {
                    seat39.BackColor = Color.Orange;
                }
                if (buttonName == "seat40")
                {
                    seat40.BackColor = Color.Orange;
                }

            }
        }

        private void but_Back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            new Home().Show();
        }
    }
}