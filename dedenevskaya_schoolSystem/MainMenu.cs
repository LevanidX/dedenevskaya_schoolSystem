using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class MainMenu : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisterNewStudent_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            programmNavigation.OpenNewWindow(this, studentRegistration);
        }

        private void btnRegisterNewTeacher_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherRegistration = new TeacherRegistration();
            programmNavigation.OpenNewWindow(this, teacherRegistration);
        }

        private void btnViewStudentsByGrades_Click(object sender, EventArgs e)
        {
            StudentViewByGrades studentViewByGrades = new StudentViewByGrades();
            programmNavigation.OpenNewWindow(this, studentViewByGrades);
        }

        private void btnViewTeachersByDegrees_Click(object sender, EventArgs e)
        {
            TeacherViewByDegrees teacherViewByDegrees = new TeacherViewByDegrees();
            programmNavigation.OpenNewWindow(this, teacherViewByDegrees);
        }

        private void btnViewMarksBySubjects_Click(object sender, EventArgs e)
        {
            MarksBySubject marksBySubject = new MarksBySubject();
            programmNavigation.OpenNewWindow(this, marksBySubject);
        }

        private void btnGiveStudentsMarks_Click(object sender, EventArgs e)
        {
            StudentPerformance studentPerformance = new StudentPerformance();
            programmNavigation.OpenNewWindow(this, studentPerformance);
        }

        private void btnPerformanceEditView_Click(object sender, EventArgs e)
        {
            PerformanceEditView performanceEditView = new PerformanceEditView();
            programmNavigation.OpenNewWindow(this, performanceEditView);
        }

        private void btnViewStudentMarks_Click(object sender, EventArgs e)
        {
            StudentMarksView studentMarksView = new StudentMarksView();
            programmNavigation.OpenNewWindow(this, studentMarksView);
        }
    }
}
