using System;

using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class TeacherViewByDegrees : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation();
        ViewTables viewTables = new ViewTables();

        private string _columnName = "diplom_qualification_name";

        public TeacherViewByDegrees()
        {
            InitializeComponent();
        }

        private void TeacherViewByDegrees_Load(object sender, EventArgs e)
        {
            this.diplom_qualificationsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.diplom_qualifications);
            this.teachers_viewTableAdapter.Fill(this.dedenevskaya_schoolDataSet.teachers_view);

            viewTables.ShowItemsByFilter(teachers_viewBindingSource, _columnName, degreeComboBox);
        }

        private void gradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewTables.ShowItemsByFilter(teachers_viewBindingSource, _columnName, degreeComboBox);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
