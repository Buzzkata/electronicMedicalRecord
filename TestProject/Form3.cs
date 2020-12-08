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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalRecordDBDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.medicalRecordDBDataSet1.Patients);
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet.Patient' table. You can move, or remove it, as needed.
          

        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //add patient record
        {
            Form2 addPatient = new Form2();
            addPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e) //search button
        {
            
                //SqlConnection con = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
               // SqlCommand cmd = new SqlCommand("Select * from Patients", con);
               // DataTable dt = new DataTable();
                //con.Open();
                //SqlDataReader sdr = cmd.ExecuteReader();
                //dt.Load(sdr);
               // con.Close();
                //dataGridView1.DataSource = dt;
            
        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.patientsTableAdapter.Fill(this.medicalRecordDBDataSet1.Patients);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click event in order to delete record.Not used. Instead the delete button is used.
        {

        }
        //sqlc is the sqlconnection instantiated with the connection string
        private void button4_Click(object sender, EventArgs e) //delete button: select a record that you wish to delete and press delete button.
        {
            
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from Patients where Patient_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Record Deleted Successfully.", "Patient Form");
            sqlc.Close();
            this.patientsTableAdapter.Fill(this.medicalRecordDBDataSet1.Patients);
        }
    }
}
