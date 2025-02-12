
namespace Griffindo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recordID_txt = new System.Windows.Forms.TextBox();
            this.license_txt = new System.Windows.Forms.TextBox();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.driver_No_radiobtt = new System.Windows.Forms.RadioButton();
            this.driver_Yes_radiobtt = new System.Windows.Forms.RadioButton();
            this.rented_Day_datetimepicek = new System.Windows.Forms.DateTimePicker();
            this.return_Day_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.daily_txt = new System.Windows.Forms.TextBox();
            this.weekly_txt = new System.Windows.Forms.TextBox();
            this.monthly_txt = new System.Windows.Forms.TextBox();
            this.driverCost_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordID_txt
            // 
            this.recordID_txt.Location = new System.Drawing.Point(209, 98);
            this.recordID_txt.Name = "recordID_txt";
            this.recordID_txt.Size = new System.Drawing.Size(338, 26);
            this.recordID_txt.TabIndex = 0;
            // 
            // license_txt
            // 
            this.license_txt.Location = new System.Drawing.Point(209, 161);
            this.license_txt.Name = "license_txt";
            this.license_txt.Size = new System.Drawing.Size(338, 26);
            this.license_txt.TabIndex = 1;
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Items.AddRange(new object[] {
            "Small car",
            "Sedan car",
            "SUV",
            "Jeep (WD)",
            "7SeatVan",
            " ComVan"});
            this.type_combobox.Location = new System.Drawing.Point(733, 98);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(338, 28);
            this.type_combobox.TabIndex = 2;
            // 
            // driver_No_radiobtt
            // 
            this.driver_No_radiobtt.AutoSize = true;
            this.driver_No_radiobtt.Checked = true;
            this.driver_No_radiobtt.Location = new System.Drawing.Point(816, 166);
            this.driver_No_radiobtt.Name = "driver_No_radiobtt";
            this.driver_No_radiobtt.Size = new System.Drawing.Size(54, 24);
            this.driver_No_radiobtt.TabIndex = 3;
            this.driver_No_radiobtt.TabStop = true;
            this.driver_No_radiobtt.Text = "No";
            this.driver_No_radiobtt.UseVisualStyleBackColor = true;
            this.driver_No_radiobtt.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // driver_Yes_radiobtt
            // 
            this.driver_Yes_radiobtt.AutoSize = true;
            this.driver_Yes_radiobtt.Location = new System.Drawing.Point(954, 166);
            this.driver_Yes_radiobtt.Name = "driver_Yes_radiobtt";
            this.driver_Yes_radiobtt.Size = new System.Drawing.Size(62, 24);
            this.driver_Yes_radiobtt.TabIndex = 4;
            this.driver_Yes_radiobtt.Text = "Yes";
            this.driver_Yes_radiobtt.UseVisualStyleBackColor = true;
            this.driver_Yes_radiobtt.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rented_Day_datetimepicek
            // 
            this.rented_Day_datetimepicek.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.rented_Day_datetimepicek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rented_Day_datetimepicek.Location = new System.Drawing.Point(209, 224);
            this.rented_Day_datetimepicek.Name = "rented_Day_datetimepicek";
            this.rented_Day_datetimepicek.Size = new System.Drawing.Size(338, 26);
            this.rented_Day_datetimepicek.TabIndex = 5;
            // 
            // return_Day_datetimepicker
            // 
            this.return_Day_datetimepicker.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.return_Day_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.return_Day_datetimepicker.Location = new System.Drawing.Point(733, 222);
            this.return_Day_datetimepicker.Name = "return_Day_datetimepicker";
            this.return_Day_datetimepicker.Size = new System.Drawing.Size(338, 26);
            this.return_Day_datetimepicker.TabIndex = 6;
            // 
            // daily_txt
            // 
            this.daily_txt.Location = new System.Drawing.Point(153, 32);
            this.daily_txt.Name = "daily_txt";
            this.daily_txt.Size = new System.Drawing.Size(176, 26);
            this.daily_txt.TabIndex = 7;
            this.daily_txt.Text = "0";
            // 
            // weekly_txt
            // 
            this.weekly_txt.Location = new System.Drawing.Point(153, 89);
            this.weekly_txt.Name = "weekly_txt";
            this.weekly_txt.Size = new System.Drawing.Size(176, 26);
            this.weekly_txt.TabIndex = 8;
            this.weekly_txt.Text = "0";
            // 
            // monthly_txt
            // 
            this.monthly_txt.Location = new System.Drawing.Point(153, 146);
            this.monthly_txt.Name = "monthly_txt";
            this.monthly_txt.Size = new System.Drawing.Size(176, 26);
            this.monthly_txt.TabIndex = 9;
            this.monthly_txt.Text = "0";
            // 
            // driverCost_txt
            // 
            this.driverCost_txt.Enabled = false;
            this.driverCost_txt.Location = new System.Drawing.Point(153, 203);
            this.driverCost_txt.Name = "driverCost_txt";
            this.driverCost_txt.Size = new System.Drawing.Size(176, 26);
            this.driverCost_txt.TabIndex = 10;
            this.driverCost_txt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Daily";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weekly ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monthly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Driver cost (Daily)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Record_ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "License :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Types :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(641, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Driver :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rented_Day :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Return day :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(153, 289);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(176, 26);
            this.total_txt.TabIndex = 25;
            this.total_txt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 34);
            this.button5.TabIndex = 27;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 35);
            this.button6.TabIndex = 28;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.driverCost_txt);
            this.groupBox1.Controls.Add(this.monthly_txt);
            this.groupBox1.Controls.Add(this.weekly_txt);
            this.groupBox1.Controls.Add(this.daily_txt);
            this.groupBox1.Location = new System.Drawing.Point(713, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 330);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1204, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.return_Day_datetimepicker);
            this.Controls.Add(this.rented_Day_datetimepicek);
            this.Controls.Add(this.driver_Yes_radiobtt);
            this.Controls.Add(this.driver_No_radiobtt);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.license_txt);
            this.Controls.Add(this.recordID_txt);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Calculation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recordID_txt;
        private System.Windows.Forms.TextBox license_txt;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.RadioButton driver_No_radiobtt;
        private System.Windows.Forms.RadioButton driver_Yes_radiobtt;
        private System.Windows.Forms.DateTimePicker rented_Day_datetimepicek;
        private System.Windows.Forms.DateTimePicker return_Day_datetimepicker;
        private System.Windows.Forms.TextBox daily_txt;
        private System.Windows.Forms.TextBox weekly_txt;
        private System.Windows.Forms.TextBox monthly_txt;
        private System.Windows.Forms.TextBox driverCost_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}