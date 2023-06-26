using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class TeacherRegistration : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation();
        Registration registration = new Registration();

        public TeacherRegistration()
        {
            InitializeComponent();
        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            this.diplom_qualificationsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.diplom_qualifications);

            registration.BeginRegistration(teachersBindingSource);
        }

        private void btnRegisterNewTeacher_Click(object sender, EventArgs e)
        {
            registration.EndRegistration(this, teachersBindingSource, tableAdapterManager, dedenevskaya_schoolDataSet);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
