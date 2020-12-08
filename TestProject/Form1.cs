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

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //disables the buttons until the user authenticates themselves
   
       
        private void button1_Click(object sender, EventArgs e) //login button
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                textBox1.Clear();
                textBox2.Clear();
            }
            else {
                MessageBox.Show("Please enter the correct login credentials.", "Electronic Medical Record");
            }
        }

      

        private void button7_Click(object sender, EventArgs e) //patient btn
        {
            Form3 Patient = new Form3();
            Patient.Show();
        }

        private void button3_Click(object sender, EventArgs e) //exit button
        {
            
            DialogResult exitBtn = MessageBox.Show("Are you sure you want to exit the application?", "Electronic Medical Record System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitBtn == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e) //staff btn
        {
            Form4 Staff = new Form4();
            Staff.Show();
        }

        private void button6_Click(object sender, EventArgs e) //prescriptions btn
        {
            Form6 Prescription = new Form6();
            Prescription.Show();
        }

        private void button5_Click(object sender, EventArgs e) //procedures btn
        {
            Form8 Procedure = new Form8();
            Procedure.Show();
        }

        private void button4_Click(object sender, EventArgs e) //lab tests btn
        {
            Form10 LabTest = new Form10();
            LabTest.Show();
        }
     

        private void button2_Click(object sender, EventArgs e) //clear btn
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e) //withhold the forms until the user has authenticated themselves
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            //getPatientRecord();
        }
     
    }
}
