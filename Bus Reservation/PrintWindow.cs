using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation
{
    public partial class PrintWindow : Form
    {
        public PrintWindow()
        {
            InitializeComponent();
        }
        public PrintWindow(String[] BusReserveData)
        {
            InitializeComponent();
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
            lbl_BusNameData.Text = BusReserveData[0];
            lbl_ToData.Text = BusReserveData[1];
            lbl_FromData.Text= BusReserveData[2];    
            lbl_AmountData.Text= BusReserveData[3] +" /=";
            lbl_NameData.Text = BusReserveData[4];
            lbl_ContactData.Text= BusReserveData[5];
            lbl_DateData.Text= BusReserveData[6];
            lbl_Time_Data.Text= BusReserveData[7];
            lbl_GenderData.Text= BusReserveData[8];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
