namespace dedenevskaya_schoolSystem
{
    partial class PerformanceEditView
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
            System.Windows.Forms.Label performance_first_term_markLabel;
            System.Windows.Forms.Label performance_first_term_dateLabel;
            System.Windows.Forms.Label performance_first_term_teacher_IDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label grade_IDLabel;
            System.Windows.Forms.Label performance_student_IDLabel;
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.performance_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performance_viewTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.performance_viewTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.performanceTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.performanceTableAdapter();
            this.studentsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter();
            this.teachersTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performance_first_term_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.performance_first_term_markTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.performance_student_IDComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grade_IDComboBox = new System.Windows.Forms.ComboBox();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter();
            this.btnMainMenu = new System.Windows.Forms.Button();
            performance_first_term_markLabel = new System.Windows.Forms.Label();
            performance_first_term_dateLabel = new System.Windows.Forms.Label();
            performance_first_term_teacher_IDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            grade_IDLabel = new System.Windows.Forms.Label();
            performance_student_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_viewBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // performance_first_term_markLabel
            // 
            performance_first_term_markLabel.AutoSize = true;
            performance_first_term_markLabel.Location = new System.Drawing.Point(6, 32);
            performance_first_term_markLabel.Name = "performance_first_term_markLabel";
            performance_first_term_markLabel.Size = new System.Drawing.Size(72, 29);
            performance_first_term_markLabel.TabIndex = 0;
            performance_first_term_markLabel.Text = "Оценка";
            // 
            // performance_first_term_dateLabel
            // 
            performance_first_term_dateLabel.AutoSize = true;
            performance_first_term_dateLabel.Location = new System.Drawing.Point(6, 72);
            performance_first_term_dateLabel.Name = "performance_first_term_dateLabel";
            performance_first_term_dateLabel.Size = new System.Drawing.Size(161, 29);
            performance_first_term_dateLabel.TabIndex = 2;
            performance_first_term_dateLabel.Text = "Дата выставления";
            // 
            // performance_first_term_teacher_IDLabel
            // 
            performance_first_term_teacher_IDLabel.AutoSize = true;
            performance_first_term_teacher_IDLabel.Location = new System.Drawing.Point(6, 113);
            performance_first_term_teacher_IDLabel.Name = "performance_first_term_teacher_IDLabel";
            performance_first_term_teacher_IDLabel.Size = new System.Drawing.Size(132, 29);
            performance_first_term_teacher_IDLabel.TabIndex = 4;
            performance_first_term_teacher_IDLabel.Text = "Преподаватель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 29);
            label3.TabIndex = 4;
            label3.Text = "Преподаватель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 72);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 29);
            label5.TabIndex = 2;
            label5.Text = "Дата выставления";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 29);
            label6.TabIndex = 0;
            label6.Text = "Оценка";
            // 
            // grade_IDLabel
            // 
            grade_IDLabel.AutoSize = true;
            grade_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            grade_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            grade_IDLabel.Location = new System.Drawing.Point(3, 9);
            grade_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            grade_IDLabel.Name = "grade_IDLabel";
            grade_IDLabel.Size = new System.Drawing.Size(140, 29);
            grade_IDLabel.TabIndex = 13;
            grade_IDLabel.Text = "Выберите класс";
            // 
            // performance_student_IDLabel
            // 
            performance_student_IDLabel.AutoSize = true;
            performance_student_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            performance_student_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            performance_student_IDLabel.Location = new System.Drawing.Point(3, 50);
            performance_student_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_student_IDLabel.Name = "performance_student_IDLabel";
            performance_student_IDLabel.Size = new System.Drawing.Size(177, 29);
            performance_student_IDLabel.TabIndex = 12;
            performance_student_IDLabel.Text = "Выберите учащегося";
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performance_viewBindingSource
            // 
            this.performance_viewBindingSource.DataMember = "performance_view";
            this.performance_viewBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performance_viewTableAdapter
            // 
            this.performance_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = null;
            this.tableAdapterManager.gradesTableAdapter = null;
            this.tableAdapterManager.performanceTableAdapter = this.performanceTableAdapter;
            this.tableAdapterManager.school_subjectsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.teachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // performanceTableAdapter
            // 
            this.performanceTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performance_viewBindingSource, "student_name", true));
            this.lblStudentName.Location = new System.Drawing.Point(146, 88);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(44, 29);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО учащегося";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предмет";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performance_viewBindingSource, "school_subject_name", true));
            this.lblSubject.Location = new System.Drawing.Point(88, 117);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(89, 29);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.performance_first_term_dateDateTimePicker);
            this.groupBox1.Controls.Add(performance_first_term_teacher_IDLabel);
            this.groupBox1.Controls.Add(performance_first_term_dateLabel);
            this.groupBox1.Controls.Add(performance_first_term_markLabel);
            this.groupBox1.Controls.Add(this.performance_first_term_markTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(8, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первый семестр";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_first_term_teacher_ID", true));
            this.comboBox1.DataSource = this.teachersBindingSource;
            this.comboBox1.DisplayMember = "teacher_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 37);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "teacher_ID";
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataMember = "performance";
            this.performanceBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performance_first_term_dateDateTimePicker
            // 
            this.performance_first_term_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_first_term_date", true));
            this.performance_first_term_dateDateTimePicker.Location = new System.Drawing.Point(173, 69);
            this.performance_first_term_dateDateTimePicker.Mask = "00/00/0000";
            this.performance_first_term_dateDateTimePicker.Name = "performance_first_term_dateDateTimePicker";
            this.performance_first_term_dateDateTimePicker.Size = new System.Drawing.Size(100, 36);
            this.performance_first_term_dateDateTimePicker.TabIndex = 6;
            this.performance_first_term_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // performance_first_term_markTextBox
            // 
            this.performance_first_term_markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_first_term_mark", true));
            this.performance_first_term_markTextBox.Location = new System.Drawing.Point(84, 29);
            this.performance_first_term_markTextBox.Name = "performance_first_term_markTextBox";
            this.performance_first_term_markTextBox.Size = new System.Drawing.Size(69, 36);
            this.performance_first_term_markTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(8, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Второй семестр";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "performance_second_term_teacher_ID", true));
            this.comboBox2.DataSource = this.teachersBindingSource;
            this.comboBox2.DisplayMember = "teacher_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 37);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "teacher_ID";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_second_term_date", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(173, 69);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 36);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "performance_second_term_mark", true));
            this.textBox1.Location = new System.Drawing.Point(84, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 36);
            this.textBox1.TabIndex = 1;
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMovePrevious.Location = new System.Drawing.Point(8, 475);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(115, 58);
            this.btnMovePrevious.TabIndex = 9;
            this.btnMovePrevious.Text = "Назад";
            this.btnMovePrevious.UseVisualStyleBackColor = false;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMoveNext.Location = new System.Drawing.Point(129, 475);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(115, 58);
            this.btnMoveNext.TabIndex = 10;
            this.btnMoveNext.Text = "Вперед";
            this.btnMoveNext.UseVisualStyleBackColor = false;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(250, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 58);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // performance_student_IDComboBox
            // 
            this.performance_student_IDComboBox.DataSource = this.studentsBindingSource;
            this.performance_student_IDComboBox.DisplayMember = "student_name";
            this.performance_student_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_student_IDComboBox.FormattingEnabled = true;
            this.performance_student_IDComboBox.Location = new System.Drawing.Point(181, 47);
            this.performance_student_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_student_IDComboBox.Name = "performance_student_IDComboBox";
            this.performance_student_IDComboBox.Size = new System.Drawing.Size(273, 37);
            this.performance_student_IDComboBox.TabIndex = 15;
            this.performance_student_IDComboBox.ValueMember = "student_ID";
            this.performance_student_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.performance_student_IDComboBox_SelectedIndexChanged);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // grade_IDComboBox
            // 
            this.grade_IDComboBox.DataSource = this.gradesBindingSource;
            this.grade_IDComboBox.DisplayMember = "grade_name";
            this.grade_IDComboBox.DropDownHeight = 150;
            this.grade_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade_IDComboBox.FormattingEnabled = true;
            this.grade_IDComboBox.IntegralHeight = false;
            this.grade_IDComboBox.Location = new System.Drawing.Point(151, 6);
            this.grade_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.grade_IDComboBox.Name = "grade_IDComboBox";
            this.grade_IDComboBox.Size = new System.Drawing.Size(92, 37);
            this.grade_IDComboBox.TabIndex = 14;
            this.grade_IDComboBox.ValueMember = "grade_ID";
            this.grade_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.grade_IDComboBox_SelectedIndexChanged);
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "grades";
            this.gradesBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnMainMenu.Location = new System.Drawing.Point(250, 6);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(204, 37);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Выход в главное меню";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // PerformanceEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(462, 539);
            this.ControlBox = false;
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.performance_student_IDComboBox);
            this.Controls.Add(this.grade_IDComboBox);
            this.Controls.Add(grade_IDLabel);
            this.Controls.Add(performance_student_IDLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrevious);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentName);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "PerformanceEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование оценок учащихся";
            this.Load += new System.EventHandler(this.PerformanceEditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_viewBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource performance_viewBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.performance_viewTableAdapter performance_viewTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubject;
        private dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox performance_first_term_dateDateTimePicker;
        private System.Windows.Forms.TextBox performance_first_term_markTextBox;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveNext;
        private dedenevskaya_schoolDataSetTableAdapters.performanceTableAdapter performanceTableAdapter;
        private System.Windows.Forms.BindingSource performanceBindingSource;
        private System.Windows.Forms.Button btnSave;
        private dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox performance_student_IDComboBox;
        private System.Windows.Forms.ComboBox grade_IDComboBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.Button btnMainMenu;
    }
}