using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class DashboardForm : Form
    {
        string connectionString = @"Data Source=(LocalDb)\LoginProject;Initial Catalog=ProLogin;Integrated Security=True";
        string userID;
        
          
        public DashboardForm(string userID)
        {
            this.userID = userID; 
            InitializeComponent();
        }


        //Booking Method
        #region
        public void BookingMethod()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //if (dateTimePickerPD.Text == "" || dateTimePickerPT.Text == "" || dateTimePickerRD.Text == "" || dateTimePickerRT.Text == "" || comboBoxVS.Text == "" || textBoxPL.Text == "")

                //    MessageBox.Show("Please fill Mandatory fields");

                //else
                //{

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("addBooking", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@PickupDate", dateTimePickerPD.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PickupTime", dateTimePickerPT.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ReturnDate", dateTimePickerRD.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ReturnTime", dateTimePickerRT.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@VehicleName", comboBoxVS.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PickupLocation", textBoxPL.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@UserID", int.Parse(userID));

                sqlCmd.ExecuteNonQuery();
        

                MessageBox.Show("Booking Complete");

                ClearBookingEntry();

                //    }

            }
        }

        private void BtnSubmitBooking_Click(object sender, EventArgs e)
        {
            BookingMethod();

        }
        void ClearBookingEntry()
        {
            dateTimePickerPD.Text = "";
            dateTimePickerPT.Text = "";
            dateTimePickerRD.Text = "";
            dateTimePickerRT.Text = "";
            comboBoxVS.Text = "";
            textBoxPL.Text = "";

        }

        #endregion

        //DataTime Picker and MouseDown Code
        #region
        private void DateTimePickerPickUpTime_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePickerPT.CustomFormat = "HH:mm";
        }

        private void DateTimePickerReturnTim_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePickerRT.CustomFormat = "HH:mm";
        }

        //ComboBox Vehicle Select, set box instruction to first Value in Box opri
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            comboBoxVS.SelectedIndex = 0;
        }

        private void DateTimePickerPickUpTime_DropDown(object sender, EventArgs e)
        {

        }


        private int slideImageNumber = 1;

        private void LoadNextImage()
        {
            if (slideImageNumber == 15)
            {
                slideImageNumber = 1;

            }

            pictureBoxSlideShowLeft.ImageLocation = string.Format(@"Images\{0}.jpg", slideImageNumber);
            slideImageNumber++;
        }

        private void TimerLeftPicBox_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            DashboardForm df = new DashboardForm("userID");
            this.Hide();
            df.Show();
        }

        private void BtnVehicles_Click(object sender, EventArgs e)

        {
            Vehicles vh = new Vehicles();
            this.Hide();
            vh.Show();
        }

        private void DateTimePickerPD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerRD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerRT_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePickerRT.CustomFormat = "HH:mm";
        }

        #endregion
        //Buttons on Dashboard form Left
        #region
        private void BtnBookings_Click(object sender, EventArgs e)
        {
            Reservations rs = new Reservations();
            this.Hide();
            rs.Show();
        }
        #endregion
    }
}
