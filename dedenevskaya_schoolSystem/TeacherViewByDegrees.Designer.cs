namespace dedenevskaya_schoolSystem
{
    partial class TeacherViewByDegrees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.degreeComboBox = new System.Windows.Forms.ComboBox();
            this.diplomqualificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.teachers_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachers_viewTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.teachers_viewTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.diplom_qualificationsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.diplom_qualificationsTableAdapter();
            this.teachers_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diplomqualificationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(9, 284);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(941, 90);
            this.btnExitToMainMenu.TabIndex = 19;
            this.btnExitToMainMenu.Text = "Выход в главное меню";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // degreeComboBox
            // 
            this.degreeComboBox.DataSource = this.diplomqualificationsBindingSource;
            this.degreeComboBox.DisplayMember = "diplom_qualification_name";
            this.degreeComboBox.DropDownHeight = 170;
            this.degreeComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeComboBox.FormattingEnabled = true;
            this.degreeComboBox.IntegralHeight = false;
            this.degreeComboBox.Location = new System.Drawing.Point(267, 8);
            this.degreeComboBox.Name = "degreeComboBox";
            this.degreeComboBox.Size = new System.Drawing.Size(683, 41);
            this.degreeComboBox.TabIndex = 18;
            this.degreeComboBox.ValueMember = "diplom_qualification_ID";
            this.degreeComboBox.SelectedIndexChanged += new System.EventHandler(this.gradeComboBox_SelectedIndexChanged);
            // 
            // diplomqualificationsBindingSource
            // 
            this.diplomqualificationsBindingSource.DataMember = "diplom_qualifications";
            this.diplomqualificationsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите специальность";
            // 
            // teachers_viewBindingSource
            // 
            this.teachers_viewBindingSource.DataMember = "teachers_view";
            this.teachers_viewBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // teachers_viewTableAdapter
            // 
            this.teachers_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = this.diplom_qualificationsTableAdapter;
            this.tableAdapterManager.gradesTableAdapter = null;
            this.tableAdapterManager.performanceTableAdapter = null;
            this.tableAdapterManager.school_subjectsTableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // diplom_qualificationsTableAdapter
            // 
            this.diplom_qualificationsTableAdapter.ClearBeforeFill = true;
            // 
            // teachers_viewDataGridView
            // 
            this.teachers_viewDataGridView.AllowUserToAddRows = false;
            this.teachers_viewDataGridView.AllowUserToDeleteRows = false;
            this.teachers_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachers_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.teachers_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.teachers_viewDataGridView.DataSource = this.teachers_viewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teachers_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.teachers_viewDataGridView.Location = new System.Drawing.Point(9, 55);
            this.teachers_viewDataGridView.Name = "teachers_viewDataGridView";
            this.teachers_viewDataGridView.ReadOnly = true;
            this.teachers_viewDataGridView.Size = new System.Drawing.Size(941, 220);
            this.teachers_viewDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "teacher_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер преподавателя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teacher_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО преподавателя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "diplom_qualification_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Специальность по диплому";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "teacher_birth_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "teacher_phone_number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "teacher_home_address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Домашний адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // TeacherViewByDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(960, 381);
            this.ControlBox = false;
            this.Controls.Add(this.teachers_viewDataGridView);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.degreeComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeacherViewByDegrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр преподавателей по специальностям";
            this.Load += new System.EventHandler(this.TeacherViewByDegrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomqualificationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.ComboBox degreeComboBox;
        private System.Windows.Forms.Label label1;
        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource teachers_viewBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.teachers_viewTableAdapter teachers_viewTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dedenevskaya_schoolDataSetTableAdapters.diplom_qualificationsTableAdapter diplom_qualificationsTableAdapter;
        private System.Windows.Forms.DataGridView teachers_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource diplomqualificationsBindingSource;
    }
}