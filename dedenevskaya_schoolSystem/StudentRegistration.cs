using System;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class StudentRegistration : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation(); 
        Registration registration = new Registration(); 

        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            this.gradesTableAdapter.Fill(this.dedenevskaya_schoolDataSet.grades);
            registration.BeginRegistration(studentsBindingSource);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }

        private void btnRegisterNewStudent_Click(object sender, EventArgs e)
        {
            registration.EndRegistration(this, studentsBindingSource, tableAdapterManager, dedenevskaya_schoolDataSet);
        }
    }
}
