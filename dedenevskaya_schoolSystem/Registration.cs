using dedenevskaya_schoolSystem.dedenevskaya_schoolDataSetTableAdapters;
using System.Data;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    internal class Registration
    {
        ProgrammMessages programmMessages = new ProgrammMessages();
        private string _index;

        public void BeginRegistration(BindingSource bindingSource)
        {
            bindingSource.AddNew();
        }

        public void EndRegistration(Form currentForm, BindingSource bindingSource, 
            TableAdapterManager tableAdapterManager, dedenevskaya_schoolDataSet dedenevskaya_SchoolDataSet)
        {
            try
            {
                currentForm.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dedenevskaya_SchoolDataSet);

                programmMessages.ShowSuccessMessage();

                BeginRegistration(bindingSource);
            }
            catch (NoNullAllowedException)
            {
                programmMessages.ShowNoNullAllowedMessage();
            }
        }

        public void EndEditing(Form currentForm, BindingSource bindingSource,
            TableAdapterManager tableAdapterManager, dedenevskaya_schoolDataSet dedenevskaya_SchoolDataSet)
        {
            try
            {
                currentForm.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dedenevskaya_SchoolDataSet);

                programmMessages.ShowSuccessMessage();
            }
            catch (NoNullAllowedException)
            {
                programmMessages.ShowNoNullAllowedMessage();
            }
        }

        public void UpdatingFields(ComboBox comboBox, BindingSource bindingSource, string columnName)
        {
            if (comboBox.SelectedIndex != -1)
            {
                _index = comboBox.SelectedValue.ToString();
                bindingSource.Filter = $"[" + columnName + "]='" + _index + "'";
            }
        }

        public void UpdatingIndexFields(ComboBox comboBox, BindingSource bindingSource, string columnName)
        {
            if (comboBox.SelectedIndex != -1)
            {
                _index = comboBox.Text;
                bindingSource.Filter = $"[" + columnName + "]='" + _index + "'";
            }
        }
    }
}
