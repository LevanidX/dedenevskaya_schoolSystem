using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    internal class ViewTables
    {
        public void ShowItemsByFilter(BindingSource bindingSource, String columnName, ComboBox comboBox)
        {
            bindingSource.Filter = $"[{columnName}]='" + comboBox.Text + "'";
        }
    }
}
