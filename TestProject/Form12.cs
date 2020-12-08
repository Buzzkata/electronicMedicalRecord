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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e) //add a lab test result
        {
            Form13 addLabTestResult = new Form13();
            addLabTestResult.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.LabTestResults' table. You can move, or remove it, as needed.
            this.labTestResultsTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTestResults);

        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.labTestResultsTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTestResults);
        }

        private void button4_Click(object sender, EventArgs e) //delete btn
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from LabTestResults where LabTestResult_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lab Test Result Record Deleted Successfully.", "Lab Test Result Form");
            sqlc.Close();
            this.labTestResultsTableAdapter.Fill(this.medicalRecordDBDataSet1.LabTestResults);
        }
    }
}
