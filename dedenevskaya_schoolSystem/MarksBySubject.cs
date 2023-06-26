using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dedenevskaya_schoolSystem
{
    public partial class MarksBySubject : Form
    {
        ProgrammNavigation programmNavigation = new ProgrammNavigation();
        public MarksBySubject()
        {
            InitializeComponent();
        }

        private void MarksBySubject_Load(object sender, EventArgs e)
        {
            this.school_subjectsTableAdapter.Fill(this.dedenevskaya_schoolDataSet.school_subjects);
            this.show_avg_markTableAdapter.Fill(this.dedenevskaya_schoolDataSet.show_avg_mark, performance_school_subject_IDComboBox.SelectedIndex);
        }

        private void performance_school_subject_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.show_avg_markTableAdapter.Fill(this.dedenevskaya_schoolDataSet.show_avg_mark, performance_school_subject_IDComboBox.SelectedIndex);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            programmNavigation.OpenMainMenu(this);
        }
    }
}
