namespace Kursovik
{
    partial class FormProcedure
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employment_agencyDataSet = new Kursovik.Employment_agencyDataSet();
            this.jobseekerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_seekerTableAdapter = new Kursovik.Employment_agencyDataSetTableAdapters.Job_seekerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sqlConnection3 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.sqlConnection4 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employment_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-7LBBD47;Initial Catalog=Employment_agency;Integrated Security" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "GetJobSeekersByAreaAndProfession";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.NVarChar, 100),
            new System.Data.SqlClient.SqlParameter("@ProfessionName", System.Data.SqlDbType.NVarChar, 100)});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(273, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Район";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Профессия";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 120);
            this.dataGridView1.TabIndex = 5;
            // 
            // employment_agencyDataSet
            // 
            this.employment_agencyDataSet.DataSetName = "Employment_agencyDataSet";
            this.employment_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobseekerBindingSource
            // 
            this.jobseekerBindingSource.DataMember = "Job_seeker";
            this.jobseekerBindingSource.DataSource = this.employment_agencyDataSet;
            // 
            // job_seekerTableAdapter
            // 
            this.job_seekerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(604, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(572, 120);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(604, 362);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(572, 120);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 362);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(586, 120);
            this.dataGridView4.TabIndex = 8;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=DESKTOP-7LBBD47;Initial Catalog=Employment_agency;Integrated Security" +
    "=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "GetEmployedDuringPeriod";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConnection2;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@ProfessionName", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@EmployerName", System.Data.SqlDbType.NVarChar, 50)});
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(822, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(822, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(822, 239);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(822, 268);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 22);
            this.textBox6.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(992, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите дату начала периода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите дату конца периода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Профессия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Фирма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(113, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cписок безработных, состоящих на учете для";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(690, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Список трудоустроенных за отчетный период";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(113, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Информация о предприятиях, наиболее часто ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(690, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Список доступных вакансий за отчетный период";
            // 
            // sqlConnection3
            // 
            this.sqlConnection3.ConnectionString = "Data Source=DESKTOP-7LBBD47;Initial Catalog=Employment_agency;Integrated Security" +
    "=True";
            this.sqlConnection3.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "GetCompaniesWithMostVacancies";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConnection3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sqlConnection4
            // 
            this.sqlConnection4.ConnectionString = "Data Source=DESKTOP-7LBBD47;Initial Catalog=Employment_agency;Integrated Security" +
    "=True";
            this.sqlConnection4.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "GetAvailableVacanciesByPeriodAndSpecialty";
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.sqlConnection4;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StartDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@EndDate", System.Data.SqlDbType.NVarChar),
            new System.Data.SqlClient.SqlParameter("@SpecialtyName", System.Data.SqlDbType.NVarChar, 50)});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Введите дату начала периода";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Введите дату конца периода";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(735, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Профессия";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(992, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 33);
            this.button4.TabIndex = 26;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(822, 488);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(164, 22);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(822, 517);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(164, 22);
            this.textBox8.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(822, 545);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(164, 22);
            this.textBox9.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(154, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "пользующихся услугами агентства";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(750, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(267, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "по определенной специальности";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(136, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(317, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "данного района и заданной профессии";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(731, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(272, 18);
            this.label17.TabIndex = 33;
            this.label17.Text = "с указанием профессии и фирмы";
            // 
            // FormProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 590);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormProcedure";
            this.Text = "FormProcedure";
            this.Load += new System.EventHandler(this.FormProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employment_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Employment_agencyDataSet employment_agencyDataSet;
        private System.Windows.Forms.BindingSource jobseekerBindingSource;
        private Employment_agencyDataSetTableAdapters.Job_seekerTableAdapter job_seekerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Data.SqlClient.SqlConnection sqlConnection3;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button button3;
        private System.Data.SqlClient.SqlConnection sqlConnection4;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}