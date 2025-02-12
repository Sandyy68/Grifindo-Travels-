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

namespace Griffindo
{
    public partial class LongtourHire_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_griffindo;Integrated Security=True");
        static int Total;

        public LongtourHire_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (packagetype_cmb.SelectedItem.ToString() == "Airport_drop")
            { 
                
                int B_cost = 1450;
                int A_hours = 7;
                int A_km = 100;
                int CP_exkm = 25;
                int CP_exhours = 60;

                DateTime start_time = statrdate_dtp.Value;
                DateTime end_time = enddate_dtp.Value;

                TimeSpan T_diff = end_time - start_time;

                double T_hours = T_diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }
                
                overnightstaycharge_txt.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(startkmreading_txt.Text);
                int E_reading = Int32.Parse(endkmreading_txt.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                extrakmcharge_txt.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                basehirecharge_txt.Text = B_cost.ToString();

                Total = B_cost + EK_cost + ET_cost;

                total_txt.Text = Total.ToString();
            }
            else if (packagetype_cmb.SelectedItem.ToString() == "Airport_pic")
            {
                int B_cost = 1450;
                int A_hours = 7;
                int A_km = 100;
                int CP_exkm = 25;
                int CP_exhours = 70;

                DateTime start_time = statrdate_dtp.Value;
                DateTime end_time = enddate_dtp.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                overnightstaycharge_txt.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(startkmreading_txt.Text);
                int E_reading = Int32.Parse(endkmreading_txt.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                extrakmcharge_txt.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                basehirecharge_txt.Text = B_cost.ToString();

                Total = B_cost + EK_cost + ET_cost;

                total_txt.Text = Total.ToString();

            }
            else if (packagetype_cmb.SelectedItem.ToString() == "100KM")
            {
                int B_cost = 3500;
                int A_hours = 7;
                int A_km = 100;
                int CP_exkm = 35;
                int CP_exhours = 60;

                DateTime start_time = statrdate_dtp.Value;
                DateTime end_time = enddate_dtp.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                overnightstaycharge_txt.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(startkmreading_txt.Text);
                int E_reading = Int32.Parse(endkmreading_txt.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                extrakmcharge_txt.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                basehirecharge_txt.Text = B_cost.ToString();

                Total = B_cost + EK_cost + ET_cost;

                total_txt.Text = Total.ToString();

            }
            else if (packagetype_cmb.SelectedItem.ToString() == "200KM")
            {
                int B_cost = 7000;
                int A_hours = 7;
                int A_km = 200;
                int CP_exkm = 90;
                int CP_exhours = 200;

                DateTime start_time = statrdate_dtp.Value;
                DateTime end_time = enddate_dtp.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                overnightstaycharge_txt.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(startkmreading_txt.Text);
                int E_reading = Int32.Parse(endkmreading_txt.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                extrakmcharge_txt.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                basehirecharge_txt.Text = B_cost.ToString();

                Total = B_cost + EK_cost + ET_cost;

                total_txt.Text = Total.ToString();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicalno = vehicalno_txt.Text;
                string packagetype = packagetype_cmb.Text;
                DateTime statrdate = statrdate_dtp.Value;
                DateTime enddate = enddate_dtp.Value;
                string startkmreading = startkmreading_txt.Text;
                string endkmreading = endkmreading_txt.Text;
                string basehirecharge = basehirecharge_txt.Text;
                string extrakmcharge = extrakmcharge_txt.Text;
                string overnightstaycharge = overnightstaycharge_txt.Text;
                string total = total_txt.Text;

                con.Open();

                string insstr = "INSERT INTO LongtourHire_calculation VALUES(@Vehicle_ID,@Pakage_Type,@Start_Day,@End_Day,@StartKm_Rd,@EndKm_Rd,@Base_Hire,@ExtraKm_Charge,@Overnight_Stay,@Total)";

                SqlCommand inscmd = new SqlCommand(insstr, con);

                inscmd.Parameters.AddWithValue("@Vehicle_ID", vehicalno);
                inscmd.Parameters.AddWithValue("@Pakage_Type", packagetype);
                inscmd.Parameters.AddWithValue("@Start_Day", statrdate);
                inscmd.Parameters.AddWithValue("@End_Day", enddate);
                inscmd.Parameters.AddWithValue("@StartKm_Rd", startkmreading);
                inscmd.Parameters.AddWithValue("@EndKm_Rd", endkmreading);
                inscmd.Parameters.AddWithValue("@Base_Hire", basehirecharge);
                inscmd.Parameters.AddWithValue("@ExtraKm_Charge", extrakmcharge);
                inscmd.Parameters.AddWithValue("@Overnight_Stay", overnightstaycharge);
                inscmd.Parameters.AddWithValue("@Total", total);

                int insert = inscmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Inserted successfully ! :) ");

                }
                else
                {
                    MessageBox.Show("Error : No data was inserted");
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
            Dashboard menu = new Dashboard();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                string deleteString = "DELETE FROM LongtourHire_calculation WHERE Rec_ID = '" + recid_txt.Text+"';";

                SqlCommand delcmd = new SqlCommand(deleteString, con);

                int insert = delcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Deleted successfully ! :) ");

                }
                else
                {
                    MessageBox.Show("Error : No data was deleted");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicalno = vehicalno_txt.Text;
                string packagetype = packagetype_cmb.Text;
                DateTime statrdate = statrdate_dtp.Value;
                DateTime enddate = enddate_dtp.Value;
                string startkmreading = startkmreading_txt.Text;
                string endkmreading = endkmreading_txt.Text;
                string basehirecharge = basehirecharge_txt.Text;
                string extrakmcharge = extrakmcharge_txt.Text;
                string overnightstaycharge = overnightstaycharge_txt.Text;
                string total = total_txt.Text;

                con.Open();

                string updstr = "UPDATE LongtourHire_calculation SET Vehicle_ID = @Vehicle_ID, Pakage_Type  = @Pakage_Type, Start_Day  = @Start_Day, End_Day =  @End_Day, StartKm_Rd = @StartKm_Rd, EndKm_Rd  = @EndKm_Rd, Base_Hire  = @Base_Hire,  ExtraKm_Charge = @ExtraKm_Charge, Overnight_Stay  = @Overnight_Stay, Total = @Total where Rec_ID = '" + recid_txt.Text+"';";

                SqlCommand upcmd = new SqlCommand(updstr, con);

                upcmd.Parameters.AddWithValue("@Vehicle_ID", vehicalno);
                upcmd.Parameters.AddWithValue("@Pakage_Type", packagetype);
                upcmd.Parameters.AddWithValue("@Start_Day", statrdate);
                upcmd.Parameters.AddWithValue("@End_Day", enddate);
                upcmd.Parameters.AddWithValue("@StartKm_Rd", startkmreading);
                upcmd.Parameters.AddWithValue("@EndKm_Rd", endkmreading);
                upcmd.Parameters.AddWithValue("@Base_Hire", basehirecharge);
                upcmd.Parameters.AddWithValue("@ExtraKm_Charge", extrakmcharge);
                upcmd.Parameters.AddWithValue("@Overnight_Stay", overnightstaycharge);
                upcmd.Parameters.AddWithValue("@Total", total);

                int insert = upcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was updated successfully ! :) ");

                }
                else
                {
                    MessageBox.Show("Error : No data was updated");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from LongtourHire_calculation where Rec_ID = '" + recid_txt.Text+"';",con);

                SqlDataReader myR = cmd.ExecuteReader();

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        vehicalno_txt.Text = myR["Vehicle_ID"].ToString();
                        packagetype_cmb.Text = myR["Pakage_Type"].ToString();
                        statrdate_dtp.Value = DateTime.Parse(myR["Start_Day"].ToString());
                        enddate_dtp.Value = DateTime.Parse(myR["End_Day"].ToString());
                        startkmreading_txt.Text = myR["StartKm_Rd"].ToString();
                        endkmreading_txt.Text = myR["EndKm_Rd"].ToString();
                        basehirecharge_txt.Text = myR["Base_Hire"].ToString();
                        extrakmcharge_txt.Text = myR["ExtraKm_Charge"].ToString();
                        overnightstaycharge_txt.Text = myR["Overnight_Stay"].ToString();
                        total_txt.Text = myR["Total"].ToString();
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

        private void packagetype_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
