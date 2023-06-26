using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    internal class ProgrammMessages
    {
        public void ShowNoNullAllowedMessage()
        {
            MessageBox.Show(
                "Все поля для ввода должны быть заполнены",
                "ПРИЛОЖЕНИЕ ДЕДЕНЕВСКАЯ ШКОЛА",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public void ShowSuccessMessage()
        {
            MessageBox.Show(
                "Успешно!",
                "ПРИЛОЖЕНИЕ ДЕДЕНЕВСКАЯ ШКОЛА",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
