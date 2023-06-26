using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    internal class ProgrammNavigation
    {
        public void OpenNewWindow(Form currentForm, Form openingForm)
        {
            currentForm.Hide();
            openingForm.Show();
        }

        public void OpenMainMenu(Form currentForm) 
        {
            MainMenu mainMenu = new MainMenu();
            currentForm.Close();
            mainMenu.Show();
        }
    }
}
