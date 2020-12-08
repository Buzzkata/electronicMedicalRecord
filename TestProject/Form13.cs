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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e) //add a lab test result
        {
            sqlc.Open();
            SqlCommand cmd = sqlc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into LabTestResults values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            sqlc.Close();
            MessageBox.Show("Lab Test Result Record Inserted Succesfully.","Lab Test Result Form");
        }
    }
}
