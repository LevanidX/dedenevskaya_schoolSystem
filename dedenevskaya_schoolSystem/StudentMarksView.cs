using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class StudentMarksView : Form
    {
        Registration registration = new Registration();
        ProgrammNavigation programmNavigation = new ProgrammNavigation();

        private string _studentColumnName = "student_grade_ID";
        private string _performanceViewStudentName = "student_name";

        public StudentMarksView()
        {
            InitializeComponent();
        }

        private void StudentMarksView_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.students);
            this.gradesTableAdapter.Fill(this.dedenevskaya_schoolDataSet.grades);
            this.performance_new_viewTableAdapter.Fill(this.dedenevskaya_schoolDataSet.performance_new_view);

            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentColumnName);
            registration.UpdatingIndexFields(performance_student_IDComboBox, performance_new_viewBindingSource, _performanceViewStudentName);
        }

        private void grade_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            registration.UpdatingFields(grade_IDComboBox, studentsBindingSource, _studentColumnName);
        }

        private void performance_student_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            registration.UpdatingIndexFields(performance_student_IDComboBox, performance_new_viewBindingSource, _performanceViewStudentName);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
