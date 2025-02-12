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
    public partial class DaytourHire_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_griffindo;Integrated Security=True");
        int BaseCost,Tot;

        public DaytourHire_Form()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmbPackType.SelectedItem.ToString() == "Airport_drop")
            {
                int B_cost = 1450;
                int A_hours = 11;
                int A_km = 65;
                int CP_exkm = 18;
                int CP_exhours = 60;

                DateTime start_time = dtpStDate.Value;
                DateTime end_time = dtpEdDate.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                txtExtraTime.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(txtStartKM.Text);
                int E_reading = Int32.Parse(txtEndKM.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                txtExtraKM.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                txtBaseCharge.Text = B_cost.ToString();

                Tot = B_cost + EK_cost + ET_cost;

                txtTotal.Text = Tot.ToString();
            }
            else if (cmbPackType.SelectedItem.ToString() == "Airport_Pic")
            {
                int B_cost = 1150;
                int A_hours = 11;
                int A_km = 65;
                int CP_exkm = 18;
                int CP_exhours = 60;

                DateTime start_time = dtpStDate.Value;
                DateTime end_time = dtpEdDate.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                txtExtraTime.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(txtStartKM.Text);
                int E_reading = Int32.Parse(txtEndKM.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                txtExtraKM.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                txtBaseCharge.Text = B_cost.ToString();

                Tot = B_cost + EK_cost + ET_cost;

                txtTotal.Text = Tot.ToString();

            }
            else if (cmbPackType.SelectedItem.ToString() == "100KM")
            {
                int B_cost = 1450;
                int A_hours = 11;
                int A_km = 110;
                int CP_exkm = 20;
                int CP_exhours = 60;

                DateTime start_time = dtpStDate.Value;
                DateTime end_time = dtpEdDate.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                txtExtraTime.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(txtStartKM.Text);
                int E_reading = Int32.Parse(txtEndKM.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                txtExtraKM.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                txtBaseCharge.Text = B_cost.ToString();

                Tot = B_cost + EK_cost + ET_cost;

                txtTotal.Text = Tot.ToString();

            }
            else if (cmbPackType.SelectedItem.ToString() == "200KM")
            {
                int B_cost = 2900;
                int A_hours = 11;
                int A_km = 220;
                int CP_exkm = 20;
                int CP_exhours = 60;

                DateTime start_time = dtpStDate.Value;
                DateTime end_time = dtpEdDate.Value;

                TimeSpan T_Diff = end_time - start_time;

                double T_hours = T_Diff.TotalHours;

                int H_diff = (int)T_hours;

                int ET_cost = 0;

                if (H_diff > A_hours)
                {
                    ET_cost = (H_diff - A_hours) * CP_exhours;
                }

                txtExtraTime.Text = ET_cost.ToString();

                int S_reading = Int32.Parse(txtStartKM.Text);
                int E_reading = Int32.Parse(txtEndKM.Text);

                int K_diff = E_reading - S_reading;
                int EK_cost = (K_diff - A_km) * CP_exkm;

                txtExtraKM.Text = EK_cost.ToString() != "" ? EK_cost.ToString() : "0";

                txtBaseCharge.Text = B_cost.ToString();

                Tot = B_cost + EK_cost + ET_cost;

                txtTotal.Text = Tot.ToString();

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

                string delstr = "DELETE FROM DaytourHire_Calculation WHERE Rec_ID = '" + rec_txt.Text+"'";

                SqlCommand delcmd = new SqlCommand(delstr, con);

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
                string VehNo = txtVehNo.Text;
                string PackType = cmbPackType.Text;
                DateTime StDate = dtpStDate.Value;
                DateTime EdDate = dtpEdDate.Value;
                string StartKM = txtStartKM.Text;
                string EndKM = txtEndKM.Text;
                string BaseCharge = txtBaseCharge.Text;
                string ExtraKM = txtExtraKM.Text;
                string ExtraTime = txtExtraTime.Text;
                string Total = txtTotal.Text;

                con.Open();

                string updstr = "UPDATE DaytourHire_Calculation SET Vehicle_ID = @Vehicle_ID, Pakage_Type  = @Pakage_Type, Start_Time  = @start_day, End_Time =  @end_day, StartKm_Rd = @StartKm_Rd, EndKm_Rd  = @EndKm_Rd, Base_Hire  = @Base_Hire,  ExtraKm_Charge = @ExtraKm_Charge, Waiting_Charge  = @Waiting_Charge, Total = @Total where Rec_ID = '" + rec_txt.Text + "';";

                SqlCommand upcmd = new SqlCommand(updstr, con);

                upcmd.Parameters.AddWithValue("@Vehicle_ID", VehNo);
                upcmd.Parameters.AddWithValue("@Pakage_Type", PackType);
                upcmd.Parameters.AddWithValue("@start_day", StDate);
                upcmd.Parameters.AddWithValue("@end_day", EdDate);
                upcmd.Parameters.AddWithValue("@StartKm_Rd", StartKM);
                upcmd.Parameters.AddWithValue("@EndKm_Rd", EndKM);
                upcmd.Parameters.AddWithValue("@Base_Hire", BaseCharge);
                upcmd.Parameters.AddWithValue("@ExtraKm_Charge", ExtraKM);
                upcmd.Parameters.AddWithValue("@Waiting_Charge", ExtraTime);
                upcmd.Parameters.AddWithValue("@Total", Total);

                int insert = upcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Updated successfully ! :) ");

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
                SqlCommand cmd = new SqlCommand("select * from DaytourHire_Calculation where Rec_ID = '" + rec_txt.Text + "';", con);

                SqlDataReader myR = cmd.ExecuteReader();

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtVehNo.Text = myR["Vehicle_ID"].ToString();
                        cmbPackType.Text = myR["Pakage_Type"].ToString();
                        dtpStDate.Value = DateTime.Parse(myR["Start_Time"].ToString());
                        dtpEdDate.Value = DateTime.Parse(myR["End_Time"].ToString());
                        txtStartKM.Text = myR["StartKm_Rd"].ToString();
                        txtEndKM.Text = myR["EndKm_Rd"].ToString();
                        txtBaseCharge.Text = myR["Base_Hire"].ToString();
                        txtExtraKM.Text = myR["ExtraKm_Charge"].ToString();
                        txtExtraTime.Text = myR["Waiting_Charge"].ToString();
                        txtTotal.Text = myR["Total"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string VehNo = txtVehNo.Text;
                string PackType = cmbPackType.Text;
                DateTime StDate = dtpStDate.Value;
                DateTime EdDate = dtpEdDate.Value;
                string StartKM = txtStartKM.Text;
                string EndKM = txtEndKM.Text;
                string BaseCharge = txtBaseCharge.Text;
                string ExtraKM = txtExtraKM.Text;
                string ExtraTime = txtExtraTime.Text;
                string Total = txtTotal.Text;
                
                con.Open();

                string insstr = "INSERT INTO DaytourHire_Calculation VALUES(@Vehicle_ID,@Pakage_Type,@Start_Time,@End_Time,@StartKm_Rd,@EndKm_Rd,@Base_Hire,@ExtraKm_Charge,@Waiting_Charge,@Total)";

                SqlCommand inscmd = new SqlCommand(insstr, con);

                inscmd.Parameters.AddWithValue("@Vehicle_ID", VehNo);
                inscmd.Parameters.AddWithValue("@Pakage_Type", PackType);
                inscmd.Parameters.AddWithValue("@Start_Time", StDate);
                inscmd.Parameters.AddWithValue("@End_Time", EdDate);
                inscmd.Parameters.AddWithValue("@StartKm_Rd", StartKM);
                inscmd.Parameters.AddWithValue("@EndKm_Rd", EndKM);
                inscmd.Parameters.AddWithValue("@Base_Hire", BaseCharge);
                inscmd.Parameters.AddWithValue("@ExtraKm_Charge", ExtraKM);
                inscmd.Parameters.AddWithValue("@Waiting_Charge", ExtraTime);
                inscmd.Parameters.AddWithValue("@Total", Total);

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
    }
}
