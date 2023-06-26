namespace dedenevskaya_schoolSystem
{
    partial class StudentMarksView
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
            System.Windows.Forms.Label grade_IDLabel;
            System.Windows.Forms.Label performance_student_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.performance_new_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performance_new_viewTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.performance_new_viewTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.gradesTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter();
            this.studentsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter();
            this.performance_new_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performance_student_IDComboBox = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grade_IDComboBox = new System.Windows.Forms.ComboBox();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMainMenu = new System.Windows.Forms.Button();
            grade_IDLabel = new System.Windows.Forms.Label();
            performance_student_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_new_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_new_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grade_IDLabel
            // 
            grade_IDLabel.AutoSize = true;
            grade_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            grade_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            grade_IDLabel.Location = new System.Drawing.Point(7, 9);
            grade_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            grade_IDLabel.Name = "grade_IDLabel";
            grade_IDLabel.Size = new System.Drawing.Size(140, 29);
            grade_IDLabel.TabIndex = 17;
            grade_IDLabel.Text = "Выберите класс";
            // 
            // performance_student_IDLabel
            // 
            performance_student_IDLabel.AutoSize = true;
            performance_student_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            performance_student_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            performance_student_IDLabel.Location = new System.Drawing.Point(7, 50);
            performance_student_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_student_IDLabel.Name = "performance_student_IDLabel";
            performance_student_IDLabel.Size = new System.Drawing.Size(177, 29);
            performance_student_IDLabel.TabIndex = 16;
            performance_student_IDLabel.Text = "Выберите учащегося";
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // performance_new_viewBindingSource
            // 
            this.performance_new_viewBindingSource.DataMember = "performance_new_view";
            this.performance_new_viewBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // performance_new_viewTableAdapter
            // 
            this.performance_new_viewTableAdapter.ClearBeforeFill = true;
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
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // performance_new_viewDataGridView
            // 
            this.performance_new_viewDataGridView.AllowUserToAddRows = false;
            this.performance_new_viewDataGridView.AllowUserToDeleteRows = false;
            this.performance_new_viewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.performance_new_viewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.performance_new_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performance_new_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.performance_new_viewDataGridView.DataSource = this.performance_new_viewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.performance_new_viewDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.performance_new_viewDataGridView.Location = new System.Drawing.Point(12, 89);
            this.performance_new_viewDataGridView.Name = "performance_new_viewDataGridView";
            this.performance_new_viewDataGridView.ReadOnly = true;
            this.performance_new_viewDataGridView.Size = new System.Drawing.Size(1046, 460);
            this.performance_new_viewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "student_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО учащегося";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "school_subject_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "performance_first_term_mark";
            this.dataGridViewTextBoxColumn4.HeaderText = "Оценка за первый семестр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "performance_first_term_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выставления";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "first_term_teacher";
            this.dataGridViewTextBoxColumn6.HeaderText = "Преподаватель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "performance_second_term_mark";
            this.dataGridViewTextBoxColumn7.HeaderText = "Оценка за второй семестр";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "performance_second_term_date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата выставления";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "second_term_teacher";
            this.dataGridViewTextBoxColumn9.HeaderText = "Преподаватель";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "performance_overall_mark";
            this.dataGridViewTextBoxColumn10.HeaderText = "Итоговая оценка";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // performance_student_IDComboBox
            // 
            this.performance_student_IDComboBox.DataSource = this.studentsBindingSource;
            this.performance_student_IDComboBox.DisplayMember = "student_name";
            this.performance_student_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_student_IDComboBox.FormattingEnabled = true;
            this.performance_student_IDComboBox.Location = new System.Drawing.Point(192, 47);
            this.performance_student_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_student_IDComboBox.Name = "performance_student_IDComboBox";
            this.performance_student_IDComboBox.Size = new System.Drawing.Size(273, 37);
            this.performance_student_IDComboBox.TabIndex = 19;
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
            this.grade_IDComboBox.Location = new System.Drawing.Point(155, 6);
            this.grade_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.grade_IDComboBox.Name = "grade_IDComboBox";
            this.grade_IDComboBox.Size = new System.Drawing.Size(92, 37);
            this.grade_IDComboBox.TabIndex = 18;
            this.grade_IDComboBox.ValueMember = "grade_ID";
            this.grade_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.grade_IDComboBox_SelectedIndexChanged);
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "grades";
            this.gradesBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMainMenu.Location = new System.Drawing.Point(749, 6);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(309, 78);
            this.btnMainMenu.TabIndex = 20;
            this.btnMainMenu.Text = "Выход в главное меню";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // StudentMarksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1070, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.performance_student_IDComboBox);
            this.Controls.Add(this.grade_IDComboBox);
            this.Controls.Add(grade_IDLabel);
            this.Controls.Add(performance_student_IDLabel);
            this.Controls.Add(this.performance_new_viewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentMarksView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр оценок учащихся";
            this.Load += new System.EventHandler(this.StudentMarksView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_new_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performance_new_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource performance_new_viewBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.performance_new_viewTableAdapter performance_new_viewTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView performance_new_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private dedenevskaya_schoolDataSetTableAdapters.gradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.ComboBox performance_student_IDComboBox;
        private System.Windows.Forms.ComboBox grade_IDComboBox;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button btnMainMenu;
    }
}