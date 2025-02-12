using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rent
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //day hire
            DaytourHire_Form f = new DaytourHire_Form();
            f.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //long hire
            LongtourHire_Form f = new LongtourHire_Form();
            f.Show();
            Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //sales search
            Form6 f = new Form6();
            f.Show();
            Hide();

        }
    }
}
