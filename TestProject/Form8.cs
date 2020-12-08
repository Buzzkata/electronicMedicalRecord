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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-IDIB3CN;Initial Catalog=MedicalRecordDB;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e) //schedule a procedure btn
        {
            Form9 schdlProcedure = new Form9();
            schdlProcedure.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalRecordDBDataSet1.Procedures' table. You can move, or remove it, as needed.
            this.proceduresTableAdapter.Fill(this.medicalRecordDBDataSet1.Procedures);

        }

        private void button3_Click(object sender, EventArgs e) //refresh btn
        {
            this.proceduresTableAdapter.Fill(this.medicalRecordDBDataSet1.Procedures);
        }

        private void button4_Click(object sender, EventArgs e) //delete btn
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sqlc.Open();
            SqlCommand cmd = new SqlCommand("delete from Procedures where Procedure_ID = " + int.Parse(val), sqlc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Procedure Record Deleted Successfully.","Procedure Form");
            sqlc.Close();
            this.proceduresTableAdapter.Fill(this.medicalRecordDBDataSet1.Procedures);
        }
    }
}
