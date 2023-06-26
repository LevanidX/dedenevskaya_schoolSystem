using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class PerformanceEditView : Form
    {
        Registration registration = new Registration();
        ProgrammNavigation programmNavigation = new ProgrammNavigation();

        private string _studentColumnName = "student_grade_ID";
        private string _performanceStudentColumnName = "performance_student_ID";
        private string _performanceViewStudentName = "student_name";

        public PerformanceEditView()
        {
            InitializeComponent();
        }

        private void PerformanceEditView_Load(object sender, EventArgs e)
        {
            this.gradesTableAdapter.Fill(this.dedenevskaya_schoolDataSet.grades);
            this.studentsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.students);
            this.teachersTableAdapter.Fill(this.dedenevskaya_schoolDataSet.teachers);

            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentColumnName);
            registration.UpdatingFields(performance_student_IDComboBox, performanceBindingSource, _performanceStudentColumnName);
            registration.UpdatingIndexFields(performance_student_IDComboBox, performance_viewBindingSource, _performanceViewStudentName);

            this.performanceTableAdapter.Fill(this.dedenevskaya_schoolDataSet.performance);
            this.performance_viewTableAdapter.Fill(this.dedenevskaya_schoolDataSet.performance_view);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            registration.EndEditing(this, performanceBindingSource, tableAdapterManager, dedenevskaya_schoolDataSet);
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            performanceBindingSource.MoveNext();
            performance_viewBindingSource.MoveNext();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            performanceBindingSource.MovePrevious();
            performance_viewBindingSource.MovePrevious();
        }

        private void grade_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentColumnName);
        }

        private void performance_student_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            registration.UpdatingFields(performance_student_IDComboBox, performanceBindingSource, _performanceStudentColumnName);
            registration.UpdatingIndexFields(performance_student_IDComboBox, performance_viewBindingSource, _performanceViewStudentName);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
