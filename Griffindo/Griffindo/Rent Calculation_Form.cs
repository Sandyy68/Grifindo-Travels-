using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Griffindo
{

    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_griffindo;Integrated Security=True");
        static Int32 Month, driver ,Weeks, days , Total_months , Total_weeks , Total_days;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string record_ID = recordID_txt.Text;
               
                con.Open();

                string delstr = "DELETE FROM Rent_calculation WHERE Rec_ID = @record_ID";

                SqlCommand delcmd = new SqlCommand(delstr, con);

                delcmd.Parameters.AddWithValue("@record_ID", record_ID);

                int insert = delcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Successfully Deleted");

                }
                else
                {
                    MessageBox.Show("Error : Unsuccessfully Delete");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard menu = new  Dashboard();
            menu.Show();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (driver_Yes_radiobtt.Checked)
            {
                driverCost_txt.Enabled = true;
            }
            else
            {
                driverCost_txt.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Rent_calculation where  Rec_ID = '" + recordID_txt.Text + "';", con);

                SqlDataReader myRecords = cmd.ExecuteReader();

                if (myRecords.HasRows)
                {
                    while (myRecords.Read())
                    {
                        license_txt.Text = myRecords["Driver_License"].ToString();
                        type_combobox.Text = myRecords["Vehical_Type"].ToString();
                        rented_Day_datetimepicek.Value = DateTime.Parse(myRecords["Rent_day"].ToString());
                        return_Day_datetimepicker.Value = DateTime.Parse(myRecords["Return_day"].ToString());
                        total_txt.Text = myRecords["Total_rent"].ToString();
                        if (myRecords["Driver"].ToString() == "Yes")
                        {
                            driver_Yes_radiobtt.Checked = true;
                        }
                        else
                        {
                            driver_No_radiobtt.Checked = true;
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("No Record with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string record_ID = recordID_txt.Text;
                string License = license_txt.Text;
                string Type = type_combobox.SelectedItem.ToString();
                string Driver;
                if (driver_No_radiobtt.Checked)
                {

                    Driver = "No";
                }
                else
                {
                    Driver = "Yes";

                }
                DateTime rented_Day = rented_Day_datetimepicek.Value;
                DateTime return_Day = return_Day_datetimepicker.Value;
                string Total = total_txt.Text.ToString();

                con.Open();

                string updstr = "Update Rent_calculation SET Driver_License = @License, Vehical_Type = @Type, Driver = @Driver, Rent_day = @rented_Day,Return_day = @return_Day, Total_rent = @Total WHERE Rec_ID = @record_ID";

                SqlCommand updcmd = new SqlCommand(updstr, con);

                updcmd.Parameters.AddWithValue("@record_ID", record_ID);
                updcmd.Parameters.AddWithValue("@License", License);
                updcmd.Parameters.AddWithValue("@Type", Type);
                updcmd.Parameters.AddWithValue("@Driver", Driver);
                updcmd.Parameters.AddWithValue("@rented_Day", rented_Day);
                updcmd.Parameters.AddWithValue("@return_Day", return_Day);
                updcmd.Parameters.AddWithValue("@Total", Total);

                int insert = updcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Successfully updated");

                }
                else
                {
                    MessageBox.Show("Error : Unsuccessfully updated");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string recordID = recordID_txt.Text;
                string License = license_txt.Text;
                string Type = type_combobox.SelectedItem.ToString();
                string Driver;
                if (driver_No_radiobtt.Checked)
                {

                    Driver = "No";
                }
                else
                {
                    Driver = "Yes";

                }
                DateTime rented_Day = rented_Day_datetimepicek.Value;
                DateTime return_Day = return_Day_datetimepicker.Value;
                string Total = total_txt.Text.ToString();

                con.Open();

                string insstr = "INSERT INTO Rent_calculation (Driver_License, Vehical_Type, Driver, Rent_day, Return_day, Total_rent) VALUES(@License,@Type,@Driver,@rented_Day,@return_Day,@Total)";



                SqlCommand inscmd = new SqlCommand(insstr, con);

                inscmd.Parameters.AddWithValue("@License", License);
                inscmd.Parameters.AddWithValue("@Type", Type);
                inscmd.Parameters.AddWithValue("@Driver", Driver);
                inscmd.Parameters.AddWithValue("@rented_Day", rented_Day);
                inscmd.Parameters.AddWithValue("@return_Day", return_Day);
                inscmd.Parameters.AddWithValue("@Total", Total);

                int insert = inscmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Added successfully ");
                  
                }
                else
                {
                    MessageBox.Show("Error : No data was added");
                }
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (driver_No_radiobtt.Checked)
            {
                driverCost_txt.Enabled = false;
            }
            else {
                driverCost_txt.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
            int daily_C = Int32.Parse(daily_txt.Text);
            int weekly_C = Int32.Parse(weekly_txt.Text);
            int monthly_C = Int32.Parse(monthly_txt.Text);
            int driver_C = Int32.Parse(driverCost_txt.Text);

            DateTime rent_D = rented_Day_datetimepicek.Value;
            DateTime retturn_D = return_Day_datetimepicker.Value;
            TimeSpan change_D = retturn_D - rent_D;
            string diff_str = change_D.ToString("dd");
            int difference = Int32.Parse(diff_str);

            if (difference > 30) 
            {
                int Months = difference / 30;
                int remaining_D = difference - (Months * 30);
                Total_days = remaining_D * daily_C;
                Total_months = Months * monthly_C;
            }
            
            if (difference > 7)
            {
                int Weeks = difference / 7;
                int remaining_D = difference - (Weeks * 7);
                Total_days = remaining_D * daily_C;
                Total_weeks = Weeks * weekly_C;
            }

            if (difference < 7 ) { 
                 days = difference;
                 Total_days = days * daily_C;
                 
            }
            driver = driver_C * difference;


            int rent_Total = Total_months + Total_days + Total_weeks + driver;
            total_txt.Text = rent_Total.ToString();

        }
    }
}
