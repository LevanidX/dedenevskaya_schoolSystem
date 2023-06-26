namespace dedenevskaya_schoolSystem
{
    partial class MarksBySubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label performance_school_subject_IDLabel;
            this.dedenevskaya_schoolDataSet = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSet();
            this.show_avg_markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.show_avg_markTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.show_avg_markTableAdapter();
            this.tableAdapterManager = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager();
            this.show_avg_markDataGridView = new System.Windows.Forms.DataGridView();
            this.performance_school_subject_IDComboBox = new System.Windows.Forms.ComboBox();
            this.schoolsubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_subjectsTableAdapter = new dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.school_subjectsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMainMenu = new System.Windows.Forms.Button();
            performance_school_subject_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_avg_markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_avg_markDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dedenevskaya_schoolDataSet
            // 
            this.dedenevskaya_schoolDataSet.DataSetName = "dedenevskaya_schoolDataSet";
            this.dedenevskaya_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // show_avg_markBindingSource
            // 
            this.show_avg_markBindingSource.DataMember = "show_avg_mark";
            this.show_avg_markBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // show_avg_markTableAdapter
            // 
            this.show_avg_markTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diplom_qualificationsTableAdapter = null;
            this.tableAdapterManager.gradesTableAdapter = null;
            this.tableAdapterManager.performanceTableAdapter = null;
            this.tableAdapterManager.school_subjectsTableAdapter = this.school_subjectsTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // show_avg_markDataGridView
            // 
            this.show_avg_markDataGridView.AllowUserToAddRows = false;
            this.show_avg_markDataGridView.AllowUserToDeleteRows = false;
            this.show_avg_markDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_avg_markDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.show_avg_markDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_avg_markDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.show_avg_markDataGridView.DataSource = this.show_avg_markBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_avg_markDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.show_avg_markDataGridView.Location = new System.Drawing.Point(7, 53);
            this.show_avg_markDataGridView.Name = "show_avg_markDataGridView";
            this.show_avg_markDataGridView.ReadOnly = true;
            this.show_avg_markDataGridView.Size = new System.Drawing.Size(600, 126);
            this.show_avg_markDataGridView.TabIndex = 2;
            // 
            // performance_school_subject_IDComboBox
            // 
            this.performance_school_subject_IDComboBox.DataSource = this.schoolsubjectsBindingSource;
            this.performance_school_subject_IDComboBox.DisplayMember = "school_subject_name";
            this.performance_school_subject_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_school_subject_IDComboBox.FormattingEnabled = true;
            this.performance_school_subject_IDComboBox.Location = new System.Drawing.Point(170, 6);
            this.performance_school_subject_IDComboBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.performance_school_subject_IDComboBox.Name = "performance_school_subject_IDComboBox";
            this.performance_school_subject_IDComboBox.Size = new System.Drawing.Size(437, 37);
            this.performance_school_subject_IDComboBox.TabIndex = 7;
            this.performance_school_subject_IDComboBox.ValueMember = "school_subject_ID";
            this.performance_school_subject_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.performance_school_subject_IDComboBox_SelectedIndexChanged);
            // 
            // performance_school_subject_IDLabel
            // 
            performance_school_subject_IDLabel.AutoSize = true;
            performance_school_subject_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            performance_school_subject_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            performance_school_subject_IDLabel.Location = new System.Drawing.Point(2, 9);
            performance_school_subject_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performance_school_subject_IDLabel.Name = "performance_school_subject_IDLabel";
            performance_school_subject_IDLabel.Size = new System.Drawing.Size(160, 29);
            performance_school_subject_IDLabel.TabIndex = 6;
            performance_school_subject_IDLabel.Text = "Выберите предмет";
            // 
            // schoolsubjectsBindingSource
            // 
            this.schoolsubjectsBindingSource.DataMember = "school_subjects";
            this.schoolsubjectsBindingSource.DataSource = this.dedenevskaya_schoolDataSet;
            // 
            // school_subjectsTableAdapter
            // 
            this.school_subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "school_subject_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "performance_AVG_first_term_mark";
            this.dataGridViewTextBoxColumn2.HeaderText = "Средняя оценка за первый семестр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "performance_AVG_second_term_mark";
            this.dataGridViewTextBoxColumn3.HeaderText = "Средняя оценка за второй семестр";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "performance_AVG_overall_mark";
            this.dataGridViewTextBoxColumn4.HeaderText = "Средняя итоговая оценка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMainMenu.Location = new System.Drawing.Point(7, 185);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(600, 54);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "Выход в главное меню";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // MarksBySubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(616, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.performance_school_subject_IDComboBox);
            this.Controls.Add(performance_school_subject_IDLabel);
            this.Controls.Add(this.show_avg_markDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarksBySubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средняя успеваемость по предметам";
            this.Load += new System.EventHandler(this.MarksBySubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dedenevskaya_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_avg_markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_avg_markDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dedenevskaya_schoolDataSet dedenevskaya_schoolDataSet;
        private System.Windows.Forms.BindingSource show_avg_markBindingSource;
        private dedenevskaya_schoolDataSetTableAdapters.show_avg_markTableAdapter show_avg_markTableAdapter;
        private dedenevskaya_schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView show_avg_markDataGridView;
        private dedenevskaya_schoolDataSetTableAdapters.school_subjectsTableAdapter school_subjectsTableAdapter;
        private System.Windows.Forms.ComboBox performance_school_subject_IDComboBox;
        private System.Windows.Forms.BindingSource schoolsubjectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnMainMenu;
    }
}