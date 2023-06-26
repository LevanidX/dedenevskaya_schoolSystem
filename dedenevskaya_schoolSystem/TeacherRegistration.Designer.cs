namespace dedenevskaya_schoolSystem
{
    partial class TeacherRegistration
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
            System.Windows.Forms.Label teacher_nameLabel;
            System.Windows.Forms.Label teacher_diplom_qualificationLabel;
            System.Windows.Forms.Label teacher_birth_dateLabel;
            System.Windows.Forms.Label teacher_phone_numberLabel;
            System.Windows.Forms.Label teacher_home_addressLabel;
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.teacher_nameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_home_addressTextBox = new System.Windows.Forms.TextBox();
            this.teacher_phone_numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.teacher_birth_dateDateTimePicker = new System.Windows.Forms.MaskedTextBox();
            this.teacher_diplom_qualificationComboBox = new System.Windows.Forms.ComboBox();
            this.diplomqualificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplom_qualificationsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.diplom_qualificationsTableAdapter();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnRegisterNewTeacher = new System.Windows.Forms.Button();
            teacher_nameLabel = new System.Windows.Forms.Label();
            teacher_diplom_qualificationLabel = new System.Windows.Forms.Label();
            teacher_birth_dateLabel = new System.Windows.Forms.Label();
            teacher_phone_numberLabel = new System.Windows.Forms.Label();
            teacher_home_addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomqualificationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = this.diplom_qualificationsTableAdapter;
            this.tableAdapterManager.gradesTableAdapter = null;
            this.tableAdapterManager.performanceTableAdapter = null;
            this.tableAdapterManager.school_subjectsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacher_nameLabel
            // 
            teacher_nameLabel.AutoSize = true;
            teacher_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            teacher_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            teacher_nameLabel.Location = new System.Drawing.Point(3, 9);
            teacher_nameLabel.Name = "teacher_nameLabel";
            teacher_nameLabel.Size = new System.Drawing.Size(117, 29);
            teacher_nameLabel.TabIndex = 1;
            teacher_nameLabel.Text = "Введите ФИО";
            // 
            // teacher_nameTextBox
            // 
            this.teacher_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "teacher_name", true));
            this.teacher_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_nameTextBox.Location = new System.Drawing.Point(126, 6);
            this.teacher_nameTextBox.Name = "teacher_nameTextBox";
            this.teacher_nameTextBox.Size = new System.Drawing.Size(490, 36);
            this.teacher_nameTextBox.TabIndex = 2;
            // 
            // teacher_diplom_qualificationLabel
            // 
            teacher_diplom_qualificationLabel.AutoSize = true;
            teacher_diplom_qualificationLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            teacher_diplom_qualificationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            teacher_diplom_qualificationLabel.Location = new System.Drawing.Point(3, 51);
            teacher_diplom_qualificationLabel.Name = "teacher_diplom_qualificationLabel";
            teacher_diplom_qualificationLabel.Size = new System.Drawing.Size(312, 29);
            teacher_diplom_qualificationLabel.TabIndex = 3;
            teacher_diplom_qualificationLabel.Text = "Выберите специальность по диплому";
            // 
            // teacher_birth_dateLabel
            // 
            teacher_birth_dateLabel.AutoSize = true;
            teacher_birth_dateLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            teacher_birth_dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            teacher_birth_dateLabel.Location = new System.Drawing.Point(3, 94);
            teacher_birth_dateLabel.Name = "teacher_birth_dateLabel";
            teacher_birth_dateLabel.Size = new System.Drawing.Size(204, 29);
            teacher_birth_dateLabel.TabIndex = 5;
            teacher_birth_dateLabel.Text = "Введите дату рождения";
            // 
            // teacher_phone_numberLabel
            // 
            teacher_phone_numberLabel.AutoSize = true;
            teacher_phone_numberLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            teacher_phone_numberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            teacher_phone_numberLabel.Location = new System.Drawing.Point(3, 136);
            teacher_phone_numberLabel.Name = "teacher_phone_numberLabel";
            teacher_phone_numberLabel.Size = new System.Drawing.Size(211, 29);
            teacher_phone_numberLabel.TabIndex = 7;
            teacher_phone_numberLabel.Text = "Введите номер телефона";
            // 
            // teacher_home_addressLabel
            // 
            teacher_home_addressLabel.AutoSize = true;
            teacher_home_addressLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            teacher_home_addressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            teacher_home_addressLabel.Location = new System.Drawing.Point(3, 178);
            teacher_home_addressLabel.Name = "teacher_home_addressLabel";
            teacher_home_addressLabel.Size = new System.Drawing.Size(218, 29);
            teacher_home_addressLabel.TabIndex = 9;
            teacher_home_addressLabel.Text = "Введите домашний адрес";
            // 
            // teacher_home_addressTextBox
            // 
            this.teacher_home_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "teacher_home_address", true));
            this.teacher_home_addressTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_home_addressTextBox.Location = new System.Drawing.Point(227, 175);
            this.teacher_home_addressTextBox.Name = "teacher_home_addressTextBox";
            this.teacher_home_addressTextBox.Size = new System.Drawing.Size(389, 36);
            this.teacher_home_addressTextBox.TabIndex = 10;
            // 
            // teacher_phone_numberMaskedTextBox
            // 
            this.teacher_phone_numberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "teacher_phone_number", true));
            this.teacher_phone_numberMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_phone_numberMaskedTextBox.Location = new System.Drawing.Point(213, 133);
            this.teacher_phone_numberMaskedTextBox.Mask = "+7 (999) 000-00-00";
            this.teacher_phone_numberMaskedTextBox.Name = "teacher_phone_numberMaskedTextBox";
            this.teacher_phone_numberMaskedTextBox.Size = new System.Drawing.Size(403, 36);
            this.teacher_phone_numberMaskedTextBox.TabIndex = 16;
            // 
            // teacher_birth_dateDateTimePicker
            // 
            this.teacher_birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "teacher_birth_date", true));
            this.teacher_birth_dateDateTimePicker.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_birth_dateDateTimePicker.Location = new System.Drawing.Point(213, 91);
            this.teacher_birth_dateDateTimePicker.Mask = "00/00/0000";
            this.teacher_birth_dateDateTimePicker.Name = "teacher_birth_dateDateTimePicker";
            this.teacher_birth_dateDateTimePicker.Size = new System.Drawing.Size(403, 36);
            this.teacher_birth_dateDateTimePicker.TabIndex = 15;
            this.teacher_birth_dateDateTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // teacher_diplom_qualificationComboBox
            // 
            this.teacher_diplom_qualificationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teachersBindingSource, "teacher_diplom_qualification", true));
            this.teacher_diplom_qualificationComboBox.DataSource = this.diplomqualificationsBindingSource;
            this.teacher_diplom_qualificationComboBox.DisplayMember = "diplom_qualification_name";
            this.teacher_diplom_qualificationComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_diplom_qualificationComboBox.FormattingEnabled = true;
            this.teacher_diplom_qualificationComboBox.Location = new System.Drawing.Point(321, 48);
            this.teacher_diplom_qualificationComboBox.Name = "teacher_diplom_qualificationComboBox";
            this.teacher_diplom_qualificationComboBox.Size = new System.Drawing.Size(295, 37);
            this.teacher_diplom_qualificationComboBox.TabIndex = 14;
            this.teacher_diplom_qualificationComboBox.ValueMember = "diplom_qualification_ID";
            // 
            // diplomqualificationsBindingSource
            // 
            this.diplomqualificationsBindingSource.DataMember = "diplom_qualifications";
            this.diplomqualificationsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // diplom_qualificationsTableAdapter
            // 
            this.diplom_qualificationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(7, 313);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(609, 90);
            this.btnExitToMainMenu.TabIndex = 18;
            this.btnExitToMainMenu.Text = "Выход в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnRegisterNewTeacher
            // 
            this.btnRegisterNewTeacher.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNewTeacher.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegisterNewTeacher.Location = new System.Drawing.Point(8, 217);
            this.btnRegisterNewTeacher.Name = "btnRegisterNewTeacher";
            this.btnRegisterNewTeacher.Size = new System.Drawing.Size(608, 90);
            this.btnRegisterNewTeacher.TabIndex = 17;
            this.btnRegisterNewTeacher.Text = "Зарегистрировать";
            this.btnRegisterNewTeacher.UseVisualStyleBackColor = false;
            this.btnRegisterNewTeacher.Click += new System.EventHandler(this.btnRegisterNewTeacher_Click);
            // 
            // TeacherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.btnRegisterNewTeacher);
            this.Controls.Add(this.teacher_phone_numberMaskedTextBox);
            this.Controls.Add(this.teacher_birth_dateDateTimePicker);
            this.Controls.Add(this.teacher_diplom_qualificationComboBox);
            this.Controls.Add(teacher_home_addressLabel);
            this.Controls.Add(this.teacher_home_addressTextBox);
            this.Controls.Add(teacher_phone_numberLabel);
            this.Controls.Add(teacher_birth_dateLabel);
            this.Controls.Add(teacher_diplom_qualificationLabel);
            this.Controls.Add(teacher_nameLabel);
            this.Controls.Add(this.teacher_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeacherRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация преподавателя";
            this.Load += new System.EventHandler(this.TeacherRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomqualificationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox teacher_nameTextBox;
        private System.Windows.Forms.TextBox teacher_home_addressTextBox;
        private System.Windows.Forms.MaskedTextBox teacher_phone_numberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox teacher_birth_dateDateTimePicker;
        private System.Windows.Forms.ComboBox teacher_diplom_qualificationComboBox;
        private dedenevskaya_schoolDataSetTableAdapters.diplom_qualificationsTableAdapter diplom_qualificationsTableAdapter;
        private System.Windows.Forms.BindingSource diplomqualificationsBindingSource;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnRegisterNewTeacher;
    }
}