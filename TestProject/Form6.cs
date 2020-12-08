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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e) //add prescription btn
        {
            Form7 addPrescription = new Form7();
            addPrescription.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.Prescriptions' table. You can move, or remove it, as needed.
            this.prescriptionsTableAdapter.Fill(this.medicalRecordDBDataSet1.Prescriptions);

        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.prescriptionsTableAdapter.Fill(this.medicalRecordDBDataSet1.Prescriptions);
        }

        private void button4_Click(object sender, EventArgs e) //delete btn
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from Prescriptions where Prescription_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Procedure Record Deleted Successfully.", "Procedure Form");
            sqlc.Close();
            this.prescriptionsTableAdapter.Fill(this.medicalRecordDBDataSet1.Prescriptions);
        }
    }
}
