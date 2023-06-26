using System;
using System.Data;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class StudentPerformance : Form
    {
        Registration registration = new Registration();
        ProgrammMessages programmMessages = new ProgrammMessages();
        ProgrammNavigation programmNavigation = new ProgrammNavigation();

        private string _studentsGradeColumnName = "student_grade_ID";

        public StudentPerformance()
        {
            InitializeComponent();
        }

        private void StudentPerformance_Load(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.dedenevskaya_schoolDataSet.teachers);
            this.school_subjectsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.school_subjects);
            this.studentsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.students);
            this.gradesTableAdapter.Fill(this.dedenevskaya_schoolDataSet.grades);
            this.performanceTableAdapter.Fill(this.dedenevskaya_schoolDataSet.performance);

            registration.BeginRegistration(performanceBindingSource);
            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentsGradeColumnName);
        }

        private void grade_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentsGradeColumnName);
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            registration.EndRegistration(this, performanceBindingSource, tableAdapterManager, dedenevskaya_schoolDataSet);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
