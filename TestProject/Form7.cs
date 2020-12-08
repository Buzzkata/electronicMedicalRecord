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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e) //add prescription record
        {
            sqlc.Open();
            SqlCommand cmd = sqlc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Prescriptions values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text +  "')";
            cmd.ExecuteNonQuery();
            sqlc.Close();
            MessageBox.Show("Prescription Record Inserted Succesfully.", "Prescription Form");
        }
    }
}
