namespace dedenevskaya_schoolSystem
{
    partial class StudentRegistration
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
            System.Windows.Forms.Label student_nameLabel;
            System.Windows.Forms.Label student_grade_IDLabel;
            System.Windows.Forms.Label student_birth_dateLabel;
            System.Windows.Forms.Label student_phone_numberLabel;
            System.Windows.Forms.Label student_home_addressLabel;
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.gradesTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter();
            this.student_nameTextBox = new System.Windows.Forms.TextBox();
            this.student_home_addressTextBox = new System.Windows.Forms.TextBox();
            this.student_grade_IDComboBox = new System.Windows.Forms.ComboBox();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_birth_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.student_phone_numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnRegisterNewStudent = new System.Windows.Forms.Button();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            student_nameLabel = new System.Windows.Forms.Label();
            student_grade_IDLabel = new System.Windows.Forms.Label();
            student_birth_dateLabel = new System.Windows.Forms.Label();
            student_phone_numberLabel = new System.Windows.Forms.Label();
            student_home_addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // student_nameLabel
            // 
            student_nameLabel.AutoSize = true;
            student_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            student_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            student_nameLabel.Location = new System.Drawing.Point(5, 9);
            student_nameLabel.Name = "student_nameLabel";
            student_nameLabel.Size = new System.Drawing.Size(117, 29);
            student_nameLabel.TabIndex = 1;
            student_nameLabel.Text = "Введите ФИО";
            // 
            // student_grade_IDLabel
            // 
            student_grade_IDLabel.AutoSize = true;
            student_grade_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            student_grade_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            student_grade_IDLabel.Location = new System.Drawing.Point(5, 50);
            student_grade_IDLabel.Name = "student_grade_IDLabel";
            student_grade_IDLabel.Size = new System.Drawing.Size(140, 29);
            student_grade_IDLabel.TabIndex = 3;
            student_grade_IDLabel.Text = "Выберите класс";
            // 
            // student_birth_dateLabel
            // 
            student_birth_dateLabel.AutoSize = true;
            student_birth_dateLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            student_birth_dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            student_birth_dateLabel.Location = new System.Drawing.Point(5, 93);
            student_birth_dateLabel.Name = "student_birth_dateLabel";
            student_birth_dateLabel.Size = new System.Drawing.Size(204, 29);
            student_birth_dateLabel.TabIndex = 5;
            student_birth_dateLabel.Text = "Введите дату рождения";
            // 
            // student_phone_numberLabel
            // 
            student_phone_numberLabel.AutoSize = true;
            student_phone_numberLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            student_phone_numberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            student_phone_numberLabel.Location = new System.Drawing.Point(5, 135);
            student_phone_numberLabel.Name = "student_phone_numberLabel";
            student_phone_numberLabel.Size = new System.Drawing.Size(211, 29);
            student_phone_numberLabel.TabIndex = 7;
            student_phone_numberLabel.Text = "Введите номер телефона";
            // 
            // student_home_addressLabel
            // 
            student_home_addressLabel.AutoSize = true;
            student_home_addressLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            student_home_addressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            student_home_addressLabel.Location = new System.Drawing.Point(5, 177);
            student_home_addressLabel.Name = "student_home_addressLabel";
            student_home_addressLabel.Size = new System.Drawing.Size(218, 29);
            student_home_addressLabel.TabIndex = 9;
            student_home_addressLabel.Text = "Введите домашний адрес";
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = null;
            this.tableAdapterManager.gradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.performanceTableAdapter = null;
            this.tableAdapterManager.school_subjectsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // student_nameTextBox
            // 
            this.student_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_name", true));
            this.student_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_nameTextBox.Location = new System.Drawing.Point(128, 6);
            this.student_nameTextBox.Name = "student_nameTextBox";
            this.student_nameTextBox.Size = new System.Drawing.Size(489, 36);
            this.student_nameTextBox.TabIndex = 2;
            // 
            // student_home_addressTextBox
            // 
            this.student_home_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_home_address", true));
            this.student_home_addressTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_home_addressTextBox.Location = new System.Drawing.Point(229, 174);
            this.student_home_addressTextBox.Name = "student_home_addressTextBox";
            this.student_home_addressTextBox.Size = new System.Drawing.Size(388, 36);
            this.student_home_addressTextBox.TabIndex = 10;
            // 
            // student_grade_IDComboBox
            // 
            this.student_grade_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource, "student_grade_ID", true));
            this.student_grade_IDComboBox.DataSource = this.gradesBindingSource;
            this.student_grade_IDComboBox.DisplayMember = "grade_name";
            this.student_grade_IDComboBox.DropDownHeight = 170;
            this.student_grade_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_grade_IDComboBox.FormattingEnabled = true;
            this.student_grade_IDComboBox.IntegralHeight = false;
            this.student_grade_IDComboBox.Location = new System.Drawing.Point(151, 47);
            this.student_grade_IDComboBox.Name = "student_grade_IDComboBox";
            this.student_grade_IDComboBox.Size = new System.Drawing.Size(466, 37);
            this.student_grade_IDComboBox.TabIndex = 11;
            this.student_grade_IDComboBox.ValueMember = "grade_ID";
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "grades";
            this.gradesBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // student_birth_dateDateTimePicker
            // 
            this.student_birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_birth_date", true));
            this.student_birth_dateDateTimePicker.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_birth_dateDateTimePicker.Location = new System.Drawing.Point(215, 90);
            this.student_birth_dateDateTimePicker.Mask = "00/00/0000";
            this.student_birth_dateDateTimePicker.Name = "student_birth_dateDateTimePicker";
            this.student_birth_dateDateTimePicker.Size = new System.Drawing.Size(402, 36);
            this.student_birth_dateDateTimePicker.TabIndex = 12;
            this.student_birth_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // student_phone_numberMaskedTextBox
            // 
            this.student_phone_numberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "student_phone_number", true));
            this.student_phone_numberMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_phone_numberMaskedTextBox.Location = new System.Drawing.Point(215, 132);
            this.student_phone_numberMaskedTextBox.Mask = "+7 (999) 000-00-00";
            this.student_phone_numberMaskedTextBox.Name = "student_phone_numberMaskedTextBox";
            this.student_phone_numberMaskedTextBox.Size = new System.Drawing.Size(402, 36);
            this.student_phone_numberMaskedTextBox.TabIndex = 13;
            // 
            // btnRegisterNewStudent
            // 
            this.btnRegisterNewStudent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNewStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegisterNewStudent.Location = new System.Drawing.Point(10, 216);
            this.btnRegisterNewStudent.Name = "btnRegisterNewStudent";
            this.btnRegisterNewStudent.Size = new System.Drawing.Size(607, 90);
            this.btnRegisterNewStudent.TabIndex = 14;
            this.btnRegisterNewStudent.Text = "Зарегистрировать";
            this.btnRegisterNewStudent.UseVisualStyleBackColor = false;
            this.btnRegisterNewStudent.Click += new System.EventHandler(this.btnRegisterNewStudent_Click);
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(9, 312);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(607, 90);
            this.btnExitToMainMenu.TabIndex = 15;
            this.btnExitToMainMenu.Text = "Выход в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.btnRegisterNewStudent);
            this.Controls.Add(this.student_phone_numberMaskedTextBox);
            this.Controls.Add(this.student_birth_dateDateTimePicker);
            this.Controls.Add(this.student_grade_IDComboBox);
            this.Controls.Add(student_home_addressLabel);
            this.Controls.Add(this.student_home_addressTextBox);
            this.Controls.Add(student_phone_numberLabel);
            this.Controls.Add(student_birth_dateLabel);
            this.Controls.Add(student_grade_IDLabel);
            this.Controls.Add(student_nameLabel);
            this.Controls.Add(this.student_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация учащегося";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.TextBox student_nameTextBox;
        private System.Windows.Forms.TextBox student_home_addressTextBox;
        private System.Windows.Forms.ComboBox student_grade_IDComboBox;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private System.Windows.Forms.MaskedTextBox student_birth_dateDateTimePicker;
        private System.Windows.Forms.MaskedTextBox student_phone_numberMaskedTextBox;
        private System.Windows.Forms.Button btnRegisterNewStudent;
        private System.Windows.Forms.Button btnExitToMainMenu;
    }
}