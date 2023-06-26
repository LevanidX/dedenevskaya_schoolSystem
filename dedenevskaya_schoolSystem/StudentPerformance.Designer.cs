namespace dedenevskaya_schoolSystem
{
    partial class StudentPerformance
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
            System.Windows.Forms.Label performance_student_IDLabel;
            System.Windows.Forms.Label grade_IDLabel;
            System.Windows.Forms.Label performance_school_subject_IDLabel;
            System.Windows.Forms.Label performance_first_term_markLabel;
            System.Windows.Forms.Label performance_first_term_dateLabel;
            System.Windows.Forms.Label performance_first_term_teacher_IDLabel;
            System.Windows.Forms.Label performance_second_term_markLabel;
            System.Windows.Forms.Label performance_second_term_dateLabel;
            System.Windows.Forms.Label performance_second_term_teacher_IDLabel;
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performanceTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.performanceTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.gradesTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter();
            this.school_subjectsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.school_subjectsTableAdapter();
            this.studentsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grade_IDComboBox = new System.Windows.Forms.ComboBox();
            this.performance_student_IDComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performance_school_subject_IDComboBox = new System.Windows.Forms.ComboBox();
            this.schoolsubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performance_first_term_markTextBox = new System.Windows.Forms.TextBox();
            this.performance_first_term_teacher_IDComboBox = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter();
            this.performance_second_term_markTextBox = new System.Windows.Forms.TextBox();
            this.performance_second_term_teacher_IDComboBox = new System.Windows.Forms.ComboBox();
            this.performance_first_term_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.performance_second_term_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.firstTermGroupBox = new System.Windows.Forms.GroupBox();
            this.secondTermGroupBox = new System.Windows.Forms.GroupBox();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnAddMark = new System.Windows.Forms.Button();
            performance_student_IDLabel = new System.Windows.Forms.Label();
            grade_IDLabel = new System.Windows.Forms.Label();
            performance_school_subject_IDLabel = new System.Windows.Forms.Label();
            performance_first_term_markLabel = new System.Windows.Forms.Label();
            performance_first_term_dateLabel = new System.Windows.Forms.Label();
            performance_first_term_teacher_IDLabel = new System.Windows.Forms.Label();
            performance_second_term_markLabel = new System.Windows.Forms.Label();
            performance_second_term_dateLabel = new System.Windows.Forms.Label();
            performance_second_term_teacher_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.firstTermGroupBox.SuspendLayout();
            this.secondTermGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // performance_student_IDLabel
            // 
            performance_student_IDLabel.AutoSize = true;
            performance_student_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            performance_student_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            performance_student_IDLabel.Location = new System.Drawing.Point(9, 52);
            performance_student_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_student_IDLabel.Name = "performance_student_IDLabel";
            performance_student_IDLabel.Size = new System.Drawing.Size(177, 29);
            performance_student_IDLabel.TabIndex = 1;
            performance_student_IDLabel.Text = "Выберите учащегося";
            // 
            // grade_IDLabel
            // 
            grade_IDLabel.AutoSize = true;
            grade_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            grade_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            grade_IDLabel.Location = new System.Drawing.Point(9, 9);
            grade_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            grade_IDLabel.Name = "grade_IDLabel";
            grade_IDLabel.Size = new System.Drawing.Size(140, 29);
            grade_IDLabel.TabIndex = 2;
            grade_IDLabel.Text = "Выберите класс";
            // 
            // performance_school_subject_IDLabel
            // 
            performance_school_subject_IDLabel.AutoSize = true;
            performance_school_subject_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            performance_school_subject_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            performance_school_subject_IDLabel.Location = new System.Drawing.Point(9, 96);
            performance_school_subject_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_school_subject_IDLabel.Name = "performance_school_subject_IDLabel";
            performance_school_subject_IDLabel.Size = new System.Drawing.Size(160, 29);
            performance_school_subject_IDLabel.TabIndex = 4;
            performance_school_subject_IDLabel.Text = "Выберите предмет";
            // 
            // performance_first_term_markLabel
            // 
            performance_first_term_markLabel.AutoSize = true;
            performance_first_term_markLabel.Location = new System.Drawing.Point(9, 36);
            performance_first_term_markLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_first_term_markLabel.Name = "performance_first_term_markLabel";
            performance_first_term_markLabel.Size = new System.Drawing.Size(156, 29);
            performance_first_term_markLabel.TabIndex = 6;
            performance_first_term_markLabel.Text = "Выставьте оценку";
            // 
            // performance_first_term_dateLabel
            // 
            performance_first_term_dateLabel.AutoSize = true;
            performance_first_term_dateLabel.Location = new System.Drawing.Point(9, 76);
            performance_first_term_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_first_term_dateLabel.Name = "performance_first_term_dateLabel";
            performance_first_term_dateLabel.Size = new System.Drawing.Size(223, 29);
            performance_first_term_dateLabel.TabIndex = 8;
            performance_first_term_dateLabel.Text = "Дата выставления оценки";
            // 
            // performance_first_term_teacher_IDLabel
            // 
            performance_first_term_teacher_IDLabel.AutoSize = true;
            performance_first_term_teacher_IDLabel.Location = new System.Drawing.Point(9, 115);
            performance_first_term_teacher_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_first_term_teacher_IDLabel.Name = "performance_first_term_teacher_IDLabel";
            performance_first_term_teacher_IDLabel.Size = new System.Drawing.Size(132, 29);
            performance_first_term_teacher_IDLabel.TabIndex = 10;
            performance_first_term_teacher_IDLabel.Text = "Преподаватель";
            // 
            // performance_second_term_markLabel
            // 
            performance_second_term_markLabel.AutoSize = true;
            performance_second_term_markLabel.Location = new System.Drawing.Point(10, 36);
            performance_second_term_markLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_second_term_markLabel.Name = "performance_second_term_markLabel";
            performance_second_term_markLabel.Size = new System.Drawing.Size(156, 29);
            performance_second_term_markLabel.TabIndex = 12;
            performance_second_term_markLabel.Text = "Выставьте оценку";
            // 
            // performance_second_term_dateLabel
            // 
            performance_second_term_dateLabel.AutoSize = true;
            performance_second_term_dateLabel.Location = new System.Drawing.Point(8, 76);
            performance_second_term_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_second_term_dateLabel.Name = "performance_second_term_dateLabel";
            performance_second_term_dateLabel.Size = new System.Drawing.Size(223, 29);
            performance_second_term_dateLabel.TabIndex = 14;
            performance_second_term_dateLabel.Text = "Дата выставления оценки";
            // 
            // performance_second_term_teacher_IDLabel
            // 
            performance_second_term_teacher_IDLabel.AutoSize = true;
            performance_second_term_teacher_IDLabel.Location = new System.Drawing.Point(10, 115);
            performance_second_term_teacher_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_second_term_teacher_IDLabel.Name = "performance_second_term_teacher_IDLabel";
            performance_second_term_teacher_IDLabel.Size = new System.Drawing.Size(132, 29);
            performance_second_term_teacher_IDLabel.TabIndex = 16;
            performance_second_term_teacher_IDLabel.Text = "Преподаватель";
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataMember = "performance";
            this.performanceBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performanceTableAdapter
            // 
            this.performanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = null;
            this.tableAdapterManager.gradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.performanceTableAdapter = this.performanceTableAdapter;
            this.tableAdapterManager.school_subjectsTableAdapter = this.school_subjectsTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // school_subjectsTableAdapter
            // 
            this.school_subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "grades";
            this.gradesBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // grade_IDComboBox
            // 
            this.grade_IDComboBox.DataSource = this.gradesBindingSource;
            this.grade_IDComboBox.DisplayMember = "grade_name";
            this.grade_IDComboBox.DropDownHeight = 150;
            this.grade_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade_IDComboBox.FormattingEnabled = true;
            this.grade_IDComboBox.IntegralHeight = false;
            this.grade_IDComboBox.Location = new System.Drawing.Point(156, 6);
            this.grade_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.grade_IDComboBox.Name = "grade_IDComboBox";
            this.grade_IDComboBox.Size = new System.Drawing.Size(179, 37);
            this.grade_IDComboBox.TabIndex = 3;
            this.grade_IDComboBox.ValueMember = "grade_ID";
            this.grade_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.grade_IDComboBox_SelectedIndexChanged);
            // 
            // performance_student_IDComboBox
            // 
            this.performance_student_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_student_ID", true));
            this.performance_student_IDComboBox.DataSource = this.studentsBindingSource;
            this.performance_student_IDComboBox.DisplayMember = "student_name";
            this.performance_student_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_student_IDComboBox.FormattingEnabled = true;
            this.performance_student_IDComboBox.Location = new System.Drawing.Point(192, 49);
            this.performance_student_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_student_IDComboBox.Name = "performance_student_IDComboBox";
            this.performance_student_IDComboBox.Size = new System.Drawing.Size(313, 37);
            this.performance_student_IDComboBox.TabIndex = 4;
            this.performance_student_IDComboBox.ValueMember = "student_ID";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performance_school_subject_IDComboBox
            // 
            this.performance_school_subject_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_school_subject_ID", true));
            this.performance_school_subject_IDComboBox.DataSource = this.schoolsubjectsBindingSource;
            this.performance_school_subject_IDComboBox.DisplayMember = "school_subject_name";
            this.performance_school_subject_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_school_subject_IDComboBox.FormattingEnabled = true;
            this.performance_school_subject_IDComboBox.Location = new System.Drawing.Point(175, 93);
            this.performance_school_subject_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_school_subject_IDComboBox.Name = "performance_school_subject_IDComboBox";
            this.performance_school_subject_IDComboBox.Size = new System.Drawing.Size(330, 37);
            this.performance_school_subject_IDComboBox.TabIndex = 5;
            this.performance_school_subject_IDComboBox.ValueMember = "school_subject_ID";
            // 
            // schoolsubjectsBindingSource
            // 
            this.schoolsubjectsBindingSource.DataMember = "school_subjects";
            this.schoolsubjectsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performance_first_term_markTextBox
            // 
            this.performance_first_term_markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_first_term_mark", true));
            this.performance_first_term_markTextBox.Location = new System.Drawing.Point(173, 33);
            this.performance_first_term_markTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_first_term_markTextBox.Name = "performance_first_term_markTextBox";
            this.performance_first_term_markTextBox.Size = new System.Drawing.Size(53, 36);
            this.performance_first_term_markTextBox.TabIndex = 7;
            // 
            // performance_first_term_teacher_IDComboBox
            // 
            this.performance_first_term_teacher_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_first_term_teacher_ID", true));
            this.performance_first_term_teacher_IDComboBox.DataSource = this.teachersBindingSource;
            this.performance_first_term_teacher_IDComboBox.DisplayMember = "teacher_name";
            this.performance_first_term_teacher_IDComboBox.FormattingEnabled = true;
            this.performance_first_term_teacher_IDComboBox.Location = new System.Drawing.Point(149, 112);
            this.performance_first_term_teacher_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_first_term_teacher_IDComboBox.Name = "performance_first_term_teacher_IDComboBox";
            this.performance_first_term_teacher_IDComboBox.Size = new System.Drawing.Size(336, 37);
            this.performance_first_term_teacher_IDComboBox.TabIndex = 11;
            this.performance_first_term_teacher_IDComboBox.ValueMember = "teacher_ID";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // performance_second_term_markTextBox
            // 
            this.performance_second_term_markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_second_term_mark", true));
            this.performance_second_term_markTextBox.Location = new System.Drawing.Point(174, 33);
            this.performance_second_term_markTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_second_term_markTextBox.Name = "performance_second_term_markTextBox";
            this.performance_second_term_markTextBox.Size = new System.Drawing.Size(53, 36);
            this.performance_second_term_markTextBox.TabIndex = 13;
            // 
            // performance_second_term_teacher_IDComboBox
            // 
            this.performance_second_term_teacher_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_second_term_teacher_ID", true));
            this.performance_second_term_teacher_IDComboBox.DataSource = this.teachersBindingSource;
            this.performance_second_term_teacher_IDComboBox.DisplayMember = "teacher_name";
            this.performance_second_term_teacher_IDComboBox.FormattingEnabled = true;
            this.performance_second_term_teacher_IDComboBox.Location = new System.Drawing.Point(147, 112);
            this.performance_second_term_teacher_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_second_term_teacher_IDComboBox.Name = "performance_second_term_teacher_IDComboBox";
            this.performance_second_term_teacher_IDComboBox.Size = new System.Drawing.Size(337, 37);
            this.performance_second_term_teacher_IDComboBox.TabIndex = 17;
            this.performance_second_term_teacher_IDComboBox.ValueMember = "teacher_ID";
            // 
            // performance_first_term_dateDateTimePicker
            // 
            this.performance_first_term_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_first_term_date", true));
            this.performance_first_term_dateDateTimePicker.Location = new System.Drawing.Point(240, 73);
            this.performance_first_term_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_first_term_dateDateTimePicker.Mask = "00/00/0000";
            this.performance_first_term_dateDateTimePicker.Name = "performance_first_term_dateDateTimePicker";
            this.performance_first_term_dateDateTimePicker.Size = new System.Drawing.Size(106, 36);
            this.performance_first_term_dateDateTimePicker.TabIndex = 20;
            this.performance_first_term_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // performance_second_term_dateDateTimePicker
            // 
            this.performance_second_term_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_second_term_date", true));
            this.performance_second_term_dateDateTimePicker.Location = new System.Drawing.Point(231, 73);
            this.performance_second_term_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_second_term_dateDateTimePicker.Mask = "00/00/0000";
            this.performance_second_term_dateDateTimePicker.Name = "performance_second_term_dateDateTimePicker";
            this.performance_second_term_dateDateTimePicker.Size = new System.Drawing.Size(253, 36);
            this.performance_second_term_dateDateTimePicker.TabIndex = 21;
            this.performance_second_term_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // firstTermGroupBox
            // 
            this.firstTermGroupBox.Controls.Add(performance_first_term_markLabel);
            this.firstTermGroupBox.Controls.Add(this.performance_first_term_markTextBox);
            this.firstTermGroupBox.Controls.Add(this.performance_first_term_dateDateTimePicker);
            this.firstTermGroupBox.Controls.Add(performance_first_term_dateLabel);
            this.firstTermGroupBox.Controls.Add(this.performance_first_term_teacher_IDComboBox);
            this.firstTermGroupBox.Controls.Add(performance_first_term_teacher_IDLabel);
            this.firstTermGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstTermGroupBox.Location = new System.Drawing.Point(15, 132);
            this.firstTermGroupBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.firstTermGroupBox.Name = "firstTermGroupBox";
            this.firstTermGroupBox.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.firstTermGroupBox.Size = new System.Drawing.Size(491, 157);
            this.firstTermGroupBox.TabIndex = 22;
            this.firstTermGroupBox.TabStop = false;
            this.firstTermGroupBox.Text = "Выставление оценки за первый семестр";
            // 
            // secondTermGroupBox
            // 
            this.secondTermGroupBox.Controls.Add(this.performance_second_term_markTextBox);
            this.secondTermGroupBox.Controls.Add(performance_second_term_markLabel);
            this.secondTermGroupBox.Controls.Add(this.performance_second_term_dateDateTimePicker);
            this.secondTermGroupBox.Controls.Add(this.performance_second_term_teacher_IDComboBox);
            this.secondTermGroupBox.Controls.Add(performance_second_term_teacher_IDLabel);
            this.secondTermGroupBox.Controls.Add(performance_second_term_dateLabel);
            this.secondTermGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondTermGroupBox.Location = new System.Drawing.Point(14, 295);
            this.secondTermGroupBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.secondTermGroupBox.Name = "secondTermGroupBox";
            this.secondTermGroupBox.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.secondTermGroupBox.Size = new System.Drawing.Size(492, 158);
            this.secondTermGroupBox.TabIndex = 23;
            this.secondTermGroupBox.TabStop = false;
            this.secondTermGroupBox.Text = "Выставление оценки за второй семестр";
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(343, 6);
            this.btnExitToMainMenu.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(162, 37);
            this.btnExitToMainMenu.TabIndex = 26;
            this.btnExitToMainMenu.Text = "Выход в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnAddMark
            // 
            this.btnAddMark.BackColor = System.Drawing.Color.Green;
            this.btnAddMark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMark.Location = new System.Drawing.Point(15, 458);
            this.btnAddMark.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(493, 82);
            this.btnAddMark.TabIndex = 27;
            this.btnAddMark.Text = "Выставить";
            this.btnAddMark.UseVisualStyleBackColor = false;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // StudentPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(515, 545);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.performance_school_subject_IDComboBox);
            this.Controls.Add(performance_school_subject_IDLabel);
            this.Controls.Add(this.performance_student_IDComboBox);
            this.Controls.Add(this.grade_IDComboBox);
            this.Controls.Add(grade_IDLabel);
            this.Controls.Add(performance_student_IDLabel);
            this.Controls.Add(this.secondTermGroupBox);
            this.Controls.Add(this.firstTermGroupBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "StudentPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выставление оценок учащимся";
            this.Load += new System.EventHandler(this.StudentPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.firstTermGroupBox.ResumeLayout(false);
            this.firstTermGroupBox.PerformLayout();
            this.secondTermGroupBox.ResumeLayout(false);
            this.secondTermGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource performanceBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.performanceTableAdapter performanceTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox grade_IDComboBox;
        private System.Windows.Forms.ComboBox performance_student_IDComboBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.school_subjectsTableAdapter school_subjectsTableAdapter;
        private System.Windows.Forms.ComboBox performance_school_subject_IDComboBox;
        private System.Windows.Forms.BindingSource schoolsubjectsBindingSource;
        private System.Windows.Forms.TextBox performance_first_term_markTextBox;
        private System.Windows.Forms.ComboBox performance_first_term_teacher_IDComboBox;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.TextBox performance_second_term_markTextBox;
        private System.Windows.Forms.ComboBox performance_second_term_teacher_IDComboBox;
        private System.Windows.Forms.MaskedTextBox performance_first_term_dateDateTimePicker;
        private System.Windows.Forms.MaskedTextBox performance_second_term_dateDateTimePicker;
        private System.Windows.Forms.GroupBox firstTermGroupBox;
        private System.Windows.Forms.GroupBox secondTermGroupBox;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnAddMark;
    }
}