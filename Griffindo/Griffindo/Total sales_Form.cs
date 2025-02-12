using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindo
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=Shakalya_griffindo;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            showTable("select Rec_ID , Driver_License , Vehical_Type , Driver , Rent_day , Return_day , Total_rent from Rent_calculation", dataGridView1);
            showTable("select Rec_ID , Vehicle_ID , Pakage_Type , Start_Day, End_Day, StartKm_Rd , EndKm_Rd , Base_Hire , ExtraKm_Charge , Overnight_Stay , Total from LongtourHire_calculation", dataGridView3);
            showTable("select Rec_ID , Vehicle_ID , Pakage_Type , Start_Time, End_Time, StartKm_Rd , EndKm_Rd , Base_Hire , ExtraKm_Charge , Waiting_Charge , Total from DaytourHire_Calculation", dataGridView2);

        }

        private void showTable(string qry, DataGridView dgv)
        {
            SqlDataAdapter adapt = new SqlDataAdapter(qry, con);

            DataSet ds = new DataSet();

            adapt.Fill(ds);

            object dv = ds.Tables[0];

            dgv.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard menu = new Dashboard();
            menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Rent = chkRent.Checked;
            bool DHire = chkDHire.Checked;
            bool LHire = chkLHire.Checked;

            DateTime Start = dtpStart.Value;
            DateTime End = dtpEnd.Value;

            if (Rent && DHire && LHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM (SELECT SUM(Total) AS Total FROM DaytourHire_Calculation WHERE Start_Time >= '" + Start + "' AND End_Time <= '" + End + "' UNION ALL SELECT SUM(Total) AS Total FROM LongtourHire_calculation WHERE Start_Day >= '" + Start + "' AND End_Day <= '" + End + "' UNION ALL SELECT SUM(Total_rent) AS Total FROM Rent_calculation WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "') AS subquery;", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Time , End_Time , Total from DaytourHire_Calculation Union All select Rec_ID , Start_Day , End_Day , Total from LongtourHire_calculation Union All select Rec_ID , Rent_day , Return_day , Total_rent from Rent_calculation", dgvSales);
            }
            else if (Rent && DHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM DaytourHire_Calculation WHERE Start_Time >= '" + Start + "' AND End_Time <= '" + End + "'  UNION ALL  SELECT SUM(Total_rent) AS Total FROM Rent_calculation WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "' ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Time , End_Time , Total from DaytourHire_Calculation Union All select Rec_ID , Rent_day , Return_day , Total_rent from Rent_calculation", dgvSales);
            }
            else if (Rent && LHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM LongtourHire_calculation WHERE Start_Day >= '" + Start + "' AND End_Day <= '" + End + "'  UNION ALL  SELECT SUM(Total_rent) AS Total FROM Rent_calculation WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "' ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Time , End_Time , Total from DaytourHire_Calculation Union All select Rec_ID , Rent_day , Return_day , Total_rent from Rent_calculation", dgvSales);
            }
            else if (Rent)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total_rent) AS Total_Sum FROM Rent_calculation WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "'", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Rent_day , Return_day , Total_rent from Rent_calculation", dgvSales);
            }
            else if (DHire && LHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM DaytourHire_Calculation WHERE Start_Time >= '" + Start + "' AND End_Time <= '" + End + "'  UNION ALL  SELECT SUM(Total) AS Total FROM LongtourHire_calculation WHERE Start_Day >= '" + Start + "' AND End_Day <= '" + End + "'  ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Time , End_Time , Total from DaytourHire_Calculation Union All select Rec_ID , Start_Day , End_Day , Total from LongtourHire_calculation", dgvSales);
            }
            else if (DHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM DaytourHire_Calculation WHERE Start_Time >= '" + Start + "' AND End_Time <= '" + End + "' ", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Time , End_Time , Total from DaytourHire_Calculation", dgvSales);
            }
            else if (LHire)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM LongtourHire_calculation WHERE Start_Day >= '" + Start + "' AND End_Day <= '" + End + "'", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Rec_ID , Start_Day , End_Day , Total from LongtourHire_calculation", dgvSales);
            }
            else
            {
                MessageBox.Show("Please select a service!");
            }
        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
