namespace dedenevskaya_schoolSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.btnRegisterNewStudent = new System.Windows.Forms.Button();
            this.btnRegisterNewTeacher = new System.Windows.Forms.Button();
            this.btnViewStudentsByGrades = new System.Windows.Forms.Button();
            this.btnViewTeachersByDegrees = new System.Windows.Forms.Button();
            this.btnViewMarksBySubjects = new System.Windows.Forms.Button();
            this.btnViewStudentMarks = new System.Windows.Forms.Button();
            this.btnGiveStudentsMarks = new System.Windows.Forms.Button();
            this.btnPerformanceEditView = new System.Windows.Forms.Button();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.registrationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПРИЛОЖЕНИЕ ДЕДЕНЕВСКАЯ ШКОЛА";
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.BackColor = System.Drawing.Color.Red;
            this.btnExitProgramm.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitProgramm.Location = new System.Drawing.Point(475, 5);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(501, 52);
            this.btnExitProgramm.TabIndex = 1;
            this.btnExitProgramm.Text = "Выход из программы";
            this.btnExitProgramm.UseVisualStyleBackColor = false;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // btnRegisterNewStudent
            // 
            this.btnRegisterNewStudent.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNewStudent.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewStudent.Location = new System.Drawing.Point(8, 35);
            this.btnRegisterNewStudent.Name = "btnRegisterNewStudent";
            this.btnRegisterNewStudent.Size = new System.Drawing.Size(228, 90);
            this.btnRegisterNewStudent.TabIndex = 2;
            this.btnRegisterNewStudent.Text = "Регистрация нового учащегося";
            this.btnRegisterNewStudent.UseVisualStyleBackColor = false;
            this.btnRegisterNewStudent.Click += new System.EventHandler(this.btnRegisterNewStudent_Click);
            // 
            // btnRegisterNewTeacher
            // 
            this.btnRegisterNewTeacher.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNewTeacher.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewTeacher.Location = new System.Drawing.Point(242, 35);
            this.btnRegisterNewTeacher.Name = "btnRegisterNewTeacher";
            this.btnRegisterNewTeacher.Size = new System.Drawing.Size(231, 90);
            this.btnRegisterNewTeacher.TabIndex = 3;
            this.btnRegisterNewTeacher.Text = "Регистрация нового преподавателя";
            this.btnRegisterNewTeacher.UseVisualStyleBackColor = false;
            this.btnRegisterNewTeacher.Click += new System.EventHandler(this.btnRegisterNewTeacher_Click);
            // 
            // btnViewStudentsByGrades
            // 
            this.btnViewStudentsByGrades.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewStudentsByGrades.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewStudentsByGrades.Location = new System.Drawing.Point(6, 35);
            this.btnViewStudentsByGrades.Name = "btnViewStudentsByGrades";
            this.btnViewStudentsByGrades.Size = new System.Drawing.Size(467, 58);
            this.btnViewStudentsByGrades.TabIndex = 4;
            this.btnViewStudentsByGrades.Text = "Просмотр учащихся по классам";
            this.btnViewStudentsByGrades.UseVisualStyleBackColor = false;
            this.btnViewStudentsByGrades.Click += new System.EventHandler(this.btnViewStudentsByGrades_Click);
            // 
            // btnViewTeachersByDegrees
            // 
            this.btnViewTeachersByDegrees.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewTeachersByDegrees.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewTeachersByDegrees.Location = new System.Drawing.Point(6, 99);
            this.btnViewTeachersByDegrees.Name = "btnViewTeachersByDegrees";
            this.btnViewTeachersByDegrees.Size = new System.Drawing.Size(467, 60);
            this.btnViewTeachersByDegrees.TabIndex = 5;
            this.btnViewTeachersByDegrees.Text = "Просмотр преподавателей по специальностям";
            this.btnViewTeachersByDegrees.UseVisualStyleBackColor = false;
            this.btnViewTeachersByDegrees.Click += new System.EventHandler(this.btnViewTeachersByDegrees_Click);
            // 
            // btnViewMarksBySubjects
            // 
            this.btnViewMarksBySubjects.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewMarksBySubjects.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewMarksBySubjects.Location = new System.Drawing.Point(8, 35);
            this.btnViewMarksBySubjects.Name = "btnViewMarksBySubjects";
            this.btnViewMarksBySubjects.Size = new System.Drawing.Size(465, 59);
            this.btnViewMarksBySubjects.TabIndex = 6;
            this.btnViewMarksBySubjects.Text = "Средняя успеваемость по предметам";
            this.btnViewMarksBySubjects.UseVisualStyleBackColor = false;
            this.btnViewMarksBySubjects.Click += new System.EventHandler(this.btnViewMarksBySubjects_Click);
            // 
            // btnViewStudentMarks
            // 
            this.btnViewStudentMarks.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewStudentMarks.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewStudentMarks.Location = new System.Drawing.Point(8, 100);
            this.btnViewStudentMarks.Name = "btnViewStudentMarks";
            this.btnViewStudentMarks.Size = new System.Drawing.Size(465, 58);
            this.btnViewStudentMarks.TabIndex = 7;
            this.btnViewStudentMarks.Text = "Сводка по успеваемости учащихся";
            this.btnViewStudentMarks.UseVisualStyleBackColor = false;
            this.btnViewStudentMarks.Click += new System.EventHandler(this.btnViewStudentMarks_Click);
            // 
            // btnGiveStudentsMarks
            // 
            this.btnGiveStudentsMarks.BackColor = System.Drawing.Color.Orange;
            this.btnGiveStudentsMarks.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGiveStudentsMarks.Location = new System.Drawing.Point(6, 35);
            this.btnGiveStudentsMarks.Name = "btnGiveStudentsMarks";
            this.btnGiveStudentsMarks.Size = new System.Drawing.Size(467, 78);
            this.btnGiveStudentsMarks.TabIndex = 8;
            this.btnGiveStudentsMarks.Text = "Выставление оценок учащимся";
            this.btnGiveStudentsMarks.UseVisualStyleBackColor = false;
            this.btnGiveStudentsMarks.Click += new System.EventHandler(this.btnGiveStudentsMarks_Click);
            // 
            // btnPerformanceEditView
            // 
            this.btnPerformanceEditView.BackColor = System.Drawing.Color.Orange;
            this.btnPerformanceEditView.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPerformanceEditView.Location = new System.Drawing.Point(6, 119);
            this.btnPerformanceEditView.Name = "btnPerformanceEditView";
            this.btnPerformanceEditView.Size = new System.Drawing.Size(467, 70);
            this.btnPerformanceEditView.TabIndex = 9;
            this.btnPerformanceEditView.Text = "Редактирование оценок учащихся";
            this.btnPerformanceEditView.UseVisualStyleBackColor = false;
            this.btnPerformanceEditView.Click += new System.EventHandler(this.btnPerformanceEditView_Click);
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.btnRegisterNewStudent);
            this.registrationGroupBox.Controls.Add(this.btnRegisterNewTeacher);
            this.registrationGroupBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrationGroupBox.Location = new System.Drawing.Point(12, 63);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(479, 139);
            this.registrationGroupBox.TabIndex = 10;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Регистрация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewStudentsByGrades);
            this.groupBox1.Controls.Add(this.btnViewTeachersByDegrees);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(497, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 167);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр баз данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewMarksBySubjects);
            this.groupBox2.Controls.Add(this.btnViewStudentMarks);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(497, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 167);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Успеваемость";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGiveStudentsMarks);
            this.groupBox3.Controls.Add(this.btnPerformanceEditView);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 195);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование успеваемости";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(986, 410);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.btnExitProgramm);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПРИЛОЖЕНИЕ ДЕДЕНЕВСКАЯ ШКОЛА";
            this.registrationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitProgramm;
        private System.Windows.Forms.Button btnRegisterNewStudent;
        private System.Windows.Forms.Button btnRegisterNewTeacher;
        private System.Windows.Forms.Button btnViewStudentsByGrades;
        private System.Windows.Forms.Button btnViewTeachersByDegrees;
        private System.Windows.Forms.Button btnViewMarksBySubjects;
        private System.Windows.Forms.Button btnViewStudentMarks;
        private System.Windows.Forms.Button btnGiveStudentsMarks;
        private System.Windows.Forms.Button btnPerformanceEditView;
        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

