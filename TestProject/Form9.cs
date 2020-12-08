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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e) //schedule a procedure (add)
        {
            sqlc.Open();
            SqlCommand cmd = sqlc.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Procedures values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            sqlc.Close();
            MessageBox.Show("Procedure Record Inserted Succesfully.","Procedure Form");
        }
    }
}
