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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e) //add a lab test btn
        {
            Form11 addLabTest = new Form11();
            addLabTest.Show();
        }

        private void button5_Click(object sender, EventArgs e) //view lab test results
        {
            Form12 LabTestResults = new Form12();
            LabTestResults.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.LabTest' table. You can move, or remove it, as needed.
            this.labTestTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTest);

        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.labTestTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTest);
        }

        private void button4_Click(object sender, EventArgs e) //delete btn
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from LabTest where Lab_Test_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lab Test Record Deleted Successfully.", "Lab Test Form");
            sqlc.Close();
            this.labTestTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTest);
        }
    }
}
