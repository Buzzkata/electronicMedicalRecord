
namespace TestProject
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicalRecordDBDataSet1 = new TestProject.MedicalRecordDBDataSet1();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestTableAdapter = new TestProject.MedicalRecordDBDataSet1TableAdapters.LabTestTableAdapter();
            this.tableAdapterManager = new TestProject.MedicalRecordDBDataSet1TableAdapters.TableAdapterManager();
            this.labTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestPatientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestStaffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Lab Tests:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 343);
            this.panel1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add a Lab Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(490, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 31);
            this.button5.TabIndex = 19;
            this.button5.Text = "View Lab Test Results";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labTestIDDataGridViewTextBoxColumn,
            this.labTestPatientIDDataGridViewTextBoxColumn,
            this.labTestStaffIDDataGridViewTextBoxColumn,
            this.labTestTypeDataGridViewTextBoxColumn,
            this.labTestInfoDataGridViewTextBoxColumn,
            this.labTestDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.labTestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // medicalRecordDBDataSet1
            // 
            this.medicalRecordDBDataSet1.DataSetName = "MedicalRecordDBDataSet1";
            this.medicalRecordDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataMember = "LabTest";
            this.labTestBindingSource.DataSource = this.medicalRecordDBDataSet1;
            // 
            // labTestTableAdapter
            // 
            this.labTestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LabTestResultsTableAdapter = null;
            this.tableAdapterManager.LabTestTableAdapter = this.labTestTableAdapter;
            this.tableAdapterManager.LoginInfoTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PrescriptionsTableAdapter = null;
            this.tableAdapterManager.ProceduresTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestProject.MedicalRecordDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // labTestIDDataGridViewTextBoxColumn
            // 
            this.labTestIDDataGridViewTextBoxColumn.DataPropertyName = "Lab_Test_ID";
            this.labTestIDDataGridViewTextBoxColumn.HeaderText = "Lab_Test_ID";
            this.labTestIDDataGridViewTextBoxColumn.Name = "labTestIDDataGridViewTextBoxColumn";
            this.labTestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labTestPatientIDDataGridViewTextBoxColumn
            // 
            this.labTestPatientIDDataGridViewTextBoxColumn.DataPropertyName = "LabTest_Patient_ID";
            this.labTestPatientIDDataGridViewTextBoxColumn.HeaderText = "LabTest_Patient_ID";
            this.labTestPatientIDDataGridViewTextBoxColumn.Name = "labTestPatientIDDataGridViewTextBoxColumn";
            // 
            // labTestStaffIDDataGridViewTextBoxColumn
            // 
            this.labTestStaffIDDataGridViewTextBoxColumn.DataPropertyName = "LabTest_Staff_ID";
            this.labTestStaffIDDataGridViewTextBoxColumn.HeaderText = "LabTest_Staff_ID";
            this.labTestStaffIDDataGridViewTextBoxColumn.Name = "labTestStaffIDDataGridViewTextBoxColumn";
            // 
            // labTestTypeDataGridViewTextBoxColumn
            // 
            this.labTestTypeDataGridViewTextBoxColumn.DataPropertyName = "LabTest_Type";
            this.labTestTypeDataGridViewTextBoxColumn.HeaderText = "LabTest_Type";
            this.labTestTypeDataGridViewTextBoxColumn.Name = "labTestTypeDataGridViewTextBoxColumn";
            // 
            // labTestInfoDataGridViewTextBoxColumn
            // 
            this.labTestInfoDataGridViewTextBoxColumn.DataPropertyName = "LabTest_Info";
            this.labTestInfoDataGridViewTextBoxColumn.HeaderText = "LabTest_Info";
            this.labTestInfoDataGridViewTextBoxColumn.Name = "labTestInfoDataGridViewTextBoxColumn";
            // 
            // labTestDateDataGridViewTextBoxColumn
            // 
            this.labTestDateDataGridViewTextBoxColumn.DataPropertyName = "LabTest_Date";
            this.labTestDateDataGridViewTextBoxColumn.HeaderText = "LabTest_Date";
            this.labTestDateDataGridViewTextBoxColumn.Name = "labTestDateDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Lab Tests Main Form";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalRecordDBDataSet1 medicalRecordDBDataSet1;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private MedicalRecordDBDataSet1TableAdapters.LabTestTableAdapter labTestTableAdapter;
        private MedicalRecordDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestPatientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestStaffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestDateDataGridViewTextBoxColumn;
    }
}