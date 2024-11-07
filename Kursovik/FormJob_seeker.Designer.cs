namespace Kursovik
{
    partial class FormJob_seeker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJob_seeker));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurancesertificateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDprofessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employment_agencyDataSet = new Kursovik.Employment_agencyDataSet();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobseekerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_seekerTableAdapter = new Kursovik.Employment_agencyDataSetTableAdapters.Job_seekerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.professionTableAdapter = new Kursovik.Employment_agencyDataSetTableAdapters.ProfessionTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employment_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.passportdetailsDataGridViewTextBoxColumn,
            this.insurancesertificateDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.applicationdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.iDprofessionDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobseekerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportdetailsDataGridViewTextBoxColumn
            // 
            this.passportdetailsDataGridViewTextBoxColumn.DataPropertyName = "Passport_details";
            this.passportdetailsDataGridViewTextBoxColumn.HeaderText = "Passport_details";
            this.passportdetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportdetailsDataGridViewTextBoxColumn.Name = "passportdetailsDataGridViewTextBoxColumn";
            this.passportdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportdetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // insurancesertificateDataGridViewTextBoxColumn
            // 
            this.insurancesertificateDataGridViewTextBoxColumn.DataPropertyName = "Insurance_sertificate";
            this.insurancesertificateDataGridViewTextBoxColumn.HeaderText = "Insurance_sertificate";
            this.insurancesertificateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insurancesertificateDataGridViewTextBoxColumn.Name = "insurancesertificateDataGridViewTextBoxColumn";
            this.insurancesertificateDataGridViewTextBoxColumn.ReadOnly = true;
            this.insurancesertificateDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            this.experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // applicationdateDataGridViewTextBoxColumn
            // 
            this.applicationdateDataGridViewTextBoxColumn.DataPropertyName = "Application_date";
            this.applicationdateDataGridViewTextBoxColumn.HeaderText = "Application_date";
            this.applicationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.applicationdateDataGridViewTextBoxColumn.Name = "applicationdateDataGridViewTextBoxColumn";
            this.applicationdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDprofessionDataGridViewTextBoxColumn
            // 
            this.iDprofessionDataGridViewTextBoxColumn.DataPropertyName = "ID_profession";
            this.iDprofessionDataGridViewTextBoxColumn.DataSource = this.professionBindingSource;
            this.iDprofessionDataGridViewTextBoxColumn.DisplayMember = "Profession_name";
            this.iDprofessionDataGridViewTextBoxColumn.HeaderText = "ID_profession";
            this.iDprofessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDprofessionDataGridViewTextBoxColumn.Name = "iDprofessionDataGridViewTextBoxColumn";
            this.iDprofessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDprofessionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDprofessionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDprofessionDataGridViewTextBoxColumn.ValueMember = "ID";
            this.iDprofessionDataGridViewTextBoxColumn.Width = 125;
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "Profession";
            this.professionBindingSource.DataSource = this.employment_agencyDataSet;
            // 
            // employment_agencyDataSet
            // 
            this.employment_agencyDataSet.DataSetName = "Employment_agencyDataSet";
            this.employment_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Страховка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Опыт работы";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Application_date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата регистрации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Статус";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID профессии";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Район";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobseekerBindingSource, "ID_profession", true));
            this.comboBox1.DataSource = this.professionBindingSource;
            this.comboBox1.DisplayMember = "Profession_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ID";
            // 
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "FIO", true));
            this.textBox1.Location = new System.Drawing.Point(143, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Phone", true));
            this.textBox2.Location = new System.Drawing.Point(143, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "INN", true));
            this.textBox3.Location = new System.Drawing.Point(143, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 22);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Passport_details", true));
            this.textBox4.Location = new System.Drawing.Point(143, 301);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Insurance_sertificate", true));
            this.textBox5.Location = new System.Drawing.Point(143, 329);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 22);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Experience", true));
            this.textBox6.Location = new System.Drawing.Point(143, 357);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 22);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Status", true));
            this.textBox7.Location = new System.Drawing.Point(143, 413);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(124, 22);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobseekerBindingSource, "Area", true));
            this.textBox8.Location = new System.Drawing.Point(143, 471);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(124, 22);
            this.textBox8.TabIndex = 20;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.jobseekerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 511);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(770, 31);
            this.bindingNavigator1.TabIndex = 21;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(273, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Фильтр по дате";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "Фильтр по району";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 27);
            this.button4.TabIndex = 25;
            this.button4.Text = "Фильтр по статусу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(451, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 27);
            this.button5.TabIndex = 26;
            this.button5.Text = "Фильтр по профессии";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(451, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(242, 27);
            this.button6.TabIndex = 27;
            this.button6.Text = "Сбросить фильтр";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormJob_seeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 542);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormJob_seeker";
            this.Text = "FormJob_seeker";
            this.Load += new System.EventHandler(this.FormJob_seeker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employment_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobseekerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Employment_agencyDataSet employment_agencyDataSet;
        private System.Windows.Forms.BindingSource jobseekerBindingSource;
        private Employment_agencyDataSetTableAdapters.Job_seekerTableAdapter job_seekerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private Employment_agencyDataSetTableAdapters.ProfessionTableAdapter professionTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurancesertificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDprofessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}