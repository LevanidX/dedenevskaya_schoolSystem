using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class StudentViewByGrades : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation();
        ViewTables viewTables = new ViewTables();

        private string _columnName = "grade_name";

        public StudentViewByGrades()
        {
            InitializeComponent();
        }

        private void StudentViewByGrades_Load(object sender, EventArgs e)
        {
            this.students_viewTableAdapter.Fill(this.dedenevskaya_schoolDataSet.students_view);
            this.gradesTableAdapter.Fill(this.dedenevskaya_schoolDataSet.grades);
            viewTables.ShowItemsByFilter(students_viewBindingSource, _columnName, gradeComboBox);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }

        private void gradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewTables.ShowItemsByFilter(students_viewBindingSource, _columnName, gradeComboBox);
        }
    }
}
