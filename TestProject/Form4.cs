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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True"); //connection string
        private void button2_Click(object sender, EventArgs e) //add staff record
        {
            Form5 addStaff = new Form5();
            addStaff.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.medicalRecordDBDataSet1.Staff);

        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.staffTableAdapter.Fill(this.medicalRecordDBDataSet1.Staff);
        }

        private void button4_Click(object sender, EventArgs e) //delete btn
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from Staff where Staff_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff Record Deleted Successfully.", "Staff Form");
            sqlc.Close();
            this.staffTableAdapter.Fill(this.medicalRecordDBDataSet1.Staff);
        }
    }
}
